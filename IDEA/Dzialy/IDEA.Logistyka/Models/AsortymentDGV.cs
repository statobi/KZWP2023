using IDEA.Logistyka.Enums;

namespace IDEA.Logistyka.Models
{
    public class AsortymentDGV
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public TypAsortymentu TypAsortymentu { get; set; }
        public string EmailPracownika { get; set; }
        public int Ilosc { get; set; }

        public int IdPracownik { get; set; }
        public int IdPolka { get; set; }
    }
}
