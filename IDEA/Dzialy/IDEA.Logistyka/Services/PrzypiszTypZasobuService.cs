using IDEA.Database;
using IDEA.Database.Repozytoria;

namespace IDEA.Logistyka.Services
{
    public class PrzypiszTypZasobuService
    {
        private readonly Repository<TypZasobu> _typZasobuRepository = new Repository<TypZasobu>();
        private readonly Repository<Rodzaj_Materialu> _rodzaj_MaterialuRepository = new Repository<Rodzaj_Materialu>();

        public void AddTypZasobuToRodzajMaterialu(int idTypZasobu, int idRodzajMaterialu)
        {
            var typZasobu = _typZasobuRepository.GetById(idTypZasobu);
            var rodzajMaterialu = _rodzaj_MaterialuRepository.GetById(idRodzajMaterialu);

            typZasobu.Rodzaj_Materialu.Add(rodzajMaterialu);

            _typZasobuRepository.SaveChanges();
        }
    }
}
