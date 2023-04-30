using IDEA.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IDEA.App
{
    public partial class AFBilansForm : Form
    {
        //----------------------------------------------------------------------------------------------------------------------Deklaracje
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelectedZamowienie = false;
        private bool flagSelectedSklad = false;
        Zamowienia_Klienci selectedZamowienie = new Zamowienia_Klienci();
        Sklad_Zamowienia selectedSklad = new Sklad_Zamowienia();
        //----------------------------------------------------------------------------------------------------------------------Konstruktor
        public AFBilansForm()
        {
            InitializeComponent();

            //Inicjowanie Ddw
            initDgwZamowienia();
            InitSkladZamowienia();
            initChart1();
            initChart2();
        }
        //----------------------------------------------------------------------------------------------------------------------initChart
        private void initChart1()
        {
            DateTime curentDate = DateTime.Now;
            DateTime startDate = new DateTime(curentDate.Year, /*curentDate.Month*/ 3, 1);
            DateTime endDate = new DateTime(curentDate.Year, 6, 1);

            var bilans = (from b in db.V_Bilans_Kwoty
                          where b.Data >= startDate && b.Data < endDate
                          group b by b.Data.Value.Month into g
                          select new { Month = g.Key, Sum = g.Sum(x => x.Suma) }).ToList();

            chart1.Series.Clear();
            chart1.Titles.Add("Bilans w poszczególnych miesiącach");
            var series = chart1.Series.Add("Bilans");
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.String;
            series.IsValueShownAsLabel = true;
            foreach (var item in bilans)
            {
                series.Points.AddXY(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(item.Month), item.Sum);
            }

            // wyświetl wykres
            //chart1.Dock = DockStyle.Fill;
        }
        private void initChart2()
        {
            DateTime curentDate = DateTime.Now;
            DateTime startDate = new DateTime(curentDate.Year, 3, 1);
            DateTime endDate = new DateTime(curentDate.Year, 6, 1);

            var KosztOplatyAdministracyjne
                = (from bilans in db.V_Bilans_Kwoty
                   where bilans.Rodzaj == "Suma" && bilans.Data >= startDate && bilans.Data < endDate
                   select bilans.Suma).Sum();
            var KosztDostawyMaterialu
                = (from bilans in db.V_Bilans_Kwoty
                   where bilans.Rodzaj == "Suma_AS" && bilans.Data >= startDate && bilans.Data < endDate
                   select bilans.Suma).Sum();
            var KosztEksploatacjaMaszyn
                = (from bilans in db.V_Bilans_Kwoty
                   where bilans.Rodzaj == "Suma_EM" && bilans.Data >= startDate && bilans.Data < endDate
                   select bilans.Suma).Sum();
            var KosztEksploatacjaPojazdow
                = (from bilans in db.V_Bilans_Kwoty
                   where (bilans.Rodzaj == "Suma_EP_T" || bilans.Rodzaj == "Suma_EP_P" || bilans.Rodzaj == "Suma_EP_U" || bilans.Rodzaj == "Suma_EP_OT")
                   && bilans.Data >= startDate && bilans.Data < endDate
                   select bilans.Suma).Sum();
            var KosztZakupSrodkowMajatkowych
                = (from bilans in db.V_Bilans_Kwoty
                   where bilans.Rodzaj == "Suma_ZSM" && bilans.Data >= startDate && bilans.Data < endDate
                   select bilans.Suma).Sum();
            var KosztRozne
                = (from bilans in db.V_Bilans_Kwoty
                   where bilans.Rodzaj == "Suma_KR" && bilans.Data >= startDate && bilans.Data < endDate
                   select bilans.Suma).Sum();
            var KosztPensje
                = (from bilans in db.V_Bilans_Kwoty
                   where bilans.Rodzaj == "Suma_P" && bilans.Data >= startDate && bilans.Data < endDate
                   select bilans.Suma).Sum();
            var ZyskSprzedarzSrodkowMajatkowych
                = (from bilans in db.V_Bilans_Kwoty
                   where bilans.Rodzaj == "Suma_PZS" && bilans.Data >= startDate && bilans.Data < endDate
                   select bilans.Suma).Sum();
            var ZyskSprzedarzMebli
            = (from bilans in db.V_Bilans_Kwoty
               where bilans.Rodzaj == "Suma_SM" && bilans.Data >= startDate && bilans.Data < endDate
               select bilans.Suma).Sum();

            var koszty = new List<object>
            {
                new { Rodzaj = "Oplaty Administracyjne", Suma = KosztOplatyAdministracyjne },
                new { Rodzaj = "Dostawy Materialu", Suma = KosztDostawyMaterialu },
                new { Rodzaj = "Eksploatacja Maszyn", Suma = KosztEksploatacjaMaszyn },
                new { Rodzaj = "Eksploatacja Pojazdow", Suma = KosztEksploatacjaPojazdow },
                new { Rodzaj = "Zakup Srodkow Majatkowych", Suma = KosztZakupSrodkowMajatkowych },
                new { Rodzaj = "Rozne", Suma = KosztRozne },
                new { Rodzaj = "Pensje", Suma = KosztPensje },
            };

            /*var kosztyPozostałe = (from b in db.V_Bilans_Kwoty
                          where b.Data >= startDate && b.Data < endDate && b.Rodzaj != "Suma_SM" && b.Rodzaj != "Suma_PZS"
                          && b.Rodzaj != "Suma_EP_T" && b.Rodzaj != "Suma_EP_P" && b.Rodzaj != "Suma_EP_U" && b.Rodzaj != "Suma_EP_OT"
                          group b by b.Rodzaj into g
                          select new { Kategoria = g.Key, Suma = g.Sum(x => x.Suma) });

            var kosztyPojazdy = (from b in db.V_Bilans_Kwoty
                           where b.Data >= startDate && b.Data < endDate && b.Rodzaj != "Suma_SM" && b.Rodzaj != "Suma_PZS"
                           && (b.Rodzaj == "Suma_EP_T" || b.Rodzaj == "Suma_EP_P" || b.Rodzaj == "Suma_EP_U" || b.Rodzaj == "Suma_EP_OT")
                           group b by "Eksploatacja pojazdów" into g
                           select new { Kategoria = g.Key, Suma = g.Sum(x => x.Suma) }).FirstOrDefault();

            var koszty = kosztyPozostałe.ToList();
            koszty.Add(kosztyPojazdy);*/

            chart2.Series.Clear();
            chart2.Titles.Clear();
            chart2.Titles.Add("Koszty w bilansie rocznym");

            chart2.Series.Add("Koszty");
            chart2.Series["Koszty"].ChartType = SeriesChartType.Pie;
            chart2.Series["Koszty"].IsValueShownAsLabel = true;
            chart2.Series["Koszty"].XValueMember = "Rodzaj";
            chart2.Series["Koszty"].YValueMembers = "Suma";
            chart2.DataSource = koszty.ToList();

            chart2.DataBind();

            //dgvVZamowienia.DataSource = koszty.ToList();

        }
        //----------------------------------------------------------------------------------------------------------------------initDgwZamowienia
        private void initDgwZamowienia()
        {
            
            var KosztOplatyAdministracyjne
                = (from bilans in db.V_Bilans_Kwoty
                   where bilans.Rodzaj == "Suma"
                   select bilans.Suma).Sum();
            var KosztDostawyMaterialu
                = (from bilans in db.V_Bilans_Kwoty
                   where bilans.Rodzaj == "Suma_AS"
                   select bilans.Suma).Sum();
            var KosztEksploatacjaMaszyn
                = (from bilans in db.V_Bilans_Kwoty
                   where bilans.Rodzaj == "Suma_EM"
                   select bilans.Suma).Sum();
            var KosztEksploatacjaPojazdow
                = (from bilans in db.V_Bilans_Kwoty
                   where (bilans.Rodzaj == "Suma_EP_T" || bilans.Rodzaj == "Suma_EP_P" || bilans.Rodzaj == "Suma_EP_U" || bilans.Rodzaj == "Suma_EP_OT")
                   select bilans.Suma).Sum();
            var KosztZakupSrodkowMajatkowych
                = (from bilans in db.V_Bilans_Kwoty
                   where bilans.Rodzaj == "Suma_ZSM"
                   select bilans.Suma).Sum();
            var KosztRozne
                = (from bilans in db.V_Bilans_Kwoty
                   where bilans.Rodzaj == "Suma_KR"
                   select bilans.Suma).Sum();
            var KosztPensje
                = (from bilans in db.V_Bilans_Kwoty
                   where bilans.Rodzaj == "Suma_P"
                   select bilans.Suma).Sum();
            var ZyskSprzedarzSrodkowMajatkowych
                = (from bilans in db.V_Bilans_Kwoty
                   where bilans.Rodzaj == "Suma_PZS"
                   select bilans.Suma).Sum();
            var ZyskSprzedarzMebli
            = (from bilans in db.V_Bilans_Kwoty
               where bilans.Rodzaj == "Suma_SM"
               select bilans.Suma).Sum();

            var koszty = new List<object>
            {
                new { Rodzaj = "Oplaty Administracyjne", Suma = KosztOplatyAdministracyjne },
                new { Rodzaj = "Dostawy Materialu", Suma = KosztDostawyMaterialu },
                new { Rodzaj = "Eksploatacja Maszyn", Suma = KosztEksploatacjaMaszyn },
                new { Rodzaj = "Eksploatacja Pojazdow", Suma = KosztEksploatacjaPojazdow },
                new { Rodzaj = "Zakup Srodkow Majatkowych", Suma = KosztZakupSrodkowMajatkowych },
                new { Rodzaj = "Rozne", Suma = KosztRozne },
                new { Rodzaj = "Pensje", Suma = KosztPensje },
            };

            dgvVZamowienia.DataSource = koszty.ToList();
            //dgvVZamowienia.DataSource = db.V_Bilans_Kwoty.ToList();
            dgvVZamowienia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void AFKlienciForm_Load(object sender, EventArgs e)
        {
            dgvVZamowienia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvVZamowienia.ClearSelection();
            dgvVSklad.ClearSelection();
        }
        //----------------------------------------------------------------------------------------------------------------------InitSkladZamowienia
        private void InitSkladZamowienia()
        {
            var styczen = (from bilans in db.V_Bilans_Kwoty
                           where bilans.Data >= new DateTime(2023, 01, 01) && bilans.Data < new DateTime(2023, 02, 01)
                           select bilans.Suma).Sum();

            var luty = (from bilans in db.V_Bilans_Kwoty
                        where bilans.Data >= new DateTime(2023, 02, 01) && bilans.Data < new DateTime(2023, 03, 01)
                        select bilans.Suma).Sum();

            var marzec = (from bilans in db.V_Bilans_Kwoty
                          where bilans.Data >= new DateTime(2023, 03, 01) && bilans.Data < new DateTime(2023, 04, 01)
                          select bilans.Suma).Sum();

            var kwiecien = (from bilans in db.V_Bilans_Kwoty
                            where bilans.Data >= new DateTime(2023, 04, 01) && bilans.Data < new DateTime(2023, 05, 01)
                            select bilans.Suma).Sum();

            var maj = (from bilans in db.V_Bilans_Kwoty
                       where bilans.Data >= new DateTime(2023, 05, 01) && bilans.Data < new DateTime(2023, 06, 01)
                       select bilans.Suma).Sum();

            var czerwiec = (from bilans in db.V_Bilans_Kwoty
                            where bilans.Data >= new DateTime(2023, 06, 01) && bilans.Data < new DateTime(2023, 07, 01)
                            select bilans.Suma).Sum();

            var wynik = new List<object>
            {
                new { Miesiac = "Styczeń", Suma = styczen },
                new { Miesiac = "Luty", Suma = luty },
                new { Miesiac = "Marzec", Suma = marzec },
                new { Miesiac = "Kwiecień", Suma = kwiecien },
                new { Miesiac = "Maj", Suma = maj },
                new { Miesiac = "Czerwiec", Suma = czerwiec }
            };

            dgvVSklad.DataSource = wynik;

            dgvVSklad.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }


    }
}
