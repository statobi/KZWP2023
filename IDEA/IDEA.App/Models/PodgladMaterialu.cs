using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEA.App.Models
{
    internal class PodgladMaterialu
    {
        public int ID_Material { get; set; }

        public int ID_Rodzaj_Materialu { get; set; }
        public string Nazwa_Materialu { get; set; }

        public string Jednostka { get; set; }

        public double Szerokosc { get; set; }
        public double Glebokosc { get; set; }
        public double Wysokosc { get; set; }

        public double Masa { get; set; }

        public string Opis { get; set; }



    }
}
