using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IDEA.Logistyka.Services.TransportWewnetrzny
{
    internal class DodanieAsortymentuDoPolek
    {
        private readonly Repository<Sekcja> _sekcjaRepository = new Repository<Sekcja>();
        private readonly Repository<Material> _materialRepository = new Repository<Material>();
        private readonly Repository<Produkt> _productRepository = new Repository<Produkt>();
        private readonly Repository<RozlozeniePolki_Materialy> _materialRozlozenieRepository = new Repository<RozlozeniePolki_Materialy>();

        public bool DodanieAsortymentu(int idMagazyn, IEnumerable<MagazynZawartosc> oczekujaceCollection)
        {
            var materialList = oczekujaceCollection.Where(x => x.TypAsortymentu == Enums.TypAsortymentu.Material).ToList();
            var productList = oczekujaceCollection.Where(x => x.TypAsortymentu == Enums.TypAsortymentu.Produkt).ToList();

            var materialCheck = MaterialCheck(idMagazyn, materialList);
            //var produktCheck = ProduktCheck(idMagazyn, productList);

            return materialCheck;
            //return materialCheck && produktCheck;
        }

        private bool MaterialCheck(int idMagazyn, IEnumerable<MagazynZawartosc> materials)
        {
            if (!materials.Any()) return true;

            var reached = false;
            foreach (var materialDGV in materials)
            {
                var material = _materialRepository
                    .GetById(materialDGV.IdAsortyment);

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
                        materialsRemainingCount = 0;
                        reached = true;
                        break;
                    }

                    if (result > 0)
                    {
                        materialsRemainingCount -= result;
                    }
                }

                if (reached)
                {
                    materialsRemainingCount = materialDGV.Ilosc;

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
                            materialsRemainingCount = 0;
                            reached = true;
                            break;
                        }

                        if (result > 0)
                        {
                            _materialRozlozenieRepository.Add(new RozlozeniePolki_Materialy
                            {
                                ID_Material = material.ID_Material,
                                DataOd = DateTime.Now,
                                ID_Polka = polka.ID_Polka,
                                ID_Pracownik = 1,
                                Ilosc = result,
                            });
                            materialsRemainingCount -= result;
                        }
                    }

                    DeleteRozlozenieMaterial(materialDGV);
                }

                if (materialsRemainingCount < 0) throw new InvalidOperationException("Wartość nie może być ujemna");
            }

            return reached;
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

            var asdads = _materialRozlozenieRepository
                .Get()
                .Where(x => x.ID_Polka == polka.ID_Polka)
                .ToArray();

            var rozlozenie = _materialRozlozenieRepository
                .Get()
                .Where(x => x.ID_Polka == polka.ID_Polka)
                .Select(x => x.Ilosc * x.Material.Masa)
                .Sum() ?? 0;

            var avaliableUdzwig = polka.Udzwig - rozlozenie;

            var quantityOfItemsToAddMasa = avaliableUdzwig > 0 ? (int)Math.Floor((double)(avaliableUdzwig / material.Masa)) : 0;

            // Powierzchnia

            var reservedPowierzchnia = _materialRozlozenieRepository
                .Get()
                .Where(x => x.ID_Polka == polka.ID_Polka)
                .Select(x => x.Ilosc * x.Material.Glebokosc * x.Material.Szerokosc)
                .Sum() ?? 0;

            var avaliablePowierzchia = (polka.DlugoscPietra * polka.SzerokoscPietra * polka.LiczbaPieter) - reservedPowierzchnia;

            var quantityOfItemsToAddPowierzchnia = avaliablePowierzchia > 0 ? (int)Math.Floor((double)(avaliablePowierzchia / (material.Szerokosc * material.Glebokosc))) : 0;

            return quantityOfItemsToAddMasa >= quantityOfItemsToAddPowierzchnia ? quantityOfItemsToAddPowierzchnia : quantityOfItemsToAddMasa;
        }

        private void DeleteRozlozenieMaterial(MagazynZawartosc material)
        {
            var rozlozenie = _materialRozlozenieRepository
                .GetById(material.IdRozlozenie);

            rozlozenie.DataDo = DateTime.Now;
            var updatedIlosc = rozlozenie.Ilosc - material.Ilosc;

            if (updatedIlosc < 0)
            {
                _materialRozlozenieRepository
                    .Add(new RozlozeniePolki_Materialy
                    {
                        DataOd = DateTime.Now,
                        ID_Material = rozlozenie.ID_Material,
                        ID_Polka = rozlozenie.ID_Polka,
                        ID_Pracownik = rozlozenie.ID_Pracownik,
                        Ilosc = updatedIlosc,
                    });
            }
        }
    }
}
