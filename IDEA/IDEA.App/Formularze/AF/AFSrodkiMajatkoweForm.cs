using IDEA.Database;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class AFSrodkiMajatkoweForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        //private IDEAEntities db;
        Srodki_Majatkowe selectedSrodekMajatkowy = new Srodki_Majatkowe();

        public AFSrodkiMajatkoweForm()
        {
            InitializeComponent();
            ToolTip toolTipNew = new ToolTip();
            toolTipNew.SetToolTip(iBtnNew, "Nowy środek majątkowy");
            ToolTip toolTipModify = new ToolTip();
            toolTipModify.SetToolTip(iBtnEdit, "Edytuj środek majątkowy");
            ToolTip toolTipDelete = new ToolTip();
            toolTipDelete.SetToolTip(iBtnDelete, "Usuń środek majątkowy");
            initDgwSrodkiMajatkowe();
        }

        private void initDgwSrodkiMajatkowe()
        {
            var query = from sm in db.Srodki_Majatkowe
                        join d in db.Dzialies on sm.ID_Dzialy equals d.ID_Dzialy
                        join fz in db.Fakturies on sm.ID_Faktury_Zakup equals fz.ID_Faktury
                        orderby sm.Data_Przychodu descending, sm.ID_Faktury_Sprzedaz
                        select new
                        {
                            sm.ID_Srodki_Majatkowe,
                            NazwaSrodkiMajatkowe = sm.Nazwa,
                            sm.Symbol,
                            NazwaDzialu = d.Nazwa,
                            sm.Koszt_Zakupu_Netto,
                            sm.Koszt_Zakupu_Brutto,
                            ID_Faktury = sm.ID_Faktury_Sprzedaz + " " + sm.ID_Faktury_Zakup,
                            sm.Data_Przychodu,
                            sm.Przychod_Ze_Sprzedazy_Netto,
                            sm.Przychod_Ze_Sprzedazy_Brutto,
                            sm.Data_Rozchodu,
                        };

            dgvSrodkiMajatkowe.DataSource = query.ToList();

            dgvSrodkiMajatkowe.Columns["ID_Srodki_Majatkowe"].Visible = false;
            dgvSrodkiMajatkowe.Columns["NazwaSrodkiMajatkowe"].HeaderText = "Nazwa Środka Majątkowego";
            dgvSrodkiMajatkowe.Columns["NazwaDzialu"].HeaderText = "Nazwa Działu";
            dgvSrodkiMajatkowe.Columns["Koszt_Zakupu_Netto"].HeaderText = "Koszt Zakupu (Netto)";
            dgvSrodkiMajatkowe.Columns["Koszt_Zakupu_Brutto"].HeaderText = "Koszt Zakupu (Brutto)";
            dgvSrodkiMajatkowe.Columns["ID_Faktury"].HeaderText = "ID Faktury";
            dgvSrodkiMajatkowe.Columns["Data_Przychodu"].HeaderText = "Data Przychodu";
            dgvSrodkiMajatkowe.Columns["Przychod_Ze_Sprzedazy_Netto"].HeaderText = "Przychód ze sprzedaży (Netto)";
            dgvSrodkiMajatkowe.Columns["Przychod_Ze_Sprzedazy_Brutto"].HeaderText = "Przychód ze sprzedaży (Brutto)";
            dgvSrodkiMajatkowe.Columns["Data_Rozchodu"].HeaderText = "Data Rozchodu";

            dgvSrodkiMajatkowe.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void AFSrodkiMajatkoweForm_Load(object sender, EventArgs e)
        {
            dgvSrodkiMajatkowe.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvSrodkiMajatkowe.ClearSelection();
        }
        private void dgvSrodkiMajatkowe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flagSelected = true;
            int index;
            index = dgvSrodkiMajatkowe.CurrentRow.Index;
            DataGridViewRow selectedrow = dgvSrodkiMajatkowe.Rows[index];

            selectedSrodekMajatkowy.ID_Srodki_Majatkowe = int.Parse(selectedrow.Cells[0].Value.ToString());
            var query = from sm in db.Srodki_Majatkowe
                        where sm.ID_Srodki_Majatkowe == selectedSrodekMajatkowy.ID_Srodki_Majatkowe
                        select sm;
            foreach (Srodki_Majatkowe sm in query)
            {
                selectedSrodekMajatkowy.ID_Srodki_Majatkowe = sm.ID_Srodki_Majatkowe;
                selectedSrodekMajatkowy.Nazwa = sm.Nazwa;
                selectedSrodekMajatkowy.Symbol = sm.Symbol;
                selectedSrodekMajatkowy.ID_Dzialy = sm.ID_Dzialy;
                selectedSrodekMajatkowy.Koszt_Zakupu_Netto = sm.Koszt_Zakupu_Netto;
                selectedSrodekMajatkowy.Koszt_Zakupu_Brutto = sm.Koszt_Zakupu_Brutto;
                selectedSrodekMajatkowy.ID_Faktury_Zakup = sm.ID_Faktury_Zakup;
                selectedSrodekMajatkowy.Data_Przychodu = sm.Data_Przychodu;
                selectedSrodekMajatkowy.Przychod_Ze_Sprzedazy_Netto = sm.Przychod_Ze_Sprzedazy_Netto;
                selectedSrodekMajatkowy.Przychod_Ze_Sprzedazy_Brutto = sm.Przychod_Ze_Sprzedazy_Brutto;
                selectedSrodekMajatkowy.ID_Faktury_Sprzedaz = sm.ID_Faktury_Sprzedaz;
                selectedSrodekMajatkowy.Data_Rozchodu = sm.Data_Rozchodu;
            }
        }


        //Wersja Dodawanie
        private void iBtnNew_Click(object sender, EventArgs e)
        {
            //openKlientEdition(sender);
            using (AFSrodkiMajatkoweCU aF = new AFSrodkiMajatkoweCU())
            {
                aF.ShowDialog();
                initDgwSrodkiMajatkowe();
            }
        }
        //Wersja Edycja
        private void iBtnEdit_Click(object sender, EventArgs e)
        {
            if (flagSelected)
            {
                using (AFSrodkiMajatkoweCU aF = new AFSrodkiMajatkoweCU(selectedSrodekMajatkowy))
                {
                    aF.ShowDialog();
                    initDgwSrodkiMajatkowe();
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano środka do edycji!");
            }

        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć środek majątkowy?\n" + selectedSrodekMajatkowy.Nazwa, "Usuwanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var query = from sm in db.Srodki_Majatkowe
                            where sm.ID_Srodki_Majatkowe == selectedSrodekMajatkowy.ID_Srodki_Majatkowe
                            select sm;
                foreach (Srodki_Majatkowe sm in query)
                    db.Srodki_Majatkowe.Remove(sm);
                db.SaveChanges();
                initDgwSrodkiMajatkowe();
            }
            else if (dialogResult == DialogResult.No)
            {
                //kod
            }


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filtr = txtSearch.Text;

            var query = from sm in db.Srodki_Majatkowe
                        join d in db.Dzialies on sm.ID_Dzialy equals d.ID_Dzialy
                        join fz in db.Fakturies on sm.ID_Faktury_Zakup equals fz.ID_Faktury
                        orderby sm.Data_Rozchodu descending, sm.ID_Faktury_Sprzedaz
                        select new
                        {
                            sm.ID_Srodki_Majatkowe,
                            NazwaSrodkiMajatkowe = sm.Nazwa,
                            sm.Symbol,
                            NazwaDzialu = d.Nazwa,
                            sm.Koszt_Zakupu_Netto,
                            sm.Koszt_Zakupu_Brutto,
                            ID_Faktury = sm.ID_Faktury_Sprzedaz + " " + sm.ID_Faktury_Zakup,
                            sm.Data_Przychodu,
                            sm.Przychod_Ze_Sprzedazy_Netto,
                            sm.Przychod_Ze_Sprzedazy_Brutto,
                            sm.Data_Rozchodu,
                        };

            dgvSrodkiMajatkowe.DataSource = query.Where(k =>
               k.ID_Srodki_Majatkowe.ToString().Contains(filtr)
            || k.NazwaSrodkiMajatkowe.Contains(filtr)
            || k.Symbol.Contains(filtr)
            || k.ID_Faktury.ToString().Contains(filtr)).ToList();

            dgvSrodkiMajatkowe.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


        }
    }
}
