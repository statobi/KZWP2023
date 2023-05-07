using System;

namespace IDEA.Logistyka.Models
{
    public class ZlecenieMagazynoweDGV
    {
        public int Id { get; set; }
        public int IdMagazyn { get; set; }
        public string Magazyn { get; set; }
        public DateTime DataZlecenia { get; set; }
        public string Uwagi { get; set; }
    }
}
