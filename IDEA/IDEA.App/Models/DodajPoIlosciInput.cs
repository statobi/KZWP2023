using IDEA.App.Enums;
using IDEA.Logistyka.Models;

namespace IDEA.App.Models
{
    internal class DodajPoIlosciInput
    {
        public OczekujaceDGV Oczekujace { get; set; }
        public int RowIndex { get; set; }
        public StagedStatus StagedStatus { get; set; }
    }
}
