using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEA.App.Models
{
    internal class WlasciwosciMaterialu
    {
        public int ID_Material { get; set; }

        public string Nazwa_Materialu { get; set; }
        public string Nazwa_Wlasciwosci { get; set; }

        public double Wartosc { get; set; }



        public string Jednostka { get; set; }
    }
}
