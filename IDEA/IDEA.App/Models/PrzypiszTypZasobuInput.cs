using IDEA.Logistyka.Models;
using System.Collections.Generic;

namespace IDEA.App.Models
{
    internal class PrzypiszTypZasobuInput
    {
        public int MagazynDGVRowIndex { get; set; }
        public int SekcjaDGVRowIndex { get; set; }
        public IEnumerable<OczekujaceCheckResponse> CheckResult { get; set; }
    }
}
