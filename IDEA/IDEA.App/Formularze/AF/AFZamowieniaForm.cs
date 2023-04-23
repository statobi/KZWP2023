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

namespace IDEA.App
{
    public partial class AFZamowieniaForm : Form
    {
        IDEAEntities db = IDEADatabase.db;
        private bool flagSelected = false;
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
            dgvVZamowienia.DataSource = db.V_Zamowienia_Klienci.ToList();
            
            dgvVZamowienia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void AFKlienciForm_Load(object sender, EventArgs e)
        {
            dgvVZamowienia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void dgvVZamowienia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flagSelected = true;
            int index;
            index = dgvVZamowienia.CurrentRow.Index;

            DataGridViewRow selectedrow = dgvVZamowienia.Rows[index];

            selectedZamowienie.ID_Zamowienia_Klienci = int.Parse(selectedrow.Cells[0].Value.ToString());
            var query = from p in db.Zamowienia_Klienci
                        where p.ID_Zamowienia_Klienci == selectedZamowienie.ID_Zamowienia_Klienci
                        select p;
            foreach (Zamowienia_Klienci p in query)
            {
                selectedZamowienie.ID_Zamowienia_Klienci = p.ID_Klient;
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
         
            string Wybor = "Select * from V_Sklad_Zamowienia WHERE ID_Zamowienia = " + ID;
            dgvVSklad.DataSource = db.V_Sklad_Zamowienia.SqlQuery(Wybor).ToList();
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
            if (flagSelected)
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
            string np;
            string il;
            string dz;
            string dr;
            np = dgvVSklad.Rows[e.RowIndex].Cells[3].Value.ToString();
            il = dgvVSklad.Rows[e.RowIndex].Cells[4].Value.ToString();
            dz = dgvVSklad.Rows[e.RowIndex].Cells[7].Value.ToString();
            dr = dgvVSklad.Rows[e.RowIndex].Cells[8].Value.ToString();
            algorytmsprawdzaniadaty(np, il, dz, dr);
        }

        private void algorytmsprawdzaniadaty(string nazwaproduktu, string iloscstring, string datazamowieniastring, string datarealizacjistring)
        {
            int ilosc;
            ilosc = Int32.Parse(iloscstring);
            var datazamowienia = DateTime.Parse(datazamowieniastring);
            var datarealizacji = DateTime.Parse(datarealizacjistring);
            var datadzis = DateTime.Now;
            int k = 1;

            var maxkolejnosc = db.Proces_Technologiczny_Produktu
                .Where(nzwp => nzwp.Nazwa_produktu == nazwaproduktu)
                .Max(ko => ko.Kolejnosc);
                


            var czastrwaniaprocesu = db.Proces_Technologiczny_Produktu
                .Where(x => x.Nazwa_produktu == nazwaproduktu && x.Kolejnosc == k)
                .Select(x => x.Ilosc_Godzin)
                .FirstOrDefault();

            var potrzebnamaszyna = db.Proces_Technologiczny_Produktu
                .Where(x => x.Nazwa_produktu == nazwaproduktu && x.Kolejnosc == k)
                .Select(x => x.Potrzebny_rodzaj_maszyny)
                .FirstOrDefault();

            









            if (potrzebnamaszyna == "Piła Stołowa" && maxkolejnosc==5 && czastrwaniaprocesu == 1)
            {
                 MessageBox.Show("działa");
             }








        }

        
    }
    }
