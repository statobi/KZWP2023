using IDEA.Logistyka.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEA.Logistyka.Models
{
    public class OczekujaceDGV
    {
        public string Nazwa { get; set; }
        public int Ilosc { get; set; }
        public TypAsortymentu TypAsortymentu { get; set; }
        public DateTime DataOd { get; set; }
    }
}
