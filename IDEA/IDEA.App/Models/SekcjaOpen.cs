namespace IDEA.App.Models
{
    internal class SekcjaOpen
    {
        public int Id { get; set; }
        public string MagazynName { get; set; }
        public string SekcjaName { get; set; }

        public int MagazynDGVRowIndex { get; set; }
        public int SekcjaDGVRowIndex { get; set; }
    }
}
