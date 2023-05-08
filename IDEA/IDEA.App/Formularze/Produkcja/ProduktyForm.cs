using IDEA.App.Formularze.Produkcja;
using IDEA.Database;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class ProduktyForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        //private IDEAEntities db;
        Produkt selectedProdukt = new Produkt();


        public ProduktyForm()
        {
            InitializeComponent();
            ToolTip toolTipNew = new ToolTip();
            toolTipNew.SetToolTip(iBtnNew, "Nowy");
            ToolTip toolTipModify = new ToolTip();
            toolTipModify.SetToolTip(iBtnEdit, "Edytuj");
            ToolTip toolTipDelete = new ToolTip();
            toolTipDelete.SetToolTip(iBtnDelete, "Usuń");
            initDgwProdukt();
        }

        private void initDgwProdukt()
        {
            var ProduktQuery = from p in db.Produkts
                               join rp in db.Rodzaj_Produktu on p.ID_Rodzaj_Produktu equals rp.ID_Rodzaj_Produktu
                               select new
                               {
                                   p.ID_Produkt,
                                   rp.ID_Rodzaj_Produktu,
                                   Rodzaj = rp.Nazwa,
                                   p.Nazwa,
                                   Wymiary = p.Szerokosc + " x " + p.Glebokosc + " x " + p.Wysokosc,
                                   p.Masa,
                                   p.Zlozonosc_produktu
                               };
            dgvProdukty.DataSource = ProduktQuery.ToList();
            this.dgvProdukty.Columns["ID_Produkt"].Visible = false;
            dgvProdukty.Columns["ID_Rodzaj_Produktu"].Visible = false;
            dgvProdukty.Columns["Wymiary"].HeaderText = "Wymiary X,Y,Z [mm]";
            dgvProdukty.Columns["Masa"].HeaderText = "Masa [kg]";
            dgvProdukty.Columns["Zlozonosc_produktu"].HeaderText = "Złożoność produktu";

            dgvProdukty.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void AFProduktForm_Load(object sender, EventArgs e)
        {
            dgvProdukty.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvProdukty.ClearSelection();
        }
        //Wybieranie
        private void dgvProdukty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flagSelected = true;
            int index;
            index = dgvProdukty.CurrentRow.Index;

            DataGridViewRow selectedrow = dgvProdukty.Rows[index];
            selectedProdukt.ID_Produkt = int.Parse(selectedrow.Cells[0].Value.ToString());

            var query = from p in db.Produkts
                        where p.ID_Produkt == selectedProdukt.ID_Produkt
                        select p;
            foreach (Produkt p in query)
            {
                selectedProdukt.ID_Produkt = p.ID_Produkt;
                selectedProdukt.ID_Rodzaj_Produktu = p.ID_Rodzaj_Produktu;
                selectedProdukt.Zlozonosc_produktu = p.Zlozonosc_produktu;
                selectedProdukt.Nazwa = p.Nazwa;
                selectedProdukt.Szerokosc = p.Szerokosc;
                selectedProdukt.Glebokosc = p.Glebokosc;
                selectedProdukt.Wysokosc = p.Wysokosc;
                selectedProdukt.Masa = p.Masa;
            }
            //InitSkladZamowienia();
        }



        //Wersja Dodawanie
        private void iBtnNew_Click(object sender, EventArgs e)
        {
            //openPracownikEdition(sender);
            using (ProduktyCUForm p = new ProduktyCUForm())
            {
                p.ShowDialog();
                initDgwProdukt();
            }
        }
        //Wersja Edycja
        private void iBtnEdit_Click(object sender, EventArgs e)
        {
            if (flagSelected)
            {
                using (ProduktyCUForm p = new ProduktyCUForm(selectedProdukt))
                {
                    p.ShowDialog();
                    initDgwProdukt();
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano produktu do edycji!");
            }

        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć?\n" + selectedProdukt.Imie + " " + selectedProdukt.Nazwisko, "Usuwanie", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    var query = from p in db.Pracownicies
            //                where p.ID_Pracownicy == selectedProdukt.ID_Pracownicy
            //                select p;
            //    foreach (Pracownicy p in query)
            //        db.Pracownicies.Remove(p);
            //    db.SaveChanges();
            //    initDgwProdukt();
            //}
            //else if (dialogResult == DialogResult.No)
            //{
            //    //kod
            //}


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filtr = txtSearch.Text;
            var ProduktQuery = from p in db.Produkts
                               join rp in db.Rodzaj_Produktu on p.ID_Rodzaj_Produktu equals rp.ID_Rodzaj_Produktu
                               select new
                               {
                                   p.ID_Produkt,
                                   rp.ID_Rodzaj_Produktu,
                                   Rodzaj = rp.Nazwa,
                                   p.Nazwa,
                                   Wymiary = p.Szerokosc + " x " + p.Glebokosc + " x " + p.Wysokosc,
                                   p.Masa,
                                   p.Zlozonosc_produktu
                               };
            dgvProdukty.DataSource = ProduktQuery.Where(k => k.Nazwa.Contains(filtr) || k.Rodzaj.Contains(filtr)).ToList();
            dgvProdukty.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


        }






        private void btnRodzajUmowy_Click(object sender, EventArgs e)
        {

        }

        private void btnZatrudnienie_Click(object sender, EventArgs e)
        {
            {

            }

        }

        private void btnJezyki_Click(object sender, EventArgs e)
        {
            {


            }

        }



        private void dgvProdukty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDokumentacja_Click(object sender, EventArgs e)
        {

            DokumentacjaForm Dokumentacja = new DokumentacjaForm();
            Dokumentacja.ShowDialog();

        }

        private void btnProcesyTechnologiczne_Click(object sender, EventArgs e)
        {
            if (flagSelected)
            {
                ProcesyTechnologiczneForm ProcesyTechnologiczne = new ProcesyTechnologiczneForm(selectedProdukt);
                ProcesyTechnologiczne.ShowDialog();
            }
            else
                MessageBox.Show("Nie wybrano Produktu!");
            
        }
    }
}
