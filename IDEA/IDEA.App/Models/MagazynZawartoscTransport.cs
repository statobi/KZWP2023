using IDEA.Logistyka.Models;
using System.Collections.Generic;

namespace IDEA.App.Models
{
    internal class MagazynZawartoscTransport
    {
        public int IdTransport { get; set; }
        public List<MagazynZawartosc> Zawartosc { get; set; }
    }
}
