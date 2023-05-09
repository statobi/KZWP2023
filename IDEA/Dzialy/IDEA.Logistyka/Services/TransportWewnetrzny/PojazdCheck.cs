using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Models;
using System.Collections.Generic;
using System.Linq;

namespace IDEA.Logistyka.Services.TransportWewnetrzny
{
    internal class PojazdCheck
    {
        private readonly Repository<Material> _materialRepository = new Repository<Material>();
        private readonly Repository<Produkt> _productRepository = new Repository<Produkt>();
        private readonly Repository<Pojazd> _pojazdRepository = new Repository<Pojazd>();

        public bool WeightCheck(int idPojazd, IEnumerable<MagazynZawartosc> oczekujaceCollection)
        {
            var materialList = oczekujaceCollection.Where(x => x.TypAsortymentu == Enums.TypAsortymentu.Material).ToList();
            var productList = oczekujaceCollection.Where(x => x.TypAsortymentu == Enums.TypAsortymentu.Produkt).ToList();

            return MaterialWagaCheck(idPojazd, materialList) && ProduktWagaCheck(idPojazd, productList);
        }

        public bool GabarytCheck(int idPojazd, IEnumerable<MagazynZawartosc> oczekujaceCollection)
        {
            var materialList = oczekujaceCollection.Where(x => x.TypAsortymentu == Enums.TypAsortymentu.Material).ToList();
            var productList = oczekujaceCollection.Where(x => x.TypAsortymentu == Enums.TypAsortymentu.Produkt).ToList();

            return MaterialGabarytCheck(idPojazd, materialList) && ProduktGabarytCheck(idPojazd, productList);
        }

        private bool MaterialWagaCheck(int idPojazd, IEnumerable<MagazynZawartosc> materials)
        {
            if (!materials.Any()) return true;

            var pojazd = _pojazdRepository
                .GetById(idPojazd);

            var materialy = _materialRepository
                .Get()
                .AsEnumerable()
                .Where(x => materials.Any(s => s.IdAsortyment == x.ID_Material))
                .ToArray();

            var wagaMaterialow = materialy
                .Sum(x => x.Masa);

            return pojazd.ModelePojazdu.Nosnosc > wagaMaterialow;
        }

        private bool ProduktWagaCheck(int idPojazd, IEnumerable<MagazynZawartosc> products)
        {
            if (!products.Any()) return true;

            var pojazd = _pojazdRepository
                .GetById(idPojazd);

            var produkty = _productRepository
                .Get()
                .AsEnumerable()
                .Where(x => products.Any(s => s.IdAsortyment == x.ID_Produkt))
                .ToArray();

            var wagaProduktow = produkty
                .Sum(x => x.Masa);

            return pojazd.ModelePojazdu.Nosnosc > wagaProduktow;
        }

        private bool MaterialGabarytCheck(int idPojazd, IEnumerable<MagazynZawartosc> materials)
        {
            if (!materials.Any()) return true;

            var pojazd = _pojazdRepository
                .GetById(idPojazd);

            var materialy = _materialRepository
                .Get()
                .AsEnumerable()
                .Where(x => materials.Any(s => s.IdAsortyment == x.ID_Material))
                .ToArray();

            if (materialy.Any(x => x.Szerokosc > pojazd.ModelePojazdu.Szerokosc))
                return false;

            if (materialy.Any(x => x.Glebokosc > pojazd.ModelePojazdu.Glebokosc))
                return false;

            if (materialy.Any(x => x.Wysokosc > pojazd.ModelePojazdu.Wysokosc))
                return false;

            var gabarytPojazdu = pojazd.ModelePojazdu.Szerokosc * pojazd.ModelePojazdu.Glebokosc * pojazd.ModelePojazdu.Wysokosc;

            var gabarytMaterialow = materialy
                .Sum(x => x.Szerokosc * x.Wysokosc * x.Glebokosc);

            return gabarytPojazdu > gabarytMaterialow;
        }

        private bool ProduktGabarytCheck(int idPojazd, IEnumerable<MagazynZawartosc> products)
        {
            if (!products.Any()) return true;

            var pojazd = _pojazdRepository
                .GetById(idPojazd);

            var produkty = _productRepository
                .Get()
                .AsEnumerable()
                .Where(x => products.Any(s => s.IdAsortyment == x.ID_Produkt))
                .ToArray();

            if (produkty.Any(x => x.Szerokosc > pojazd.ModelePojazdu.Szerokosc))
                    return false;

            if (produkty.Any(x => x.Glebokosc > pojazd.ModelePojazdu.Glebokosc))
                return false;

            if (produkty.Any(x => x.Wysokosc > pojazd.ModelePojazdu.Wysokosc))
                return false;

            var gabarytPojazdu = pojazd.ModelePojazdu.Szerokosc * pojazd.ModelePojazdu.Glebokosc * pojazd.ModelePojazdu.Wysokosc;

            var gabarytProduktow = produkty
                .Sum(x => x.Szerokosc * x.Wysokosc * x.Glebokosc);

            return gabarytPojazdu > gabarytProduktow;
        }
    }
}
