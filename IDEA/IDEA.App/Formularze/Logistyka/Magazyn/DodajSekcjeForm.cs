using IDEA.Logistyka.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    public partial class DodajSekcjeForm : Form
    {
        private TypZasobuService _typZasobuService = new TypZasobuService();
        public DodajSekcjeForm()
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

        private void BtnAddTypZasobu_Click(object sender, EventArgs e)
        {

        }
    }
}
