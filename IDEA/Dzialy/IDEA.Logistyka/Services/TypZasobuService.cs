using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IDEA.Logistyka.Services
{
    public class TypZasobuService
    {
        private readonly Repository<TypZasobu> _typZasoburepository = new Repository<TypZasobu>();
        private readonly Repository<Sekcja> _sekcjaRepository = new Repository<Sekcja>();
        private readonly Repository<Magazyn> _magazynRepository = new Repository<Magazyn>();

        public IEnumerable<TypZasobuCmb> ViewData() => GetTypZasobu();

        public IEnumerable<TypyZasobowChart> ChartData()
        {
            var result = new Dictionary<string, double>();

            var wholePowierzchniaRobocza = WholePowierzchniaRobocza();
            var avaliablePowierzchniaRobocza = wholePowierzchniaRobocza;
            var typZasobuPowierzchniaRoboczaCollection = GetTypZasobuPowierzchniaRobocza();
            var typyZasobow = GetTypZasobu();

            foreach (var typZasobuPowierzchniaRobocza in typZasobuPowierzchniaRoboczaCollection)
            {
                var typZasobuNazwa = typyZasobow.FirstOrDefault(x => x.Id == typZasobuPowierzchniaRobocza.IdTypZasobu).Name;

                if (!result.ContainsKey(typZasobuNazwa))
                {
                    result.Add(typZasobuNazwa, typZasobuPowierzchniaRobocza.PowierzchniaRobocza);
                    avaliablePowierzchniaRobocza -= typZasobuPowierzchniaRobocza.PowierzchniaRobocza;
                    continue;
                }

                result[typZasobuNazwa] += typZasobuPowierzchniaRobocza.PowierzchniaRobocza;
                avaliablePowierzchniaRobocza -= typZasobuPowierzchniaRobocza.PowierzchniaRobocza;
            }
            result.Add("Dostępna przestrzeń", avaliablePowierzchniaRobocza);

            return MapToIEnumerable(result, wholePowierzchniaRobocza);
        }

        private double WholePowierzchniaRobocza()
            => _magazynRepository
            .Get()
            .AsEnumerable()
            .Sum(x => x.PowierzchniaRobocza);

        private IEnumerable<TypZasobuCmb> GetTypZasobu()
            => _typZasoburepository
                .Get()
                .AsEnumerable()
                .Select(x => new TypZasobuCmb
                {
                    Id = x.ID_TypZasobu,
                    Name = x.Nazwa
                }).ToList();

        private IEnumerable<TypZasobuPowierzchniaRobocza> GetTypZasobuPowierzchniaRobocza()
            => _sekcjaRepository
                .Get()
                .AsEnumerable()
                .Select(x => new TypZasobuPowierzchniaRobocza
                {
                    IdTypZasobu = x.ID_TypZasobu,
                    PowierzchniaRobocza = x.PowierzchniaRobocza
                });

        private IEnumerable<TypyZasobowChart> MapToIEnumerable(Dictionary<string, double> inputDictionary, double wholePowierzchniaRobocza)
            => inputDictionary.Select(x => new TypyZasobowChart
            {
                Nazwa = x.Key,
                PowierzchniaRobocza = x.Value,
                Percentage = Math.Round(( x.Value / wholePowierzchniaRobocza ) * 100)
            });
    }
}
