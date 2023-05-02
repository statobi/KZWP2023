using IDEA.Logistyka.Models;
using System.Collections.Generic;

namespace IDEA.App.Models
{
    internal class TypMaterialuOpcjeChartInput
    {
        public IEnumerable<MagazynChart> Magazyny { get; set; }
        public IEnumerable<string> TypyWykresow { get; set; }

        public int SelectedMagazynId { get; set; }
        public int SelectedTypMagazynuCmbIndex { get; set; }
    }
}
