﻿using IDEA.App.Modells;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Services;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    public partial class EdytujSekcjeForm : Form, IRequestSubscriber
    {
        private TypMaterialuChartService _typZasobuService = new TypMaterialuChartService();
        private SekcjaService _sekcjaService = new SekcjaService();
        private CommonPublisher _commonPublisher = CommonPublisher.GetInstance();

        private ModifySekcja _receivedObj = null;

        public EdytujSekcjeForm()
        {
            InitializeComponent();
            InitCmbTypZasobu();
            _commonPublisher.Subscribe(this);
        }

        public void GetData(object message)
        {
            _receivedObj = message as ModifySekcja;

            UpdateView();
        }

        private void InitCmbTypZasobu()
        {
            var typyZasobow = _typZasobuService
            .ViewData()
            .Select(x => x.Name)
            .ToArray();
            CmbTypZasobu.DataSource = typyZasobow;
        }

        private void UpdateView()
        {
            TxbNumer.Text = _receivedObj.Numer;
            TxbPowierzchniaRobocza.Text = _receivedObj.PowierzchniaRoboczaSekcji.ToString();
            TxbWysokosc.Text = _receivedObj.Wysokosc.ToString();
            var comboboxIndex = CmbTypZasobu.FindString(_receivedObj.TypZasobu);
            CmbTypZasobu.SelectedIndex = comboboxIndex;

            UpdateTotalReservedPowierzchniaRobocza();
        }

        private void UpdateTotalReservedPowierzchniaRobocza()
        {
            LblPowierzchniaRobocza.Text = $"{_sekcjaService.AvaliblePowierzchniaRobocza(_receivedObj.MagazynId)}m²";
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
