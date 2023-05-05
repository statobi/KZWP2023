using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Enums;
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
        private readonly Repository<Magazyn> _magazynRepository = new Repository<Magazyn>();

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

        public IEnumerable<OczekujaceDGV> ShelfCheck(int idMagazyn, IEnumerable<OczekujaceDGV> oczekujaceCollection)
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

        public void UpdateNierozlozonyAsortyment(IEnumerable<OczekujaceDGV> oczekujaceCollection)
        {
            var materialy = oczekujaceCollection.Where(x => x.TypAsortymentu == TypAsortymentu.Material);
            var produkty = oczekujaceCollection.Where(x => x.TypAsortymentu == TypAsortymentu.Produkt);

            if (materialy.Any())
                UpdateNierozlozoneMaterialy(materialy);

            if (produkty.Any())
                UpdateNierozlozoneProdukty(produkty);
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
                Id = x.ID_NierozlozoneProdukty,
                UfId = $"P{x.ID_NierozlozoneProdukty}",
                IdAsortyment = x.ID_Produkt,
                Nazwa = x.Produkt.Nazwa,
                Ilosc = x.Ilosc,
                TypAsortymentu = Enums.TypAsortymentu.Produkt,
                DataOd = x.DataOd
            });
    }
}
