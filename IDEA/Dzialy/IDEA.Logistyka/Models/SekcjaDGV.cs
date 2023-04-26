namespace IDEA.Logistyka.Models
{
    public class SekcjaDGV
    {
        public int Id { get; set; }
        public string Numer { get; set; }
        public string PowierzchniaRobocza { get; set; }
        public string TypZasobu { get; set; }
        public double Wysokosc { get; set; }

        public int IdMagazyn { get; set; }
    }
}
