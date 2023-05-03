using IDEA.Logistyka.Enums;
using System;

namespace IDEA.Logistyka.Models
{
    public class OczekujaceDGV
    {
        public int Id { get; set; }
        public string UfId { get; set; }
        public int IdAsortyment { get; set; }
        public string Nazwa { get; set; }
        public int Ilosc { get; set; }
        public TypAsortymentu TypAsortymentu { get; set; }
        public DateTime DataOd { get; set; }
    }
}
