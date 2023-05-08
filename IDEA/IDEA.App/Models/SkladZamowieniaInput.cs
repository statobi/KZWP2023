using IDEA.Logistyka.Models;
using System.Collections.Generic;

namespace IDEA.App.Models
{
    internal class SkladZamowieniaInput
    {
        public IEnumerable<SkladZlecenieMagazynoweDGV> SkladZlecenieMagazynowe { get; set; }
    }
}
