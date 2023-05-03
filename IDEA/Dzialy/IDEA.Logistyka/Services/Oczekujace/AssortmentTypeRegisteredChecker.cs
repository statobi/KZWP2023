using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Models;
using System.Collections.Generic;
using System.Linq;

namespace IDEA.Logistyka.Services.Oczekujace
{
    internal class AssortmentTypeRegisteredChecker
    {
        private readonly Repository<TypZasobu> _typZasobuRepository = new Repository<TypZasobu>();
        private readonly Repository<Material> _materialRepository = new Repository<Material>();
        internal IEnumerable<OczekujaceCheckResponse> Check(IEnumerable<OczekujaceDGV> oczekujaceCollection)
        {
           var materialList = oczekujaceCollection.Where(x => x.TypAsortymentu == Enums.TypAsortymentu.Material).ToList();
           var productList = oczekujaceCollection.Where(x => x.TypAsortymentu == Enums.TypAsortymentu.Produkt).ToList();

           return MaterialCheck(materialList);
        }
        
        private IEnumerable<OczekujaceCheckResponse> MaterialCheck(IEnumerable<OczekujaceDGV> materialCollection)
        {
            var materialIds = materialCollection.Select(x => x.IdAsortyment).Distinct();

            var materials = _materialRepository
                .Get()
                .Where(x => materialIds.Contains(x.ID_Material))
                .ToArray();

            var materialsWithTypZasobu = _typZasobuRepository
                .Get()
                .SelectMany(x => x.Rodzaj_Materialu)
                .SelectMany(x => x.Materials)
                .Where(x => materialIds.Contains(x.ID_Material))
                .ToArray();

            var materialsWithoutTypZasobu = materials
                .Where(x => !materialsWithTypZasobu.Contains(x)).ToArray();

            if (!materialsWithoutTypZasobu.Any())
                return null;

            return materialsWithoutTypZasobu.Select(x => new OczekujaceCheckResponse
            {
                MaterialId = x.ID_Material,
                Nazwa = x.Nazwa,
                TypAsortymentu = Enums.TypAsortymentu.Material,
                IdRodzajMaterialu = x.ID_Rodzaj_Materialu,
                RodzajMaterialu = x.Rodzaj_Materialu.Nazwa
            });
        }
    }
}
