﻿using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Models;
using IDEA.Logistyka.Services.Oczekujace;
using System.Collections.Generic;
using System.Linq;

namespace IDEA.Logistyka.Services
{
    public class OczekujaceService
    {
        private readonly Repository<Nierozlozone_Materialy> _nierozlozoneMaterialyRepository = new Repository<Nierozlozone_Materialy>();
        private readonly Repository<Nierozlozone_Produkty> _nierozlozoneProduktyRepository = new Repository<Nierozlozone_Produkty>();

        public IEnumerable<OczekujaceDGV> ViewData()
            => GetMaterialy().Concat(GetProdukty()).OrderBy(x => x.DataOd);

        public IEnumerable<OczekujaceCheckResponse> CheckAssortmentTypeIsRegistered(IEnumerable<OczekujaceDGV> oczekujaceCollection)
        {
            var assortmentChecker = new AssortmentChecker();

            return assortmentChecker.Check(oczekujaceCollection);
        }
        
        private IEnumerable<OczekujaceDGV> GetMaterialy()
            => _nierozlozoneMaterialyRepository
            .Get()
            .AsEnumerable()
            .Where(x => x.DataDo is null)
            .Select(x => new OczekujaceDGV
            {
                Id = x.ID_Material,
                Nazwa = x.Material.Nazwa,
                Ilosc = x.Ilosc,
                TypAsortymentu = Enums.TypAsortymentu.Material,
                DataOd = x.DataOd
            });

        private IEnumerable<OczekujaceDGV> GetProdukty()
            => _nierozlozoneProduktyRepository
            .Get()
            .AsEnumerable()
            .Where(x => x.DataDo is null)
            .Select(x => new OczekujaceDGV
            {
                Id = x.ID_Produkt,
                Nazwa = x.Produkt.Nazwa,
                Ilosc = x.Ilosc,
                TypAsortymentu = Enums.TypAsortymentu.Produkt,
                DataOd = x.DataOd
            });
    }
}