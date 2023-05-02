using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Models;
using System.Collections.Generic;
using System.Linq;

namespace IDEA.Logistyka.Services.Oczekujace
{
    internal class AssortmentChecker
    {
        private readonly Repository<Rodzaj_Materialu> _rodzajMaterialyRepository = new Repository<Rodzaj_Materialu>();
        private readonly Repository<TypZasobu> _typZasobuRepository = new Repository<TypZasobu>();
        private readonly Repository<Material> _materialRepository = new Repository<Material>();
        internal bool Check(IEnumerable<OczekujaceDGV> oczekujaceCollection)
        {
            var materialList = oczekujaceCollection.Where(x => x.TypAsortymentu == Enums.TypAsortymentu.Material).ToList();
            var productList = oczekujaceCollection.Where(x => x.TypAsortymentu == Enums.TypAsortymentu.Produkt).ToList();

           return MaterialCheck(materialList);
        }
        
        private bool MaterialCheck(IEnumerable<OczekujaceDGV> materialCollection)
        {
            var materialIds = materialCollection.Select(x => x.Id);

            var rodzajMaterialuIds = _materialRepository
                .Get()
                .Where(x => materialIds.Contains(x.ID_Material))
                .Select(x => x.Rodzaj_Materialu.ID_Rodzaj_Materialu)
                .Distinct()
                .ToArray();

            var result = _typZasobuRepository.Get()
                .SelectMany(x => x.Rodzaj_Materialu)
                .Where(x => rodzajMaterialuIds.Contains(x.ID_Rodzaj_Materialu)).ToList();

            return result.Any();
        }
    }
}
