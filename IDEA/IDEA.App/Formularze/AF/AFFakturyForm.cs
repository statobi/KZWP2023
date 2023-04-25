﻿using IDEA.Database;
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
            /*
              String query = "SELECT  f.ID_Faktury, rf.Nazwa, Data_Wplywu, Termin_platnosci, p.Imie + ' ' + p.Nazwisko AS Pracownik, Nazwa_Podmiotu, " +
                  "NIP, f.Adres_Ulica, f.Adres_Kod_Pocztowy, f.Adres_Miasto, f.Kwota_Netto, f.Kwota_Brutto, f.Data_Zaplaty, sf.Nazwa " +
                  "FROM Faktury f " +
                  "INNER JOIN Rodzaj_Faktury rf ON rf.ID_Rodzaj_Faktury = f.ID_Rodzaj_Faktury " +
                  "INNER JOIN Pracownicy p ON p.ID_Pracownicy = f.ID_Pracownicy " +
                  "INNER JOIN Stan_Faktury sf ON sf.ID_Stan_Faktury = f.ID_Stan_Faktury";
            */
            string query = "SELECT f.ID_Faktury, rf.Nazwa, Data_Wplywu, Termin_platnosci, p.Imie + ' ' + p.Nazwisko AS Pracownik, Nazwa_Podmiotu, NIP, f.Adres_Ulica, f.Adres_Kod_Pocztowy, f.Adres_Miasto, f.Kwota_Netto, f.Kwota_Brutto, f.Data_Zaplaty, sf.Nazwa FROM Faktury f INNER JOIN Rodzaj_Faktury rf ON rf.ID_Rodzaj_Faktury = f.ID_Rodzaj_Faktury INNER JOIN Pracownicy p ON p.ID_Pracownicy = f.ID_Pracownicy INNER JOIN Stan_Faktury sf ON sf.ID_Stan_Faktury = f.ID_Stan_Faktury;";

            
            dgvFaktury.DataSource = db.Fakturies.ToList();
            this.dgvFaktury.Columns["ID_Faktury"].Visible = false;
            dgvFaktury.Columns["Rodzaj_Faktury"].Visible = false;
            dgvFaktury.Columns["Data_Wplywu"].Visible = false;
            dgvFaktury.Columns["Termin_platnosci"].HeaderText = "Termin Płatności";
            dgvFaktury.Columns["ID_Pracownicy"].Visible = false;
            dgvFaktury.Columns["Nazwa_Podmiotu"].HeaderText = "Nazwa Podmiotu";
            dgvFaktury.Columns["NIP"].HeaderText = "NIP";
            dgvFaktury.Columns["Adres_Ulica"].HeaderText = "Ulica";
            dgvFaktury.Columns["Adres_Kod_Pocztowy"].HeaderText = "Kod pocztowy";
            dgvFaktury.Columns["Adres_Miasto"].HeaderText = "Miasto";
            dgvFaktury.Columns["Kwota_Netto"].HeaderText = "Kwota netto";
            dgvFaktury.Columns["Kwota_Brutto"].HeaderText = "Kwota brutto";
            dgvFaktury.Columns["Data_Zaplaty"].HeaderText = "Data zapłaty";
            dgvFaktury.Columns["Plik"].Visible = false;
            dgvFaktury.Columns["ID_Stan_Faktury"].HeaderText = "Stan faktury";
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
            selectedFaktury.ID_Rodzaj_Faktury = int.Parse(selectedrow.Cells[1].Value.ToString());
            selectedFaktury.Data_Wplywu = DateTime.Parse(selectedrow.Cells[2].Value.ToString());
            selectedFaktury.Termin_platnosci = int.Parse(selectedrow.Cells[3].Value.ToString());
            selectedFaktury.ID_Pracownicy = int.Parse(selectedrow.Cells[4].Value.ToString());
            selectedFaktury.Nazwa_Podmiotu = selectedrow.Cells[5].Value.ToString();
            selectedFaktury.NIP = selectedrow.Cells[6].Value.ToString();
            selectedFaktury.Adres_Ulica = selectedrow.Cells[7].Value.ToString();
            selectedFaktury.Adres_Kod_Pocztowy = selectedrow.Cells[8].Value.ToString();
            selectedFaktury.Adres_Miasto = selectedrow.Cells[9].Value.ToString();
            selectedFaktury.Kwota_Netto = decimal.Parse(selectedrow.Cells[10].Value.ToString());
            selectedFaktury.Kwota_Brutto = decimal.Parse(selectedrow.Cells[11].Value.ToString());
            selectedFaktury.Data_Zaplaty = DateTime.Parse(selectedrow.Cells[12].Value.ToString());
            selectedFaktury.ID_Stan_Faktury = int.Parse(selectedrow.Cells[13].Value.ToString());
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
                //using (AFFakturyCU aF = new AFFakturyCU(selectedFaktury))
                {
                    //aF.ShowDialog();
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
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć fakturę?\n" + selectedFaktury.Nazwa_Podmiotu + " " + selectedFaktury.Kwota_Netto, "Usuwanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var query = from p in db.Fakturies
                            where p.ID_Faktury == selectedFaktury.ID_Faktury
                            select p;
                foreach (Faktury p in query)
                    db.Fakturies.Remove(p);
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
    }
}
