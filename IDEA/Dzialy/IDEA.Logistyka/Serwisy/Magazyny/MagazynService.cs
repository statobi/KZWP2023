using IDEA.Database;
using IDEA.Database.Repozytoria;
using IDEA.Logistyka.Modele;
using System.Collections.Generic;
using System.Linq;

namespace IDEA.Logistyka.Magazyny
{
    public class MagazynService
    {
        private readonly Repozytorium<Magazyn> _magazynRepo = new Repozytorium<Magazyn>();

        public IEnumerable<MagazynDGV> DataGridData()
        {
            var magazyny = _magazynRepo
                .PobierzWszystko()
                .AsEnumerable()
                .Select(x => new MagazynDGV
                {
                    ID = x.ID_Magazyn,
                    Nazwa= x.Nazwa,
                    NrTelefonu = FormatNrTelefonu(x.Telefon),
                    PowierzchniaRobocza = x.PowierzchniaRobocza,
                    CalkowitaZajetoscPowierzchni = x.Sekcjas
                        .Where(s => s.ID_Magazyn == x.ID_Magazyn)
                        .Sum(s => s.PowierzchniaRobocza)
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

            _magazynRepo.Dodaj(mappedMagazyn);
            _magazynRepo.SaveChanges();
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
