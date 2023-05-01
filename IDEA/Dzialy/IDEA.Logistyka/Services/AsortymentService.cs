using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Enums;
using IDEA.Logistyka.Models;
using System.Collections.Generic;
using System.Linq;

namespace IDEA.Logistyka.Services
{
    public class AsortymentService
    {
        private readonly Repository<RozlozeniePolki_Produkty> _rozlozenieProduktRepository = new Repository<RozlozeniePolki_Produkty>();
        private readonly Repository<RozlozeniePolki_Materialy> _rozlozenieMaterialRepository = new Repository<RozlozeniePolki_Materialy>();
        private readonly Repository<Produkt> _produktRepository = new Repository<Produkt>();
        private readonly Repository<Material> _materialRepository = new Repository<Material>();
        private readonly Repository<Pracownicy> _pracownicyRepository = new Repository<Pracownicy>();
        public IEnumerable<AsortymentDGV> ViewData(int polkaId)
            => GetMaterialy(polkaId)
            .Concat(GetProdukty(polkaId))
            .ToList();

        private IEnumerable<AsortymentDGV> GetMaterialy(int id)
            => _rozlozenieMaterialRepository
            .Get()
            .AsEnumerable()
            .Where(x => x.ID_Polka == id)
            .Select(x => new AsortymentDGV
            {
                Id = x.ID_Material,
                IdPolka = x.ID_Polka,
                IdPracownik = x.ID_Pracownik,
                EmailPracownika = GetPracownikEmail(x.ID_Pracownik),
                Ilosc = x.Ilosc,
                Nazwa = GetNazwaMaterialu(x.ID_Material),
                TypAsortymentu = TypAsortymentu.Material
            }).ToList();

        private IEnumerable<AsortymentDGV> GetProdukty(int id)
            => _rozlozenieProduktRepository
            .Get()
            .AsEnumerable()
            .Where(x => x.ID_Polka == id)
            .Select(x => new AsortymentDGV
            {
                Id = x.ID_Produkt,
                IdPolka = x.ID_Polka,
                IdPracownik = x.ID_Pracownik,
                EmailPracownika = GetPracownikEmail(x.ID_Pracownik),
                Ilosc = x.Ilosc,
                Nazwa = GetNazwaProduktu(x.ID_Produkt),
                TypAsortymentu = TypAsortymentu.Produkt
            }).ToList();

        private string GetPracownikEmail(int id)
            => _pracownicyRepository
            .Get()
            .AsEnumerable()
            .Where(x => x.ID_Pracownicy == id)
            .Select(x => x.E_mail).FirstOrDefault();

        private string GetNazwaMaterialu(int id)
            => _materialRepository
            .Get()
            .AsEnumerable()
            .Where(x => x.ID_Material == id)
            .Select(x => x.Nazwa).FirstOrDefault();

        private string GetNazwaProduktu(int id)
            => _produktRepository
            .Get()
            .AsEnumerable()
            .Where(x => x.ID_Produkt == id)
            .Select(x => x.Nazwa).FirstOrDefault();
    }
}
