using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using IDEA.Database;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using IDEA.Produkcja;

namespace IDEA.App
{
    public partial class AFZamowieniaForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelectedZamowienie = false;
        private bool flagSelectedSklad = false;
        Zamowienia_Klienci selectedZamowienie = new Zamowienia_Klienci();

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
            ToolTip toolTipNewSklad = new ToolTip();
            toolTipNewSklad.SetToolTip(iBtnNewSklad, "Nowy skład");
            ToolTip toolTipModifySklad = new ToolTip();
            toolTipModifySklad.SetToolTip(iBtnEditSklad, "Edytuj skład");
            ToolTip toolTipDeleteSklad = new ToolTip();
            toolTipDeleteSklad.SetToolTip(iBtnDeleteSklad, "Usuń skład");
            //Inicjowanie Ddw
            initDgwZamowienia();
        }

        private void initDgwZamowienia()
        {
            dgvVZamowienia.DataSource = db.V_AF_zk.ToList();

            dgvVZamowienia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void AFKlienciForm_Load(object sender, EventArgs e)
        {
            dgvVZamowienia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
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
            InitSkladZamowienia(selectedZamowienie.ID_Zamowienia_Klienci);
        }
        private void InitSkladZamowienia(int ID)
        {
            var query3 = from s in db.V_AF_Sklad_Zamowienia
                         where s.ID_Zamowienia_Klienci == selectedZamowienie.ID_Zamowienia_Klienci
                         select s;
            dgvVSklad.DataSource = query3.ToList();

          
            dgvVSklad.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        //Wersja Dodawanie Zamowienia
        private void iBtnNew_Click(object sender, EventArgs e)
        {
            using (AFZamowieniaCU aF = new AFZamowieniaCU())
            {
                aF.ShowDialog();
                initDgwZamowienia();
            }
        }
        //Wersja Edycja
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filtr = txtSearch.Text;

            dgvVZamowienia.DataSource = db.Klients.Where(k => k.Imie.Contains(filtr)).ToList();
            dgvVZamowienia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


        }

        private void dgvVSklad_CellClick(object sender, DataGridViewCellEventArgs e)
        {



            //AF
            flagSelectedSklad = true;
            int index;
            index = dgvVSklad.CurrentRow.Index;

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
            InitSkladZamowienia(selectedZamowienie.ID_Zamowienia_Klienci);

         
            
        }

       

        private void dgvVZamowienia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iBtnSprawdz_Click(object sender, EventArgs e)
        {
            int i = 1;
            IDEA.Produkcja.AlgorytmWyznaczaniaDaty algorytm = new AlgorytmWyznaczaniaDaty();

            MessageBox.Show(algorytm.algorytmsprawdzaniadaty(1));
        }
    }
}
