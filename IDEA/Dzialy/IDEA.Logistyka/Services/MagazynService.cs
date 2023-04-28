using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Models;
using System.Collections.Generic;
using System.Linq;

namespace IDEA.Logistyka.Services
{
    public class MagazynService
    {
        private readonly Repository<Magazyn> _magazynRepository = new Repository<Magazyn>();

        public IEnumerable<MagazynDGV> DataGridData()
        {
            var magazyny = _magazynRepository
                .Get()
                .AsEnumerable()
                .Select(x => new MagazynDGV
                {
                    Id = x.ID_Magazyn,
                    Nazwa= x.Nazwa,
                    NrTelefonu = FormatNrTelefonu(x.Telefon),
                    PowierzchniaRobocza = x.PowierzchniaRobocza,
                    CalkowitaZajetoscPowierzchni = ObliczCalkowitaPowierzchnieRobocza(x, x.Sekcjas)
                }).ToList();

            return magazyny;
        }

        public void DodajMagazyn(NowyMagazyn magazyn)
        {
            var mappedMagazyn = new Magazyn
            {
                Nazwa = magazyn.Nazwa,
                Telefon = magazyn.NrTelefonu,
                PowierzchniaRobocza = magazyn.PowierzchniaRobocza
            };

            _magazynRepository.Add(mappedMagazyn);
        }

        private string ObliczCalkowitaPowierzchnieRobocza(Magazyn magazyn, ICollection<Sekcja> sekcje)
        {
            var wynik = sekcje
                .Where(x => x.ID_Magazyn == magazyn.ID_Magazyn)
                .Sum(x => x.PowierzchniaRobocza) / magazyn.PowierzchniaRobocza;

            return wynik.ToString("P");
        }

        private string FormatNrTelefonu(int nrTelefonu)
        {
            var result = "+48 ";
            var nrTelefonuLength = nrTelefonu.ToString().Length;
            for (int i = 0; i < nrTelefonuLength; i += 3)
            {
                if (i + 3 <= nrTelefonuLength)
                {
                    result += nrTelefonu.ToString().Substring(i, 3) + '-';
                }
            }

            result = result.Remove(result.Length - 1);

            return result;
        }
    }
}
