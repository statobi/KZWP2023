using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Models;
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

        private IEnumerable<OczekujaceDGV> GetMaterialy()
            => _nierozlozoneMaterialyRepository
            .Get()
            .AsEnumerable()
            .Where(x => x.DataDo is null)
            .Select(x => new OczekujaceDGV
            {
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
                Nazwa = x.Produkt.Nazwa,
                Ilosc = x.Ilosc,
                TypAsortymentu = Enums.TypAsortymentu.Produkt,
                DataOd = x.DataOd
            });
    }
}
