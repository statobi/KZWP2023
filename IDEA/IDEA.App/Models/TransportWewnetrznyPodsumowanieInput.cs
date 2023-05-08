using IDEA.Logistyka.Models;
using System.Collections.Generic;

namespace IDEA.App.Models
{
    internal class TransportWewnetrznyPodsumowanieInput
    {
        public int IdPracownik { get; set; }
        public int IdMagazynPoczatkowy { get; set; }
        public int IdMagazynKoncowy { get; set; }
        public int IdPojazd { get; set; }

        public string Kierowca { get; set; }
        public string MagazynPoczatkowy { get; set; }
        public string MagazynKoncowy { get; set; }
        public string Pojazd { get; set; }
        public IEnumerable<MagazynZawartosc> Zawartosc { get; set; }
    }
}
