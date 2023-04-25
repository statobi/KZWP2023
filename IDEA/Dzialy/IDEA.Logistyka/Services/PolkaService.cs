﻿using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Modele;
using IDEA.Logistyka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEA.Logistyka.Services
{
    public class PolkaService
    {
        private readonly Repository<Polka> _polkaRepository = new Repository<Polka>();

        public IEnumerable<PolkaDGV> DataGridData(int sekcjaId)
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
                    Szerokosc = x.Szerokosc,
                    Wysokosc = x.Wysokosc,
                    Glebokosc = x.Glebokosc,
                    Udzwig = x.Udzwig,
                }).ToList();

            return polki;
        }
    }
}