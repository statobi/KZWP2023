using IDEA.Logistyka.Services;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    public partial class EdytujSekcjeForm : Form
    {
        private TypZasobuService _typZasobuService = new TypZasobuService();

        public EdytujSekcjeForm()
        {
            InitializeComponent();
            InitCmbTypZasobu();
        }

        private void InitCmbTypZasobu()
        {
            var typyZasobow = _typZasobuService
            .ViewData()
            .Select(x => x.Nazwa)
            .ToArray();
            CmbTypZasobu.DataSource = typyZasobow;
        }
    }
}
