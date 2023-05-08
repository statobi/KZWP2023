using IDEA.App.Enums;
using IDEA.Logistyka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEA.App.Models
{
    internal class DodajIloscSkladZleceniaInput
    {
        public MagazynZawartosc Zawartosc { get; set; }
        public int RowIndex { get; set; }
        public StagedStatus StagedStatus { get; set; }
    }
}
