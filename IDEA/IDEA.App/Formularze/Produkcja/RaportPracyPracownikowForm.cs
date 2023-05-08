using IDEA.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace IDEA.App.Formularze.Produkcja
{
    public partial class RaportPracyPracownikowForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        public RaportPracyPracownikowForm()
        {
            InitializeComponent();
            GenerujWykresKolowy();
            
        }

        private void RaportPracyPracownikowForm_Load(object sender, EventArgs e)
        {

        }
        private void GenerujWykresKolowy()
        {

            var query = from r in db.Raport_z_pracy_Operatorow
                        select new { r.Imie, r.Nazwisko, r.Czas_pracy__h_ };

            chart.Series.Clear();
            chart.Legends.Clear();

            Series series = new Series
            {
                Name = "Czas pracy",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Pie
            };

            foreach (var item in query)
            {
                series.Points.AddXY(item.Imie + " " + item.Nazwisko, item.Czas_pracy__h_);
            }

            chart.Series.Add(series);

            Legend legend = new Legend
            {
                Name = "Legend",
                Docking = Docking.Bottom,
                Alignment = StringAlignment.Center
            };

            chart.Legends.Add(legend);
        }

        private void iBtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
