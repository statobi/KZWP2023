using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IDEA.Logistyka.Services
{
    public class SekcjaService
    {
        private readonly Repository<Magazyn> _magazynRepo = new Repository<Magazyn>();
        private readonly Repository<Sekcja> _sekcjaRepo = new Repository<Sekcja>();
        private readonly Repository<TypZasobu> _typZasobuRepo = new Repository<TypZasobu>();

        public IEnumerable<SekcjaDGV> ViewData(int magazynId)
        {
            var sekcja = _sekcjaRepo
                .Get()
                .Where(x => x.ID_Magazyn == magazynId)
                .AsEnumerable()
                .Select(x => new SekcjaDGV
                {
                    Id = x.ID_Sekcja,
                    IdMagazyn= x.ID_Magazyn,
                    PowierzchniaRobocza = x.PowierzchniaRobocza,
                    TypZasobu = GetTypZasobuName(x.ID_TypZasobu),
                    ZajetaPrzestrzenRobocza = ZajetaPrzestrzenRobocza(x.ID_Sekcja),
                    Zapelnienie = ZapelnienieSekcji(x.ID_Sekcja),
                    Numer = x.Numer,
                    
                }).ToList();

            return sekcja;
        }

        public double AvaliblePowierzchniaRobocza(int magazynId)
        {
            var sumOfReservedPowierzchniaRobocza = _sekcjaRepo
            .Get()
            .Where(x => x.ID_Magazyn == magazynId)
            .AsEnumerable()
            .Sum(x => x.PowierzchniaRobocza);

            var magazynPowierzchniaRobocza = _magazynRepo
                .GetById(magazynId).PowierzchniaRobocza;

            return magazynPowierzchniaRobocza - sumOfReservedPowierzchniaRobocza;
        }

        public void AddSekcja(SekcjaAdd sekcja)
        {
            _sekcjaRepo.Add(new Sekcja
            {
                ID_Magazyn = sekcja.IdMagazyn,
                ID_TypZasobu = sekcja.IdTypZasobu,
                Numer = sekcja.Numer,
                PowierzchniaRobocza = sekcja.InsertedPowierzchniaRobocza,
            });
        }

        private double ZapelnienieSekcji(int idSekcja)
        {
            double lacznieZapelnienie = 0;
            double laczneObciazenie = 0;
            double lacznaPowierzchnia = 0;
            double lacznaPowierzchniaRobocza = 0;
            double lacznyUdzwig = 0;
            var sekcja = _sekcjaRepo
                .GetById(idSekcja);

            foreach (var polka in sekcja.Polkas)
            {
                var materialyZajetosc = polka
                    .RozlozeniePolki_Materialy
                    .Select(x => x.Ilosc * x.Material.Glebokosc * x.Material.Szerokosc)
                    .Sum() ?? 0;

                var produktyZajetosc = polka
                    .RozlozeniePolki_Produkty
                    .Select(x => x.Ilosc * x.Produkt.Glebokosc * x.Produkt.Szerokosc)
                    .Sum();

                var materialyObciazenie = polka
                    .RozlozeniePolki_Materialy
                    .Select(x => x.Ilosc * x.Material.Masa)
                    .Sum() ?? 0;

                var produktyObciazenie = polka
                    .RozlozeniePolki_Produkty
                    .Select(x => x.Ilosc * x.Produkt.Masa)
                    .Sum();

                laczneObciazenie += materialyObciazenie + produktyObciazenie;
                lacznyUdzwig += polka.Udzwig;

                lacznieZapelnienie += materialyZajetosc + produktyZajetosc;

                lacznaPowierzchnia += polka.LiczbaPieter * polka.SzerokoscPietra * polka.DlugoscPietra;

                lacznaPowierzchniaRobocza += polka.SzerokoscPietra * polka.DlugoscPietra;
            }

            var procentZapelnieniaPolek = Math.Round(lacznieZapelnienie / lacznaPowierzchnia * 10000) / 100;
            var procentWolnejPowierzchniaRoboczaSekcji = Math.Round((sekcja.PowierzchniaRobocza - lacznaPowierzchniaRobocza) / sekcja.PowierzchniaRobocza * 10000) / 100;
            var procentZajetejPowierzchniRoboczejSekcji = 100 - procentWolnejPowierzchniaRoboczaSekcji;

            return Math.Round(procentZapelnieniaPolek * procentZajetejPowierzchniRoboczejSekcji) / 100;
        }

        private double ZajetaPrzestrzenRobocza(int idSekcja)
        {
            double lacznaPowierzchniaRobocza = 0;

            var sekcja = _sekcjaRepo
                .GetById(idSekcja);

            foreach (var polka in sekcja.Polkas)
                lacznaPowierzchniaRobocza += polka.SzerokoscPietra * polka.DlugoscPietra;

            var procentWolnejPowierzchniaRoboczaSekcji = Math.Round((sekcja.PowierzchniaRobocza - lacznaPowierzchniaRobocza) / sekcja.PowierzchniaRobocza * 10000) / 100;
            return Math.Round( 100 - procentWolnejPowierzchniaRoboczaSekcji);
        }

        private string GetTypZasobuName(int Id)
            => _typZasobuRepo
                .Get()
                .Where(x => x.ID_TypZasobu == Id)
                .AsEnumerable()
                .Select(x => x.Nazwa)
                .FirstOrDefault();
    }
}
