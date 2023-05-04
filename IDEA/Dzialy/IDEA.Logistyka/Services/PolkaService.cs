using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IDEA.Logistyka.Services
{
    public class PolkaService
    {
        private readonly Repository<Polka> _polkaRepository = new Repository<Polka>();

        public IEnumerable<PolkaDGV> ViewData(int sekcjaId)
        {
            var polki = _polkaRepository
                .Get()
                .AsEnumerable()
                .Where(x => x.ID_Sekcja == sekcjaId)
                .Select(x => new PolkaDGV
                {
                    Id = x.ID_Polka,
                    IdSekcja = x.ID_Sekcja,
                    Numer = x.Numer,
                    Szerokosc = x.SzerokoscPietra,
                    Wysokosc = x.WysokoscPietra,
                    Glebokosc = x.DlugoscPietra,
                    Zajetosc = ZajetoscPolki(x.ID_Polka),
                    Obciazenie = ObciazeniePolki(x.ID_Polka),
                    Udzwig = x.Udzwig,
                }).ToList();

            return polki;
        }

        private double ZajetoscPolki(int idPolka)
        {
            var polka = _polkaRepository
                .GetById(idPolka);

            var materialyZajetosc = polka
                .RozlozeniePolki_Materialy
                .Select(x => x.Ilosc * x.Material.Glebokosc * x.Material.Szerokosc)
                .Sum() ?? 0;

            var produktyZajetosc = polka
                .RozlozeniePolki_Produkty
                .Select(x => x.Ilosc * x.Produkt.Glebokosc * x.Produkt.Szerokosc)
                .Sum();

            var lacznaZajetosc = materialyZajetosc + produktyZajetosc;

            var powierzchniaPolki = polka.LiczbaPieter * polka.SzerokoscPietra * polka.DlugoscPietra;

            return Math.Round(lacznaZajetosc / powierzchniaPolki * 10000) / 100;
        }

        private double ObciazeniePolki(int idPolka)
        {
            var polka = _polkaRepository
                .GetById(idPolka);

            var materialyObciazenie = polka
                .RozlozeniePolki_Materialy
                .Select(x => x.Ilosc * x.Material.Masa)
                .Sum() ?? 0;

            var produktyObciazenie = polka
                .RozlozeniePolki_Produkty
                .Select(x => x.Ilosc * x.Produkt.Masa)
                .Sum();

            var laczneObciazenie = materialyObciazenie + produktyObciazenie;

            return Math.Round(laczneObciazenie / polka.Udzwig * 10000) / 100;
        }
    }
}
