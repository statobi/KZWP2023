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

        //private IDEAEntities db;
        Klient selectedKlient = new Klient();

        public AFZamowieniaForm()
        {
            InitializeComponent();
            ToolTip toolTipNew = new ToolTip();
            toolTipNew.SetToolTip(iBtnNew, "Nowy");
            ToolTip toolTipModify = new ToolTip();
            toolTipModify.SetToolTip(iBtnEdit, "Edytuj");
            ToolTip toolTipDelete = new ToolTip();
            toolTipDelete.SetToolTip(iBtnDelete, "Usuń");
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
        private void dgvKlienci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = dgvVZamowienia.CurrentRow.Index;

            DataGridViewRow selectedrow = dgvVZamowienia.Rows[index];
            /*
                        selectedKlient.Imie = selectedrow.Cells[1].Value.ToString();
                        selectedKlient.Nazwisko = selectedrow.Cells[2].Value.ToString();
                        selectedKlient.Nazwa_Podmiotu = selectedrow.Cells[3].Value.ToString();
                        selectedKlient.NIP = selectedrow.Cells[4].Value.ToString();
                        selectedKlient.Adres_Ulica = selectedrow.Cells[5].Value.ToString();
                        selectedKlient.Adres_Kod_Pocztowy = selectedrow.Cells[6].Value.ToString();
                        selectedKlient.Adres_Miasto = selectedrow.Cells[7].Value.ToString();
                        selectedKlient.Telefon = selectedrow.Cells[8].Value.ToString();
                        selectedKlient.E_mail = selectedrow.Cells[9].Value.ToString();
            */
            string idzamowienia;
            idzamowienia = dgvVZamowienia.Rows[e.RowIndex].Cells[0].Value.ToString();
            InitSkladZamowienia(idzamowienia);
        }

        private void InitSkladZamowienia( string ID)
        {
         
            string Wybor = "Select * from V_Sklad_Zamowienia WHERE ID_Zamowienia = " + ID;
            dgvVSklad.DataSource = db.V_Sklad_Zamowienia.SqlQuery(Wybor).ToList();
            dgvVSklad.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        /*
        private void openKlientEdition(object sender)
        {

        }
        private void openKlientEdition(object sender, Klient klient)
        {

        }*/

        //Wersja Dodawanie
        private void iBtnNew_Click(object sender, EventArgs e)
        {
            //openKlientEdition(sender);

            AFKlienciCU aF = new AFKlienciCU();
            aF.ShowDialog();
        }
        //Wersja Edycja
        private void iBtnEdit_Click(object sender, EventArgs e)
        {
            AFKlienciCU aF = new AFKlienciCU(selectedKlient);
            aF.ShowDialog();
        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {

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
