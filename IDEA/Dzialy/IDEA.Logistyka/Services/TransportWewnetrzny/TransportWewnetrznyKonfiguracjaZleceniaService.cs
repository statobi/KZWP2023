using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Enums;
using IDEA.Logistyka.Models;
using IDEA.Logistyka.Services.TransportWewnetrzny;
using System.Collections.Generic;
using System.Linq;

namespace IDEA.Logistyka.Services
{
    public class TransportWewnetrznyKonfiguracjaZleceniaService
    {
        private readonly Repository<Magazyn> _magazynRepository = new Repository<Magazyn>();
        private readonly Repository<Produkt> _produktRepository = new Repository<Produkt>();
        private readonly Repository<Material> _materialRepository = new Repository<Material>();
        private readonly Repository<Pojazd> _pojazdRepository = new Repository<Pojazd>();
        private readonly Repository<Pracownicy> _pracownicyRepository = new Repository<Pracownicy>();

        public IEnumerable<MagazynCmb> GetMagazyny()
            => _magazynRepository
            .Get()
            .Where(x => x.ID_Magazyn != 1)
            .Select(x => new MagazynCmb
            {
                IdMagazyn = x.ID_Magazyn,
                Nazwa = x.Nazwa
            });

        public IEnumerable<MagazynZawartosc> GetAsortymentFromMagazyn(int idMagazyn)
            => ZawartoscMaterial(idMagazyn).Concat(ZawartoscProdukt(idMagazyn));

        public IEnumerable<PojazdCmb> GetPojazdy()
            => _pojazdRepository
            .Get()
            .Where(x => x.ModelePojazdu.ID_RodzajPojazdu == 1)
            .AsEnumerable()
            .Select(x => new PojazdCmb
            {
                IdPojazd = x.ID_Pojazd,
                Nazwa = $"{x.ModelePojazdu.Marka} {x.ModelePojazdu.Model} [{x.NrRejestracyjny}]"
            });

        public IEnumerable<PracownicyCmb> GetPracownicy()
            => _pracownicyRepository
            .Get()
            .Where(x => x.Pracownicy_Dzialy.Any(s => s.ID_Dzialy == 2))
            .AsEnumerable()
            .Select(x => new PracownicyCmb
            {
                IdPracownik = x.ID_Pracownicy,
                ImieNazwisko = $"{x.Imie} {x.Nazwisko}"
            });

        public bool AddAsortyment(int idMagazyn, IEnumerable<MagazynZawartosc> magazynZawartosc)
        {
            var dodanieAsortymentuDoPolek = new DodanieAsortymentuDoPolek();

            return dodanieAsortymentuDoPolek.DodanieAsortymentu(idMagazyn, magazynZawartosc);
        }

        private IEnumerable<MagazynZawartosc> ZawartoscMaterial(int idMagazyn)
            => _magazynRepository
                .GetById(idMagazyn)
                .Sekcjas
                .SelectMany(x => x.Polkas)
                .SelectMany(x => x.RozlozeniePolki_Materialy)
                .Where(x => x.DataDo is null)
                .GroupBy(x => x.ID_Material)
                .Select(x => new MagazynZawartosc
                {
                    IdRozlozenie = x.FirstOrDefault().ID_RozlozeniePolki_Materialy,
                    IdAsortyment = x.Key,
                    UfId = $"M{x.Key}",
                    TypAsortymentu = TypAsortymentu.Material,
                    Nazwa = GetMaterialNazwa(x.Key),
                    Ilosc = x.Sum(s => s.Ilosc)
                });


        private IEnumerable<MagazynZawartosc> ZawartoscProdukt(int idMagazyn)
            => _magazynRepository
                .GetById(idMagazyn)
                .Sekcjas
                .SelectMany(x => x.Polkas)
                .SelectMany(x => x.RozlozeniePolki_Produkty)
                .Where(x => x.DataDo is null)
                .GroupBy(x => x.ID_Produkt)
                .Select(x => new MagazynZawartosc
                {
                    IdRozlozenie = x.FirstOrDefault().ID_RozlozeniePolki_Produkty,
                    IdAsortyment = x.Key,
                    UfId = $"M{x.Key}",
                    TypAsortymentu = TypAsortymentu.Produkt,
                    Nazwa = GetMaterialNazwa(x.Key),
                    Ilosc = x.Sum(s => s.Ilosc)
                });

        private string GetProduktNazwa(int idProdukt)
            => _produktRepository
            .GetById(idProdukt)
            .Nazwa;

        private string GetMaterialNazwa(int idMaterial)
            => _materialRepository
            .GetById(idMaterial)
            .Nazwa;
    }
}
