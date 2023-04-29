using IDEA.App.MessageBoxes;
using IDEA.Logistyka.Magazyny.Walidatory;
using IDEA.Logistyka.Models;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Services;
using IDEA.Logistyka.Validators;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    public partial class DodajSekcjeForm : Form, IRequestSubscriber
    {
        private TypZasobuService _typZasobuService = new TypZasobuService();
        private SekcjaService _sekcjaService = new SekcjaService();
        private CommonPublisher _commonPublisher = CommonPublisher.GetInstance();

        private double _avaliablePowierzchniaRobocza;

        private MagazynDGV _magazynObj = null;
        public DodajSekcjeForm()
        {
            InitializeComponent();
            InitCmbTypZasobu();
            _commonPublisher.Subscribe(this);
        }
        public void GetData<TMessage>(TMessage message)
        {
            _magazynObj = message as MagazynDGV;

            UpdateTotalReservedPowierzchniaRobocza();
        }

        private void InitCmbTypZasobu()
        {
            var typyZasobow = _typZasobuService.ViewData()
                .ToArray();
            CmbTypZasobu.DataSource = typyZasobow;
            CmbTypZasobu.DisplayMember = "Name";
            CmbTypZasobu.ValueMember = "Id";
        }


        private void UpdateTotalReservedPowierzchniaRobocza()
        {
            _avaliablePowierzchniaRobocza = _sekcjaService.AvaliblePowierzchniaRobocza(_magazynObj.Id);
            LblAvaliablePowierzchniaRobocza.Text = $"{_avaliablePowierzchniaRobocza}m²";
        }

        private void BtnAddTypZasobu_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var walidacja = SekcjaValidator.NewSekcjaValidator(TxbPowierzchniaRobocza.Text, _avaliablePowierzchniaRobocza);

            if (!string.IsNullOrEmpty(walidacja))
            {
                CustomMessageBox.ValidateMessageBox(walidacja);
                return;
            }

            _sekcjaService.AddSekcja(new SekcjaAdd
            {
                IdMagazyn = _magazynObj.Id,
                IdTypZasobu = ((TypZasobuCmb)CmbTypZasobu.SelectedItem).Id,
                Numer = TxbNumer.Text,
                AvaliableMagazynPowierzchniaRobocza = _avaliablePowierzchniaRobocza,
                InsertedPowierzchniaRobocza = double.Parse(TxbPowierzchniaRobocza.Text),
                Wysokosc = double.Parse(TxbWysokosc.Text)
            });

            _commonPublisher.Notify<MagazynForm>();
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
