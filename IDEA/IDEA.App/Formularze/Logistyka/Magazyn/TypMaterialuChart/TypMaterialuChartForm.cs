using IDEA.App.Modells;
using IDEA.App.Models;
using IDEA.App.Observer;
using IDEA.Logistyka.Observer;
using IDEA.Logistyka.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        private readonly List<string> _chartTypes = new List<string>
        {
            "Kolumnowy",
            "Kołowy",
            "Pierścieniowy"
        };

        private TypMaterialuChartInput[] _chartInput;

        public TypMaterialuChartForm()
        {
            InitializeComponent();
            _publisher.Subscribe(this);
            InitComboBoxes();
            InitCharts();
        }

        private void InitComboBoxes()
        {
            CmbChartType.DataSource = _chartTypes;
        }

        private void InitCharts()
        {
            _chartInput = _typZasobuService.ChartData().Select(x => new TypMaterialuChartInput
            {
                XValueMember = x.Nazwa,
                YValueMember = x.PowierzchniaRobocza,
                Label = $"{x.PowierzchniaRobocza}m² [{x.Percentage}%]"
            }).ToArray();

            ChartTypMaterialu.Series.Clear();
            ChartTypMaterialu.Titles.Clear();

            ChartTypMaterialu.Series.Add("TypyZasobow");
            ChartTypMaterialu.Series[0].IsValueShownAsLabel = true;
            ChartTypMaterialu.Series[0].XValueMember = "XValueMember";
            ChartTypMaterialu.Series[0].YValueMembers = "YValueMember";

            ChartTypMaterialu.DataSource = _chartInput;
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

        private void CmbChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CmbChartType.SelectedIndex)
            {
                case 0:
                    ChartTypMaterialu.Series["TypyZasobow"].ChartType = SeriesChartType.Column;
                    break;
                case 1:
                    ChartTypMaterialu.Series["TypyZasobow"].ChartType = SeriesChartType.Pie;
                    break;
                case 2:
                    ChartTypMaterialu.Series["TypyZasobow"].ChartType = SeriesChartType.Doughnut;
                    break;
                default: throw new NotImplementedException("Wartość z listy nie została zaimplementowana");
            }
        }

        private void ChartTypMaterialu_Customize(object sender, EventArgs e)
        {
            int index = 0;
            var chart = (Chart)sender;
            chart.Series[0].ShadowColor = Color.FromArgb(230, 230, 230);
            chart.Series[0].ShadowOffset = 1;

            foreach (var point in chart.Series[0].Points)
            {
                point.Label = _chartInput[index].Label;
                point.LegendText = _chartInput[index].XValueMember;
                point.CustomProperties = "LabelsRadialLineSize=5, PieDrawingStyle=Concave, PointWidth=0.9";

                if (chart.Series[0].ChartType== SeriesChartType.Column)
                    point.BackGradientStyle = GradientStyle.DiagonalLeft;
                else
                    point.BackGradientStyle = GradientStyle.None;

                index++;
            }
        }
    }
}
