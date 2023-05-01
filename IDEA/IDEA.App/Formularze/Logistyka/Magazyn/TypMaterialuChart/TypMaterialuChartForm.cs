using IDEA.App.Formularze.Logistyka.Magazyn.TypMaterialuChart;
using IDEA.App.Modells;
using IDEA.App.Models;
using IDEA.App.Observer;
using IDEA.Logistyka.Models;
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
        private readonly OpenPanelPublisher _openNewPanelPublisher = OpenPanelPublisher.GetInstance();
        private readonly TypMaterialuChartService _typZasobuService = new TypMaterialuChartService();
        private TypMaterialuChartOpen _messageObj;
        private TypMaterialuOpcjeChartOutput _optionsOutput;
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
            InitCharts(_typZasobuService.ChartData());
        }

        public void GetData(object message)
        {
            if (message is TypMaterialuChartOpen)
            {
                _messageObj = message as TypMaterialuChartOpen;
            }

            if (message is TypMaterialuOpcjeChartOutput)
            {
                _optionsOutput = message as TypMaterialuOpcjeChartOutput;

                if (_optionsOutput.MagazynId == 0)
                    InitCharts(_typZasobuService.ChartData());
                else
                    InitCharts(_typZasobuService.ChartData(_optionsOutput.MagazynId));

                ChangeChartType(_optionsOutput.TypWykresuCmbIndex);
            }
        }

        private void InitCharts(IEnumerable<TypyZasobowChart> chartData)
        {
            _chartInput = chartData.Select(x => new TypMaterialuChartInput
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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _openNewPanelPublisher.Open<MagazynForm>(new MagazynOpen
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

        private void ChangeChartType(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                    ChartTypMaterialu.Series[0].ChartType = SeriesChartType.Column;
                    break;
                case 1:
                    ChartTypMaterialu.Series[0].ChartType = SeriesChartType.Pie;
                    break;
                case 2:
                    ChartTypMaterialu.Series[0].ChartType = SeriesChartType.Doughnut;
                    break;
                default: throw new NotImplementedException("Wartość z listy nie została zaimplementowana");
            }
        }

        private void ChartTypMaterialu_Customize(object sender, EventArgs e)
        {
            int index = 0;
            var chart = (Chart)sender;
            chart.ChartAreas[0].Area3DStyle.Rotation = 90;
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

        private void BtnOpcje_Click(object sender, EventArgs e)
        {
            var magazyny = _typZasobuService.GetMagazyny().ToList();
            magazyny.Add(new MagazynChart
            {
                Id = 0,
                Nazwa = "Wszystkie"
            });

            _optionsOutput = _optionsOutput ?? new TypMaterialuOpcjeChartOutput
            {
                MagazynId = 0,
                TypWykresuCmbIndex = 0
            };

            var form = new TypMaterialuOpcjeChartForm();
            _publisher.Send<TypMaterialuOpcjeChartForm>(new TypMaterialuOpcjeChartInput
            {
                Magazyny = magazyny.OrderBy(x => x.Id),
                TypyWykresow = _chartTypes,
                SelectedMagazynId = _optionsOutput.MagazynId,
                SelectedTypMagazynuCmbIndex = _optionsOutput.TypWykresuCmbIndex
            });
            form.ShowDialog();
        }
    }
}
