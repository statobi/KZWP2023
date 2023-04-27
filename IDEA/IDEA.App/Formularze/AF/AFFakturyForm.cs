using IDEA.Database;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class AFFakturyForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        //private IDEAEntities db;
        Faktury selectedFaktury = new Faktury();

        public AFFakturyForm()
        {
            InitializeComponent();
            ToolTip toolTipNew = new ToolTip();
            toolTipNew.SetToolTip(iBtnNewFaktura, "Nowa faktura");
            ToolTip toolTipModify = new ToolTip();
            toolTipModify.SetToolTip(iBtnEditFaktura, "Edytuj fakturę");
            ToolTip toolTipDelete = new ToolTip();
            toolTipDelete.SetToolTip(iBtnDeleteFaktura, "Usuń fakturę");
            initDgwFaktury();
        }

        private void initDgwFaktury()
        {
            var query = from f in db.Fakturies
                        join rf in db.Rodzaj_Faktury on f.ID_Rodzaj_Faktury equals rf.ID_Rodzaj_Faktury
                        join p in db.Pracownicies on f.ID_Pracownicy equals p.ID_Pracownicy
                        join sf in db.Stan_Faktury on f.ID_Stan_Faktury equals sf.ID_Stan_Faktury
                        orderby f.Data_Wplywu
                        select new
                        {
                            f.ID_Faktury,
                            RodzajFaktury = rf.Nazwa,
                            f.Data_Wplywu,
                            f.Termin_platnosci,
                            Pracownik = p.Imie + " " + p.Nazwisko,
                            f.Nazwa_Podmiotu,
                            f.NIP,
                            f.Adres_Ulica,
                            f.Adres_Kod_Pocztowy,
                            f.Adres_Miasto,
                            f.Kwota_Netto,
                            f.Kwota_Brutto,
                            f.Data_Zaplaty,
                            StanFaktury = sf.Nazwa
                        };



            // przypisanie wyniku kwerendy do DataSource dla DataGridView
            dgvFaktury.DataSource = query.ToList();

            this.dgvFaktury.Columns["ID_Faktury"].HeaderText = "ID Faktury";
            dgvFaktury.Columns["RodzajFaktury"].HeaderText = "Rodzaj Faktury";
            dgvFaktury.Columns["StanFaktury"].HeaderText = "Stan Faktury";
            dgvFaktury.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }
        private void AFFakturyForm_Load(object sender, EventArgs e)
        {
            dgvFaktury.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void dgvFaktury_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flagSelected = true;
            int index;
            index = dgvFaktury.CurrentRow.Index;

            DataGridViewRow selectedrow = dgvFaktury.Rows[index];

            selectedFaktury.ID_Faktury = int.Parse(selectedrow.Cells[0].Value.ToString());
            var query = from f in db.Fakturies
                        where f.ID_Faktury == selectedFaktury.ID_Faktury
                        select f;
            foreach (Faktury f in query)
            {
                selectedFaktury.ID_Rodzaj_Faktury = f.ID_Rodzaj_Faktury;
                selectedFaktury.Data_Wplywu = f.Data_Wplywu;
                selectedFaktury.Termin_platnosci = f.Termin_platnosci;
                selectedFaktury.ID_Pracownicy = f.ID_Pracownicy;
                selectedFaktury.Nazwa_Podmiotu = f.Nazwa_Podmiotu;
                selectedFaktury.NIP = f.NIP;
                selectedFaktury.Adres_Ulica = f.Adres_Ulica;
                selectedFaktury.Adres_Kod_Pocztowy = f.Adres_Kod_Pocztowy;
                selectedFaktury.Adres_Miasto = f.Adres_Miasto;
                selectedFaktury.Kwota_Netto = f.Kwota_Netto;
                selectedFaktury.Kwota_Brutto = f.Kwota_Brutto;
                selectedFaktury.Data_Zaplaty = f.Data_Zaplaty;
                selectedFaktury.ID_Stan_Faktury = f.ID_Stan_Faktury;
            }
        }

        //Wersja Dodawanie
        private void iBtnNewFaktura_Click(object sender, EventArgs e)
        {
            //openFakturyEdition(sender);
            using (AFFakturyCU aF = new AFFakturyCU())
            {
                aF.ShowDialog();
                initDgwFaktury();
            }
        }
        //Wersja Edycja
        private void iBtnEditFaktura_Click(object sender, EventArgs e)
        {
            if (flagSelected)
            {
                using (AFFakturyCU aF = new AFFakturyCU(selectedFaktury))
                {
                    aF.ShowDialog();
                    initDgwFaktury();
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano faktury do edycji!");
            }

        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć fakturę?\n" + selectedFaktury.Nazwa_Podmiotu, "Usuwanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var query = from f in db.Fakturies
                            where f.ID_Faktury == selectedFaktury.ID_Faktury
                            select f;
                foreach (Faktury f in query)
                    db.Fakturies.Remove(f);
                db.SaveChanges();
                initDgwFaktury();
            }
            else if (dialogResult == DialogResult.No)
            {
                //kod
            }


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filtr = txtSearch.Text;

            dgvFaktury.DataSource = db.Fakturies.Where(k =>
               k.ID_Faktury.ToString().Contains(filtr)
            || k.ID_Rodzaj_Faktury.ToString().Contains(filtr)
            || k.ID_Pracownicy.ToString().Contains(filtr)
            || k.Nazwa_Podmiotu.ToString().Contains(filtr)
            || k.NIP.Contains(filtr)
            || k.Adres_Ulica.Contains(filtr)
            || k.Adres_Kod_Pocztowy.Contains(filtr)
            || k.Adres_Miasto.Contains(filtr)
            || k.ID_Stan_Faktury.ToString().Contains(filtr)).ToList();

            dgvFaktury.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


        }

        private void AFFakturyForm_Load_1(object sender, EventArgs e)
        {
            dgvFaktury.ClearSelection();
        }
    }
}
