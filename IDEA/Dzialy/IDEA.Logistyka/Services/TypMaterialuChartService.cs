using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IDEA.Logistyka.Services
{
    public class TypMaterialuChartService
    {
        private readonly Repository<TypZasobu> _typZasoburepository = new Repository<TypZasobu>();
        private readonly Repository<Sekcja> _sekcjaRepository = new Repository<Sekcja>();
        private readonly Repository<Magazyn> _magazynRepository = new Repository<Magazyn>();

        public IEnumerable<TypZasobuCmb> ViewData() => GetTypZasobu();

        public IEnumerable<TypyZasobowChart> ChartData()
        {
            var typZasobuPowierzchniaRoboczaCollection = GetTypZasobuPowierzchniaRobocza();
            var wholePowierzchniaRobocza = WholePowierzchniaRobocza();
            var avaliablePowierzchniaRobocza = wholePowierzchniaRobocza;

            return SumPowierzchniaRobocza(typZasobuPowierzchniaRoboczaCollection, wholePowierzchniaRobocza, avaliablePowierzchniaRobocza);
        }

        public IEnumerable<TypyZasobowChart> ChartData(int magazynId)
        {
            var typZasobuPowierzchniaRoboczaCollection = GetTypZasobuPowierzchniaRobocza(magazynId);
            var wholePowierzchniaRobocza = WholePowierzchniaRobocza(magazynId);
            var avaliablePowierzchniaRobocza = wholePowierzchniaRobocza;

            return SumPowierzchniaRobocza(typZasobuPowierzchniaRoboczaCollection, wholePowierzchniaRobocza, avaliablePowierzchniaRobocza);
        }

        private IEnumerable<TypyZasobowChart> SumPowierzchniaRobocza(IEnumerable<TypZasobuPowierzchniaRobocza> typZasobuPowierzchniaRoboczaCollection, double wholePowierzchniaRobocza, double avaliablePowierzchniaRobocza)
        {
            var result = new Dictionary<string, double>();
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

        public IEnumerable<MagazynChart> GetMagazyny()
            => _magazynRepository
            .Get()
            .AsEnumerable()
            .Select(x => new MagazynChart
            {
                Id = x.ID_Magazyn,
                Nazwa = x.Nazwa
            });

        private double WholePowierzchniaRobocza()
            => _magazynRepository
            .Get()
            .AsEnumerable()
            .Sum(x => x.PowierzchniaRobocza);

        private double WholePowierzchniaRobocza(int magazynId)
            => _magazynRepository
            .GetById(magazynId).PowierzchniaRobocza;

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
                
        private IEnumerable<TypZasobuPowierzchniaRobocza> GetTypZasobuPowierzchniaRobocza(int magazynId)
            => _sekcjaRepository
            .Get()
            .Where(x => x.ID_Magazyn == magazynId)
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
