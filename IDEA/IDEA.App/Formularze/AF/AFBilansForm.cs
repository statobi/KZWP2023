using IDEA.Database;
using IDEA.Produkcja;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

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
            //Tooltips
            /*
            ToolTip toolTipNewZamowienie = new ToolTip();
            toolTipNewZamowienie.SetToolTip(iBtnNewZamowienie, "Nowe zamówienie");*/
            
            //Inicjowanie Ddw
            initDgwZamowienia();
        }
        //----------------------------------------------------------------------------------------------------------------------initDgwZamowienia
        private void initDgwZamowienia()
        {
            var query = from s in db.V_Bilans_Kwoty
                        orderby s.Data
                        select s;
            dgvVZamowienia.DataSource = query.ToList();
            
            dgvVZamowienia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void AFKlienciForm_Load(object sender, EventArgs e)
        {
            dgvVZamowienia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvVZamowienia.ClearSelection();
            dgvVSklad.ClearSelection();
        }
        //----------------------------------------------------------------------------------------------------------------------dgvVZamowienia_CellClick
        private void dgvVZamowienia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flagSelectedZamowienie = true;
            int index;
            index = dgvVZamowienia.CurrentRow.Index;

            DataGridViewRow selectedrow = dgvVZamowienia.Rows[index];

            selectedZamowienie.ID_Zamowienia_Klienci = int.Parse(selectedrow.Cells[0].Value.ToString());
            var query = from p in db.Zamowienia_Klienci
                        where p.ID_Zamowienia_Klienci == selectedZamowienie.ID_Zamowienia_Klienci
                        select p;
            foreach (Zamowienia_Klienci p in query)
            {
                selectedZamowienie.ID_Zamowienia_Klienci = p.ID_Zamowienia_Klienci;
                selectedZamowienie.ID_Pracownicy = p.ID_Pracownicy;
                selectedZamowienie.ID_Klient = p.ID_Klient;
                selectedZamowienie.Data_Zamowienia = p.Data_Zamowienia;
                selectedZamowienie.Data_Realizacji = p.Data_Realizacji;
                selectedZamowienie.Numer = p.Numer;
                selectedZamowienie.ID_Faktury = p.ID_Faktury;
            }
            InitSkladZamowienia();
        }
        //----------------------------------------------------------------------------------------------------------------------InitSkladZamowienia
        private void InitSkladZamowienia()
        {
            var query3 = from s in db.V_AF_Sklad_Zamowienia
                         join sz in db.Sklad_Zamowienia on s.ID_Sklad_Zamowienia equals sz.ID_Sklad_Zamowienia
                         where s.ID_Zamowienia_Klienci == selectedZamowienie.ID_Zamowienia_Klienci
                         select new {
                             s.ID_Zamowienia_Klienci,
                             s.ID_Sklad_Zamowienia,
                             s.Nazwa_Produktu,
                             s.Ilosc,
                             s.Cena_Netto,
                             s.Cena_Brutto,
                             Wartosc_Netto = s.Cena_Netto * s.Ilosc,
                             Wartosc_Brutto = s.Cena_Brutto * s.Ilosc,
                             sz.Komentarz
                         }; ;
            dgvVSklad.DataSource = query3.ToList();

            dgvVSklad.Columns["ID_Zamowienia_Klienci"].Visible = false;
            dgvVSklad.Columns["ID_Sklad_Zamowienia"].Visible = false;
            dgvVSklad.Columns["Nazwa_Produktu"].HeaderText = "Nazwa produktu";
            dgvVSklad.Columns["Cena_Netto"].HeaderText = "Cena netto";
            dgvVSklad.Columns["Cena_Brutto"].HeaderText = "Cena brutto";
            dgvVSklad.Columns["Wartosc_Netto"].HeaderText = "Wartość netto";
            dgvVSklad.Columns["Wartosc_Brutto"].HeaderText = "Wartość brutto";
            dgvVSklad.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        //----------------------------------------------------------------------------------------------------------------------dgvVSklad_CellClick
        private void dgvVSklad_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            flagSelectedSklad = true;
            int index;
            index = dgvVSklad.CurrentRow.Index;

            DataGridViewRow selectedrow = dgvVSklad.Rows[index];

            selectedSklad.ID_Sklad_Zamowienia = int.Parse(selectedrow.Cells[1].Value.ToString());
            var query = from p in db.Sklad_Zamowienia
                        where p.ID_Sklad_Zamowienia == selectedSklad.ID_Sklad_Zamowienia
                        select p;
            foreach (Sklad_Zamowienia p in query)
            {
                selectedSklad.ID_Sklad_Zamowienia = p.ID_Sklad_Zamowienia;
                selectedSklad.ID_Zamowienia_Klienci = p.ID_Zamowienia_Klienci;
                selectedSklad.ID_Produkt = p.ID_Produkt;
                selectedSklad.Ilosc = p.Ilosc;
                selectedSklad.Cena_Netto = p.Cena_Netto;
                selectedSklad.Cena_Brutto = p.Cena_Brutto;
                selectedSklad.Komentarz = p.Komentarz;
            }
        }


    }
}
