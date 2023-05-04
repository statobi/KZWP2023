using IDEA.Database.Repozytoria;
using IDEA.Database;
using IDEA.Logistyka.Models;
using System.Collections.Generic;
using System.Linq;

namespace IDEA.Logistyka.Services.Oczekujace
{
    internal class MagazynSekcjaTypeChecker
    {
        private readonly Repository<Sekcja> _sekcjaRepository = new Repository<Sekcja>();
        private readonly Repository<Material> _materialRepository = new Repository<Material>();
        private readonly Repository<Produkt> _productRepository = new Repository<Produkt>();

        public bool Check(int idMagazyn, IEnumerable<OczekujaceDGV> oczekujaceCollection)
        {
            var materialList = oczekujaceCollection.Where(x => x.TypAsortymentu == Enums.TypAsortymentu.Material).ToList();
            var productList = oczekujaceCollection.Where(x => x.TypAsortymentu == Enums.TypAsortymentu.Produkt).ToList();

            var sekcjaTypes = _sekcjaRepository
                .Get()
                .Where(x => x.ID_Magazyn == idMagazyn)
                .Select(x => x.ID_TypZasobu).ToArray();

            var materialIds = materialList.Select(x => x.IdAsortyment).Distinct();
            var productIds = productList.Select(x => x.IdAsortyment).Distinct();

            var materialTypes = _materialRepository
                .Get()
                .Where(x => materialIds.Contains(x.ID_Material))
                .Select(x => x.Rodzaj_Materialu.ID_TypZasobu)
                .ToArray();
                
            var productsTypes = _productRepository
                .Get()
                .Where(x => productIds.Contains(x.ID_Produkt))
                .Select(x => x.Rodzaj_Produktu.ID_TypZasobu)
                .ToArray();

            return materialTypes.All(x => sekcjaTypes.Contains(x)) &&
                   productsTypes.All(x => sekcjaTypes.Contains(x));
        }
    }
}
