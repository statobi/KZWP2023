using IDEA.Database;
using IDEA.Produkcja;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class AFZamowieniaForm : Form
    {
        //----------------------------------------------------------------------------------------------------------------------Deklaracje
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelectedZamowienie = false;
        private bool flagSelectedSklad = false;
        Zamowienia_Klienci selectedZamowienie = new Zamowienia_Klienci();
        Sklad_Zamowienia selectedSklad = new Sklad_Zamowienia();
        //----------------------------------------------------------------------------------------------------------------------Konstruktor
        public AFZamowieniaForm()
        {
            InitializeComponent();
            //Tooltips
            ToolTip toolTipNewZamowienie = new ToolTip();
            toolTipNewZamowienie.SetToolTip(iBtnNewZamowienie, "Nowe zamówienie");
            ToolTip toolTipModifyZamowienie = new ToolTip();
            toolTipModifyZamowienie.SetToolTip(iBtnEditZamowienie, "Edytuj zamówienie");
            ToolTip toolTipDeleteZamowienie = new ToolTip();
            toolTipDeleteZamowienie.SetToolTip(iBtnDeleteZamowienie, "Usuń zamówienie");
            ToolTip toolTipStanZamowienia = new ToolTip();
            toolTipStanZamowienia.SetToolTip(btnStanZamowienia, "Stan zamówienia");
            ToolTip toolTipNewSklad = new ToolTip();
            toolTipNewSklad.SetToolTip(iBtnNewSklad, "Nowy skład");
            ToolTip toolTipModifySklad = new ToolTip();
            toolTipModifySklad.SetToolTip(iBtnEditSklad, "Edytuj skład");
            ToolTip toolTipDeleteSklad = new ToolTip();
            toolTipDeleteSklad.SetToolTip(iBtnDeleteSklad, "Usuń skład");
            //Inicjowanie Ddw
            initDgwZamowienia();
        }
        //----------------------------------------------------------------------------------------------------------------------initDgwZamowienia
        private void initDgwZamowienia()
        {
            var query = from s in db.V_AF_zk
                        orderby s.Data_Zamowienia
                        select s;
            dgvVZamowienia.DataSource = query.ToList();

            dgvVZamowienia.Columns["ID_Zamowienia_Klienci"].Visible = false;
            dgvVZamowienia.Columns["Data_Zamowienia"].HeaderText = "Data zamówienia";
            dgvVZamowienia.Columns["Data_Realizacji"].HeaderText = "Data realizacji";
            dgvVZamowienia.Columns["ID_Faktury"].HeaderText = "Numer faktury";
            dgvVZamowienia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void AFKlienciForm_Load(object sender, EventArgs e)
        {
            dgvVZamowienia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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
                         where s.ID_Zamowienia_Klienci == selectedZamowienie.ID_Zamowienia_Klienci
                         select s;
            dgvVSklad.DataSource = query3.ToList();

            dgvVSklad.Columns["ID_Zamowienia_Klienci"].Visible = false;
            dgvVSklad.Columns["ID_Sklad_Zamowienia"].Visible = false;
            dgvVSklad.Columns["Nazwa_Produktu"].HeaderText = "Nazwa produktu";
            dgvVSklad.Columns["Cena_Netto"].HeaderText = "Cena netto";
            dgvVSklad.Columns["Cena_Brutto"].HeaderText = "Cena brutto";
            dgvVSklad.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        //----------------------------------------------------------------------------------------------------------------------Dodawanie Zamowienia
        private void iBtnNew_Click(object sender, EventArgs e)
        {
            using (AFZamowieniaCU aF = new AFZamowieniaCU())
            {
                aF.ShowDialog();
                initDgwZamowienia();
            }
        }
        //----------------------------------------------------------------------------------------------------------------------Edycja Zamowienia
        private void iBtnEdit_Click(object sender, EventArgs e)
        {
            if (flagSelectedZamowienie)
            {
                using (AFZamowieniaCU aF = new AFZamowieniaCU(selectedZamowienie))
                {
                    aF.ShowDialog();
                    initDgwZamowienia();
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano zamówienia do edycji!");
            }
        }
        //----------------------------------------------------------------------------------------------------------------------Usuwanie zamówienia
        private void iBtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć zamówienie nr: " + selectedZamowienie.Numer + " ?", "Usuwanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var query = from p in db.Zamowienia_Klienci
                            where p.ID_Zamowienia_Klienci == selectedZamowienie.ID_Zamowienia_Klienci
                            select p;
                foreach (Zamowienia_Klienci p in query)
                    db.Zamowienia_Klienci.Remove(p);
                db.SaveChanges();
                initDgwZamowienia();
            }
            else if (dialogResult == DialogResult.No)
            {
                //kod
            }
        }
        //----------------------------------------------------------------------------------------------------------------------Stan Zamówienia
        private void btnStanZamowienia_Click(object sender, EventArgs e)
        {
            if (flagSelectedZamowienie)
            {
                using (AFZamowieniaStatusCU aF = new AFZamowieniaStatusCU(selectedZamowienie))//---------
                {
                    aF.ShowDialog();
                    initDgwZamowienia();
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano zamówienia!");
            }
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
        //----------------------------------------------------------------------------------------------------------------------Dodawanie Składu
        private void iBtnNewSklad_Click(object sender, EventArgs e)
        {
            if (flagSelectedZamowienie)
                using (AFZamowieniaSkladCU aF = new AFZamowieniaSkladCU(selectedZamowienie))
                {
                    aF.ShowDialog();
                    InitSkladZamowienia();
                }
            else
            {
                MessageBox.Show("Nie wybrano zamówienia!");
            }


        }
        //----------------------------------------------------------------------------------------------------------------------Edycja Składu
        private void iBtnEditSklad_Click(object sender, EventArgs e)
        {
            if (flagSelectedSklad && flagSelectedZamowienie)
            {
                using (AFZamowieniaSkladCU aF = new AFZamowieniaSkladCU(selectedZamowienie, selectedSklad))
                {
                    aF.ShowDialog();
                    InitSkladZamowienia();
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano produktu do edycji!");
            }
        }
        //----------------------------------------------------------------------------------------------------------------------Usuwanie Składu
        private void iBtnDeleteSklad_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć produkt?", "Usuwanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var query = from p in db.Sklad_Zamowienia
                            where p.ID_Sklad_Zamowienia == selectedSklad.ID_Sklad_Zamowienia
                            select p;
                foreach (Sklad_Zamowienia p in query)
                    db.Sklad_Zamowienia.Remove(p);
                db.SaveChanges();
                InitSkladZamowienia();
            }
            else if (dialogResult == DialogResult.No)
            {
                //kod
            }
        }
        //----------------------------------------------------------------------------------------------------------------------Wyszukiwarka
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filtr = txtSearch.Text;

            var query = from s in db.V_AF_zk
                        orderby s.Data_Zamowienia
                        select s;
            dgvVZamowienia.DataSource = query.Where(k =>
            k.Klient.Contains(filtr) ||
            k.Pracownik.Contains(filtr) ||
            k.Numer.Contains(filtr) ||
            k.ID_Faktury.ToString().Contains(filtr) ||
            k.Status.Contains(filtr)
            ).ToList();
            dgvVZamowienia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        //----------------------------------------------------------------------------------------------------------------------Przycisk produkcji
        private void iBtnSprawdz_Click(object sender, EventArgs e)
        {
            if (flagSelectedSklad)
            {
                {
                    int i = 1;
                    IDEA.Produkcja.AlgorytmWyznaczaniaDaty algorytm = new AlgorytmWyznaczaniaDaty();

                    MessageBox.Show(algorytm.algorytmsprawdzaniadaty(i));
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano produktu do edycji!");
            }
        }


    }
}
