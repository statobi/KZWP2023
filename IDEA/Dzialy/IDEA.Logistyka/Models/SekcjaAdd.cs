namespace IDEA.Logistyka.Models
{
    public class SekcjaAdd
    {
        public string Numer { get; set; }
        public double InsertedPowierzchniaRobocza { get; set; }
        public double AvaliableMagazynPowierzchniaRobocza { get; set; }
        public double Wysokosc { get; set; }

        public int IdMagazyn { get; set; }
        public int IdTypZasobu { get; set; }
    }
}
