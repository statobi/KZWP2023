﻿using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Models;
using System.Collections.Generic;
using System.Linq;

namespace IDEA.Logistyka.Services
{
    public class SekcjaService
    {
        private readonly Repository<Sekcja> _sekcjaRepo = new Repository<Sekcja>();
        private readonly Repository<TypZasobu> _typZasobuRepo = new Repository<TypZasobu>();

        public IEnumerable<SekcjaDGV> DataGridData(int magazynId)
        {
            var sekcja = _sekcjaRepo
                .Get()
                .Where(x => x.ID_Magazyn == magazynId)
                .AsEnumerable()
                .Select(x => new SekcjaDGV
                {
                    Id = x.ID_Sekcja,
                    IdMagazyn= x.ID_Magazyn,
                    PowierzchniaRobocza = $"{x.PowierzchniaRobocza}m²",
                    TypZasobu = GetTypZasobu(x.ID_TypZasobu),
                    Numer = x.Numer,
                    
                }).ToList();

            return sekcja;
        }

        private string GetTypZasobu(int Id)
        {
            var typyZasobu = _typZasobuRepo
                .Get()
                .Where(x => x.ID_TypZasobu == Id)
                .AsEnumerable()
                .Select(x => x.Nazwa)
                .ToList();

            return typyZasobu.Aggregate((prev, next) => $"{prev}, {next}");
        }
    }
}