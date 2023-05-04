using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IDEA.Logistyka.Services.Oczekujace
{
    internal class ShelfChecker
    {
        private readonly Repository<Sekcja> _sekcjaRepository = new Repository<Sekcja>();
        private readonly Repository<Material> _materialRepository = new Repository<Material>();
        private readonly Repository<RozlozeniePolki_Materialy> _materialRozlozenieRepository = new Repository<RozlozeniePolki_Materialy>();
        public IEnumerable<OczekujaceDGV> Check(int idMagazyn, IEnumerable<OczekujaceDGV> oczekujaceCollection)
        {
            var materialList = oczekujaceCollection.Where(x => x.TypAsortymentu == Enums.TypAsortymentu.Material).ToList();
            //var productList = oczekujaceCollection.Where(x => x.TypAsortymentu == Enums.TypAsortymentu.Produkt).ToList(); TODO: Zrobić także dla produktów!

            return MaterialCheck(idMagazyn, materialList);
        }

        private IEnumerable<OczekujaceDGV> MaterialCheck(int idMagazyn, IEnumerable<OczekujaceDGV> materials)
        {
            var materialsRemaining = new List<OczekujaceDGV>();

            foreach (var materialDGV in materials)
            {
                var material = _materialRepository
                    .GetById(materialDGV.Id);

                var materialType = material
                    .Rodzaj_Materialu.ID_TypZasobu;

                var polkasWithGivenType = _sekcjaRepository
                    .Get()
                    .Where(x => x.ID_Magazyn == idMagazyn && x.ID_TypZasobu == materialType)
                    .SelectMany(x => x.Polkas).ToArray();

                var materialsRemainingCount = materialDGV.Ilosc;

                foreach (var polka in polkasWithGivenType)
                {
                    var result = PolkaCapacityChecker(polka, material);

                    if (result >= materialsRemainingCount)
                    {
                        _materialRozlozenieRepository.Add(new RozlozeniePolki_Materialy
                        {
                            ID_Material = material.ID_Material,
                            DataOd = DateTime.Now,
                            ID_Polka = polka.ID_Polka,
                            ID_Pracownik = 1,
                            Ilosc = materialsRemainingCount,
                        });
                        break;
                    }

                    if (result > 0)
                    {
                        materialsRemainingCount =- result;
                        _materialRozlozenieRepository.Add(new RozlozeniePolki_Materialy
                        {
                            ID_Material = material.ID_Material,
                            DataOd = DateTime.Now,
                            ID_Polka = polka.ID_Polka,
                            ID_Pracownik = 1,
                            Ilosc = result,
                        });
                    }
                }

                if (materialsRemainingCount > 0)
                {
                    materialsRemaining.Add(new OczekujaceDGV
                    {
                        Id = materialDGV.Id,
                        UfId = materialDGV.UfId,
                        IdAsortyment = materialDGV.IdAsortyment,
                        Nazwa = materialDGV.Nazwa,
                        DataOd = materialDGV.DataOd,
                        TypAsortymentu = materialDGV.TypAsortymentu,
                        Ilosc = materialsRemainingCount
                    });
                }
            }

            return materialsRemaining;
        }

        private int PolkaCapacityChecker(Polka polka, Material material)
        {
            if (material.Szerokosc > polka.SzerokoscPietra)
                return 0;

            if (material.Glebokosc > polka.DlugoscPietra)
                return 0;

            if (material.Wysokosc > polka.WysokoscPietra)
                return 0;

            // Udzwig

            var rozlozenie = _materialRozlozenieRepository
                .Get()
                .Where(x => x.ID_Polka == polka.ID_Polka)
                .Select(x => x.Material).Sum(x => x.Masa) ?? 0;

            var avaliableUdzwig = polka.Udzwig - rozlozenie;

            var quantityOfItemsToAddMasa = (int)Math.Floor((double)(avaliableUdzwig / material.Masa));

            // Powierzchnia

            var reservedPowierzchnia = _materialRozlozenieRepository
                .Get()
                .Where(x => x.ID_Polka == polka.ID_Polka)
                .Select(x => x.Material)
                .Sum(x => x.Glebokosc * x.Szerokosc) ?? 0;

            var avaliablePowierzchia = (polka.DlugoscPietra * polka.SzerokoscPietra * polka.LiczbaPieter) - reservedPowierzchnia;

            var quantityOfItemsToAddPowierzchnia = (int)Math.Floor((double)(avaliablePowierzchia / (material.Szerokosc * material.Glebokosc)));

            return quantityOfItemsToAddMasa >= quantityOfItemsToAddPowierzchnia ? quantityOfItemsToAddPowierzchnia : quantityOfItemsToAddMasa;
        }
    }
}
