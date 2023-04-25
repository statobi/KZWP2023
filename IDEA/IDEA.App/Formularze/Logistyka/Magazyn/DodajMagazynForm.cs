using IDEA.App.MessageBoxes;
using IDEA.Logistyka.Magazyny;
using IDEA.Logistyka.Magazyny.Walidatory;
using IDEA.Logistyka.Modele;
using IDEA.Logistyka.Obserwator;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    public partial class DodajMagazynForm : Form
    {
        private readonly Publisher _publisher = Publisher.GetInstance();
        private readonly MagazynService _magazynService = new MagazynService();
        private readonly MagazynValidator _magazynWalidator = new MagazynValidator();
        public DodajMagazynForm()
        {
            InitializeComponent();
        }

        private void BtnDodajMagazyn_Click(object sender, EventArgs e)
        {
            var walidacja = _magazynWalidator.NowyMagazynWalidator(TxbTelefon.Text, TxbPowierzchniaRobocza.Text);

            if(!string.IsNullOrEmpty(walidacja))
            {
                CustomMessageBox.Waliduj(walidacja);
                return;
            }

            var nowyMagazyn = new NowyMagazyn
            {
                Nazwa = TxbNazwa.Text,
                NrTelefonu = int.Parse(TxbTelefon.Text),
                PowierzchniaRobocza = int.Parse(TxbPowierzchniaRobocza.Text)
            };


            _magazynService.DodajMagazyn(nowyMagazyn);

            _publisher.Notify<MagazynForm>();
            Close();
        }
    }
}
