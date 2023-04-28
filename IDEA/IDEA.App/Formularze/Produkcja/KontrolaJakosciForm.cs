﻿using IDEA.Database;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class KontrolaJakosciForm: Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        //private IDEAEntities db;
        Klient selectedKlient = new Klient();

        public KontrolaJakosciForm()
        {
            InitializeComponent();
            ToolTip toolTipNew = new ToolTip();
            toolTipNew.SetToolTip(iBtnNew, "Nowy");
            ToolTip toolTipModify = new ToolTip();
            toolTipModify.SetToolTip(iBtnEdit, "Edytuj");
            ToolTip toolTipDelete = new ToolTip();
            toolTipDelete.SetToolTip(iBtnDelete, "Usuń");
            initDgwKlienci();
        }

        private void InitDgwKlienci()
        {
            dgvKlienci.DataSource = db.V_Kontrola_Jakosci.ToList();
            dgvKlienci.Columns["ID_Kontrola_Jakosci_Zamowienia"].Visible = false;
            dgvKlienci.Columns["Numer_skladu_zamowienia"].HeaderText = "Numer skladu zamowienia";
            dgvKlienci.Columns["Nazwa_Produktu"].HeaderText = "Nazwa Produktu";
            dgvKlienci.Columns["Ilosc_w_zamowieniu"].HeaderText = "Ilość w zamówieniu";
            dgvKlienci.Columns["Data_kontroli"].HeaderText = "Data kontroli";
            dgvKlienci.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void AFKlienciForm_Load(object sender, EventArgs e)
        {
            dgvKlienci.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void dgvKlienci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flagSelected = true;
            int index;
            index = dgvKlienci.CurrentRow.Index;

            DataGridViewRow selectedrow = dgvKlienci.Rows[index];
            selectedKlient.ID_Klient = int.Parse(selectedrow.Cells[0].Value.ToString());
            selectedKlient.Imie = selectedrow.Cells[1].Value.ToString();
            selectedKlient.Nazwisko = selectedrow.Cells[2].Value.ToString();
            selectedKlient.Nazwa_Podmiotu = selectedrow.Cells[3].Value.ToString();
            selectedKlient.NIP = selectedrow.Cells[4].Value.ToString();
            selectedKlient.Adres_Ulica = selectedrow.Cells[5].Value.ToString();
            selectedKlient.Adres_Kod_Pocztowy = selectedrow.Cells[6].Value.ToString();
            selectedKlient.Adres_Miasto = selectedrow.Cells[7].Value.ToString();
            selectedKlient.Telefon = selectedrow.Cells[8].Value.ToString();
            selectedKlient.E_mail = selectedrow.Cells[9].Value.ToString();
        }


        //Wersja Dodawanie
        private void iBtnNew_Click(object sender, EventArgs e)
        {
            //openKlientEdition(sender);
            using (AFKlienciCU aF = new AFKlienciCU())
            {
                aF.ShowDialog();
                initDgwKlienci();
            }
        }
        //Wersja Edycja
        private void iBtnEdit_Click(object sender, EventArgs e)
        {
            if (flagSelected)
            {
                using (AFKlienciCU aF = new AFKlienciCU(selectedKlient))
                {
                    aF.ShowDialog();
                    initDgwKlienci();
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano klienta do edycji!");
            }

        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć?\n" + selectedKlient.Imie + " " + selectedKlient.Nazwisko, "Usuwanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var query = from p in db.Klients
                            where p.ID_Klient == selectedKlient.ID_Klient
                            select p;
                foreach (Klient p in query)
                    db.Klients.Remove(p);
                db.SaveChanges();
                initDgwKlienci();
            }
            else if (dialogResult == DialogResult.No)
            {
                //kod
            }


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filtr = txtSearch.Text;

            dgvKlienci.DataSource = db.Klients.Where(k =>
               k.Imie.Contains(filtr)
            || k.Nazwisko.Contains(filtr)
            || k.Nazwa_Podmiotu.Contains(filtr)
            || k.NIP.Contains(filtr)
            || k.Adres_Ulica.Contains(filtr)
            || k.Adres_Kod_Pocztowy.Contains(filtr)
            || k.Adres_Miasto.Contains(filtr)
            || k.Telefon.Contains(filtr)
            || k.E_mail.Contains(filtr)).ToList();

            dgvKlienci.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


        }

        private void dgvKlienci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
