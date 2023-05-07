using IDEA.Logistyka.Models;
using System.Collections.Generic;

namespace IDEA.App.Models
{
    internal class TransportWewnetrznyPodsumowanieInput
    {
        public IEnumerable<MagazynZawartosc> Zawartosc { get; set; }
    }
}
