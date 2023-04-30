using IDEA.App.Modells;
using IDEA.App.Models;
using IDEA.App.Observer;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IDEA.App.Formularze.Logistyka.Magazyn
{
    public partial class TypMaterialuChartForm : Form, IRequestSubscriber
    {
        private readonly CommonPublisher _publisher = CommonPublisher.GetInstance();
        private readonly OpenNewPanelPublisher _openNewPanelPublisher = OpenNewPanelPublisher.GetInstance();
        private readonly TypZasobuService _typZasobuService = new TypZasobuService();
        private TypMaterialuChartOpen _messageObj;

        public TypMaterialuChartForm()
        {
            InitializeComponent();
            _publisher.Subscribe(this);

            var chartTypes = new List<string>
            {
                "Kolumnowy",
                "Kołowy",
                "Pierścieniowy"
            };

            CmbChartType.DataSource = chartTypes;

            var chartData = _typZasobuService.ChartData().ToList();

            ChartTypMaterialu.Series.Clear();
            ChartTypMaterialu.Titles.Clear();
            ChartTypMaterialu.Titles.Add("Zestawienie typów zasobów w magazynach");

            ChartTypMaterialu.Series.Add("TypyZasobow");
            ChartTypMaterialu.Series["TypyZasobow"].ChartType = SeriesChartType.Doughnut;
            ChartTypMaterialu.Series["TypyZasobow"].IsValueShownAsLabel = true;
            ChartTypMaterialu.Series["TypyZasobow"].XValueMember = "Nazwa";
            ChartTypMaterialu.Series["TypyZasobow"].YValueMembers = "PowierzchniaRobocza";

            ChartTypMaterialu.DataSource = chartData;
        }

        public void GetData<TMessage>(TMessage message)
        {
            _messageObj = message as TypMaterialuChartOpen;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _openNewPanelPublisher.Open<MagazynForm, MagazynOpen>(new MagazynOpen
            {
                MagazynDGVRowIndex = _messageObj.MagazynDGVRowIndex,
                SekcjaDGVRowIndex = _messageObj.SekcjaDGVRowIndex
            }, "Magazyny");
            Close();
        }

        private void TypMaterialuChartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _publisher.Unsubscribe(this);
        }
    }
}
