using IDEA.Logistyka.Enums;

namespace IDEA.Logistyka.Models
{
    public class MagazynZawartosc
    {
        public int IdRozlozenie { get; set; }
        public int IdAsortyment { get; set; }
        public string UfId { get; set; }
        public string Nazwa { get; set; }
        public int Ilosc { get; set; }
        public TypAsortymentu TypAsortymentu { get; set; }
    }
}
