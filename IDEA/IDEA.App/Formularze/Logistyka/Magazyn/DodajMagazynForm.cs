using IDEA.App.MessageBoxes;
using IDEA.Logistyka.Magazyny.Walidatory;
using IDEA.Logistyka.Models;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Services;
using System;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    public partial class DodajMagazynForm : Form
    {
        private readonly CommonPublisher _publisher = CommonPublisher.GetInstance();
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
                CustomMessageBox.ValidateMessageBox(walidacja);
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
