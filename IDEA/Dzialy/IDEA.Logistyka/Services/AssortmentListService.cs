using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Models;
using System.Collections.Generic;
using System.Linq;

namespace IDEA.Logistyka.Services
{
    public class AssortmentListService
    {
        private readonly Repository<RozlozeniePolki_Materialy> _rozlozenieMaterialyRepository = new Repository<RozlozeniePolki_Materialy>();
        private readonly Repository<RozlozeniePolki_Produkty> _rozlozenieProduktyRepository = new Repository<RozlozeniePolki_Produkty>();
        private readonly Repository<Polka> _polkaRepository = new Repository<Polka>();
        private readonly Repository<Material> _materialRepository = new Repository<Material>();
        private readonly Repository<Produkt> _produktRepository = new Repository<Produkt>();
        private readonly Repository<Pracownicy> _pracownicyRepository = new Repository<Pracownicy>();

        public IEnumerable<MaterialyList> GetMaterialy(int idSekcja)
        {
            var polkaIds = GetPolkaIds(idSekcja);

            return _rozlozenieMaterialyRepository
                .Get()
                .Where(x => polkaIds.Contains(x.ID_Polka))
                .AsEnumerable()
                .Select(x => new MaterialyList
                {
                    Nazwa = GetMaterialName(x.ID_Material),
                    Polka = GetPolkaNumber(x.ID_Polka),
                    Pracownik = GetPracownikEmail(x.ID_Pracownik),
                    Ilosc = x.Ilosc,
                    DataOd = x.DataOd
                });
        }
        
        public IEnumerable<ProduktList> GetProdukty(int idSekcja)
        {
            var polkaIds = GetPolkaIds(idSekcja);

            return _rozlozenieProduktyRepository
                .Get()
                .Where(x => polkaIds.Contains(x.ID_Polka))
                .AsEnumerable()
                .Select(x => new ProduktList
                {
                    Nazwa = GetProduktName(x.ID_Produkt),
                    Polka = GetPolkaNumber(x.ID_Polka),
                    Pracownik = GetPracownikEmail(x.ID_Pracownik),
                    Ilosc = x.Ilosc,
                    DataOd = x.DataOd
                });
        }

        private int[] GetPolkaIds(int idSekcja)
            => _polkaRepository
            .Get()
            .Where(x => x.ID_Sekcja == idSekcja)
            .Select(x => x.ID_Polka)
            .ToArray();
        private string GetPolkaNumber(int id)
            => _polkaRepository.GetById(id).Numer;
        private string GetPracownikEmail(int id)
            => _pracownicyRepository.GetById(id).E_mail;
        private string GetMaterialName(int id)
            => _materialRepository.GetById(id).Nazwa;
        private string GetProduktName(int id)
            => _produktRepository.GetById(id).Nazwa;
    }
}
