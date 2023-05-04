namespace IDEA.Logistyka.Models
{
    public class PolkaDGV
    {
        public int Id { get; set; }
        public string Numer { get; set; }
        public double Szerokosc { get; set; }
        public double Wysokosc { get; set; }
        public double Glebokosc { get; set; }
        public double Udzwig { get; set; }
        public double Zajetosc { get; set; }
        public double Obciazenie { get; set; }
        public int IdSekcja { get; set; }
    }
}
