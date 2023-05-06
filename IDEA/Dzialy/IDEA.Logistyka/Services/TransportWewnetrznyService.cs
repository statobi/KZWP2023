using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Enums;
using IDEA.Logistyka.Models;
using System.Collections.Generic;
using System.Linq;

namespace IDEA.Logistyka.Services
{
    public class TransportWewnetrznyService
    {
        private readonly Repository<Sklad_Zlecenie_Magazynowe> _zlecenieMaterialRepository = new Repository<Sklad_Zlecenie_Magazynowe>();
        private readonly Repository<Sklad_Zlecenie_Produkt> _zlecenieProduktRepository = new Repository<Sklad_Zlecenie_Produkt>();
        private readonly Repository<Zlecenie_Magazynowe> _zlecenieMagazynoweRepository = new Repository<Zlecenie_Magazynowe>();

        public IEnumerable<ZlecenieMagazynoweDGV> GetZleceniaMagazynowe()
            => _zlecenieMagazynoweRepository
                .Get()
                .AsEnumerable()
                .Select(x => new ZlecenieMagazynoweDGV
                {
                    Id = x.ID_Zlecenie_Magazynowe,
                    DataZlecenia = x.Data,
                    Magazyn = x.Magazyn.Nazwa,
                    IdMagazyn = x.ID_Magazyn,
                    Uwagi = x.Uwagi
                });

        public IEnumerable<SkladZlecenieMagazynoweDGV> GetSkladTransportWewnetrzny(int idZamowienieMagazynowe)
            => GetMaterialZlecenieSklad(idZamowienieMagazynowe).Concat(GetProduktZlecenieSklad(idZamowienieMagazynowe));

        private IEnumerable<SkladZlecenieMagazynoweDGV> GetMaterialZlecenieSklad(int idZamowienieMagazynowe)
            => _zlecenieMaterialRepository
                .Get()
                .Where(x => x.ID_Zlecenie_Magazynowe == idZamowienieMagazynowe)
                .AsEnumerable()
                .GroupBy(x => x.ID_Material)
                .Select(x => new SkladZlecenieMagazynoweDGV
                {
                    IdZlecenieMagazynowe = idZamowienieMagazynowe,
                    IdAsortyment = x.Key,
                    UfId = $"M{x.Key}",
                    Nazwa = x.FirstOrDefault().Material.Nazwa,
                    Ilosc = x.Sum(s => s.IloscMaterialow),
                    TypAsortymentu = TypAsortymentu.Material,
                });

        private IEnumerable<SkladZlecenieMagazynoweDGV> GetProduktZlecenieSklad(int idZamowienieMagazynowe)
            => _zlecenieProduktRepository
                .Get()
                .Where(x => x.ID_Zlecenie_Magazynowe == idZamowienieMagazynowe)
                .AsEnumerable()
                .GroupBy(x => x.ID_Produkt)
                .Select(x => new SkladZlecenieMagazynoweDGV
                {
                    IdZlecenieMagazynowe = idZamowienieMagazynowe,
                    IdAsortyment = x.Key,
                    UfId = $"P{x.Key}",
                    Nazwa = x.FirstOrDefault().Produkt.Nazwa,
                    Ilosc = x.Sum(s => s.IloscProduktow),
                    TypAsortymentu = TypAsortymentu.Produkt,
                });
    }
}
