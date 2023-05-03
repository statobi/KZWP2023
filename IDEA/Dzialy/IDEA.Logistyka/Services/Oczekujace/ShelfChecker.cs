using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEA.Logistyka.Services.Oczekujace
{
    internal class ShelfChecker
    {
        private readonly Repository<Magazyn> _magazynRepository = new Repository<Magazyn>();
        private readonly Repository<Material> _materialRepository = new Repository<Material>();
        public void Check(int idMagazyn, IEnumerable<OczekujaceDGV> oczekujaceCollection)
        {
            var materialList = oczekujaceCollection.Where(x => x.TypAsortymentu == Enums.TypAsortymentu.Material).ToList();
            //var productList = oczekujaceCollection.Where(x => x.TypAsortymentu == Enums.TypAsortymentu.Produkt).ToList(); TODO: Zrobić także dla produktów!

            MaterialCheck(idMagazyn, materialList);
        }

        private void MaterialCheck(int idMagazyn, IEnumerable<OczekujaceDGV> materials)
        {
            foreach (var material in materials)
            {
                var materialType = _materialRepository
                    .GetById(material.Id)
                    .Rodzaj_Materialu.TypZasobus;
            }
        }
    }
}
