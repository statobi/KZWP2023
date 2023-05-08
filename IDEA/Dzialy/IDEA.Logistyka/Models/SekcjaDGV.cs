namespace IDEA.Logistyka.Models
{
    public class SekcjaDGV
    {
        public int Id { get; set; }
        public string Numer { get; set; }
        public double PowierzchniaRobocza { get; set; }
        public string TypZasobu { get; set; }
        public double Zapelnienie { get; set; }
        public double ZajetaPrzestrzenRobocza { get; set; }
        public int IdMagazyn { get; set; }
    }
}
