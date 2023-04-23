using IDEA.Logistyka.Magazyny;
using IDEA.Logistyka.Modele;
using IDEA.Logistyka.Obserwator;
using System;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    public partial class DodajMagazynForm : Form
    {
        private readonly IPublisher _publisher = Publisher.GetInstance();
        private readonly MagazynService _magazynService = new MagazynService();
        public DodajMagazynForm()
        {
            InitializeComponent();
        }

        private void BtnDodajMagazyn_Click(object sender, EventArgs e)
        {
            var nowyMagazym = new NowyMagazyn
            {
                Nazwa = TxbNazwa.Text,
                NrTelefonu = int.Parse(TxbTelefon.Text),
                PowierzchniaRobocza = int.Parse(TxbPowierzchniaRobocza.Text)
            };

            _magazynService.DodajMagazyn(nowyMagazym);

            _publisher.PowiadomOZamknieciuOkna();
            Close();
        }
    }
}
