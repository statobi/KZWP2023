using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Models;
using System.Linq;

namespace IDEA.Logistyka.Serwisy.Sekcje
{
    public class SekcjaService
    {
        private readonly Repozytorium<Sekcja> _sekcjaRepo = new Repozytorium<Sekcja>();
        private readonly Repozytorium<TypZasobu> _typZasobuRepo = new Repozytorium<TypZasobu>();

        public SekcjaDGV DataGridData(int magazynId)
        {
            var sekcja = _sekcjaRepo
                .Pobierz()
                .Where(x => x.ID_Magazyn == magazynId)
                .AsEnumerable()
                .Select(x => new SekcjaDGV
                {
                    Id = x.ID_Sekcja,
                    IdMagazyn= x.ID_Magazyn,
                    TypZasobu = GetTypZasobu(x.ID_TypZasobu),
                    Numer = x.Numer,
                    
                }).FirstOrDefault();

            return sekcja;
        }

        private string GetTypZasobu(int Id)
        {
            var typyZasobu = _typZasobuRepo
                .Pobierz()
                .Where(x => x.ID_TypZasobu == Id)
                .AsEnumerable()
                .Select(x => x.Nazwa)
                .ToList();

            return typyZasobu.Aggregate((prev, next) => $"{prev}, {next}");
        }
    }
}
