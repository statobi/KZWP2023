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

        public bool Check(int idMagazyn, IEnumerable<OczekujaceDGV> oczekujaceCollection)
        {
            var materialList = oczekujaceCollection.Where(x => x.TypAsortymentu == Enums.TypAsortymentu.Material).ToList();
            //var productList = oczekujaceCollection.Where(x => x.TypAsortymentu == Enums.TypAsortymentu.Produkt).ToList(); TODO: Zrobić także dla produktów!

            var sekcjaTypes = _sekcjaRepository
                .Get()
                .Where(x => x.ID_Magazyn == idMagazyn)
                .Select(x => x.ID_TypZasobu).ToArray();

            var materialIds = materialList.Select(x => x.IdAsortyment).Distinct();

            //var materialTyps = _materialRepository
            //    .Get()
            //    .Where(x => materialIds.Contains(x.ID_Material))
            //    .SelectMany(x => x.Rodzaj_Materialu.TypZasobus)
            //    .Select(x => x.ID_TypZasobu).ToArray();

            return true;
        }
    }
}
