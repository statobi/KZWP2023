using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Enums;
using IDEA.Logistyka.Models;
using IDEA.Logistyka.Services.Oczekujace;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

namespace IDEA.Logistyka.Services
{
    public class OczekujaceService
    {
        private readonly Repository<Nierozlozone_Materialy> _nierozlozoneMaterialyRepository = new Repository<Nierozlozone_Materialy>();
        private readonly Repository<Nierozlozone_Produkty> _nierozlozoneProduktyRepository = new Repository<Nierozlozone_Produkty>();
        private readonly Repository<Magazyn> _magazynRepository = new Repository<Magazyn>();
        private readonly Repository<Material> _materialRepository = new Repository<Material>();
        private readonly Repository<Produkt> _produktRepository = new Repository<Produkt>();

        public IEnumerable<OczekujaceDGV> ViewData()
            => GetMaterialy().Concat(GetProdukty()).OrderBy(x => x.DataOd);

        public IEnumerable<OczekujaceCheckResponse> CheckAssortmentTypeIsRegistered(IEnumerable<OczekujaceDGV> oczekujaceCollection)
        {
            var assortmentChecker = new AssortmentTypeRegisteredChecker();

            return assortmentChecker.Check(oczekujaceCollection);
        }

        public bool CheckMagazynHasAssortmentTypeSekcja(int idMagazyn, IEnumerable<OczekujaceDGV> oczekujaceCollection)
        {
            var checker = new MagazynSekcjaTypeChecker();

            return checker.Check(idMagazyn, oczekujaceCollection);
        }

        public bool ShelfCheck(int idMagazyn, IEnumerable<OczekujaceDGV> oczekujaceCollection)
        {
            var checker = new ShelfChecker();

            return checker.Check(idMagazyn, oczekujaceCollection);
        }

        public IEnumerable<MagazynCmb> GetMagazyny()
            => _magazynRepository
            .Get()
            .Select(x => new MagazynCmb
            {
                IdMagazyn = x.ID_Magazyn,
                Nazwa = x.Nazwa
            });

        public void UpdateNierozlozonyAsortyment(IEnumerable<OczekujaceDGV> oczekujaceCollection, IEnumerable<int> oczekujacaIlosc)
        {
            var materialy = oczekujaceCollection.Where(x => x.TypAsortymentu == TypAsortymentu.Material);
            var produkty = oczekujaceCollection.Where(x => x.TypAsortymentu == TypAsortymentu.Produkt);

            materialy = FixIlosc(materialy, oczekujacaIlosc);
            produkty = FixIlosc(produkty, oczekujacaIlosc);

            if (materialy.Any())
                UpdateNierozlozoneMaterialy(materialy);

            if (produkty.Any())
                UpdateNierozlozoneProdukty(produkty);
        }

        private IEnumerable<OczekujaceDGV> FixIlosc(IEnumerable<OczekujaceDGV> oczekujaceCollection, IEnumerable<int> oczekujacaIlosc)
        {
            var result = new List<OczekujaceDGV>();
            for (int i = 0; i < oczekujaceCollection.Count(); i++)
            {
                int? ilosc = oczekujacaIlosc.ElementAtOrDefault(i);
                result.Add(new OczekujaceDGV
                {
                    Id = oczekujaceCollection.ElementAt(i).Id,
                    Ilosc = ilosc ?? 0,
                    DataOd = oczekujaceCollection.ElementAt(i).DataOd,
                    IdAsortyment = oczekujaceCollection.ElementAt(i).IdAsortyment,
                    Nazwa = oczekujaceCollection.ElementAt(i).Nazwa,
                    TypAsortymentu = oczekujaceCollection.ElementAt(i).TypAsortymentu,
                    UfId = oczekujaceCollection.ElementAt(i).UfId
                });
            }

            return result;
        }

        private void UpdateNierozlozoneMaterialy(IEnumerable<OczekujaceDGV> oczekujaceCollection)
        {
            foreach (var item in oczekujaceCollection)
            {
                var material = _nierozlozoneMaterialyRepository.GetById(item.Id);

                material.Ilosc = item.Ilosc;
                _nierozlozoneMaterialyRepository.SaveChanges();
            }
        }
        
        private void UpdateNierozlozoneProdukty(IEnumerable<OczekujaceDGV> oczekujaceCollection)
        {
            foreach (var item in oczekujaceCollection)
            {
                var produkt = _nierozlozoneProduktyRepository.GetById(item.Id);

                produkt.Ilosc = item.Ilosc;
                _nierozlozoneProduktyRepository.SaveChanges();
            }
        }

        private IEnumerable<OczekujaceDGV> GetMaterialy()
            => _nierozlozoneMaterialyRepository
            .Get()
            .AsEnumerable()
            .Where(x => x.DataDo is null)
            .Select(x => new OczekujaceDGV
            {
                Id = x.ID_NierozlozoneMaterialy,
                UfId = $"M{x.ID_NierozlozoneMaterialy}",
                IdAsortyment = x.ID_Material,
                Nazwa = GetMaterialName(x.ID_Material),
                Ilosc = x.Ilosc,
                TypAsortymentu = TypAsortymentu.Material,
                DataOd = x.DataOd
            });

        private IEnumerable<OczekujaceDGV> GetProdukty()
            => _nierozlozoneProduktyRepository
            .Get()
            .AsEnumerable()
            .Where(x => x.DataDo is null)
            .Select(x => new OczekujaceDGV
            {
                Id = x.ID_NierozlozoneProdukty,
                UfId = $"P{x.ID_NierozlozoneProdukty}",
                IdAsortyment = x.ID_Produkt,
                Nazwa = GetProduktName(x.ID_Produkt),
                Ilosc = x.Ilosc,
                TypAsortymentu = TypAsortymentu.Produkt,
                DataOd = x.DataOd
            });

        private string GetMaterialName(int idMaterial)
            => _materialRepository
            .GetById(idMaterial)
            .Nazwa;
        
        private string GetProduktName(int idMaterial)
            => _produktRepository
            .GetById(idMaterial)
            .Nazwa;
    }
}
