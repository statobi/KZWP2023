using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEA.App.Modells
{
    internal class ModifySekcja
    {
        public int Id { get; set; }
        public double PowierzchniaRoboczaMagazynu { get; set; }
        public double PowierzchniaRoboczaSekcji { get; set; }
        public string Numer { get; set; }
        public double Wysokosc { get; set; }
        public string TypZasobu { get; set; }
        public int MagazynId { get; set; }
    }
}
