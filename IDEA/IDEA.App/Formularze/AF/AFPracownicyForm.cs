﻿using IDEA.Database;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class AFPracownicyForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        //private IDEAEntities db;
        Pracownicy selectedPracownicy = new Pracownicy();

        public AFPracownicyForm()
        {
            InitializeComponent();
            ToolTip toolTipNew = new ToolTip();
            toolTipNew.SetToolTip(iBtnNew, "Nowy");
            ToolTip toolTipModify = new ToolTip();
            toolTipModify.SetToolTip(iBtnEdit, "Edytuj");
            ToolTip toolTipDelete = new ToolTip();
            toolTipDelete.SetToolTip(iBtnDelete, "Usuń");
            initDgwPracownicy();
        }

        private void initDgwPracownicy()
        {
            var query = from p in db.Pracownicies
                        join pz in db.Pracownicy_Zatrudnienie on p.ID_Pracownicy equals pz.ID_Pracownicy
                        join pd in db.Pracownicy_Dzialy on p.ID_Pracownicy equals pd.ID_Pracownicy
                        join dz in db.Dzialies on pd.ID_Dzialy equals dz.ID_Dzialy
                        join ps in db.Pracownicy_Stanowisko on p.ID_Pracownicy equals ps.ID_Pracownicy
                        join s in db.Stanowiskoes on ps.ID_Stanowisko equals s.ID_Stanowisko
                        join pru in db.Pracownicy_RodzajUmowy on p.ID_Pracownicy equals pru.ID_Pracownicy
                        join ru in db.Rodzaj_Umowy on pru.ID_Rodzaj_Umowy equals ru.ID_Rodzaj_Umowy
                        where pd.Data == (from pd2 in db.Pracownicy_Dzialy
                                          where pd2.ID_Pracownicy == p.ID_Pracownicy
                                          select pd2.Data).Max() &&
                        ps.Data == (from ps2 in db.Pracownicy_Stanowisko
                                    where ps2.ID_Pracownicy == p.ID_Pracownicy
                                    select ps2.Data).Max() &&
                        pru.Data == (from pru2 in db.Pracownicy_RodzajUmowy
                                     where pru2.ID_Pracownicy == p.ID_Pracownicy
                                     select pru2.Data).Max()
                        select new
                        {
                            p.ID_Pracownicy,
                            p.Imie,
                            p.Nazwisko,
                            p.PESEL,
                            Adres = p.Adres_Ulica + ", " + p.Adres_Kod_Pocztowy + ", " + p.Adres_Miasto,
                            p.Numer_Konta_Bankowego,
                            p.Telefon,
                            p.E_mail,
                            Dzial = dz.Nazwa,
                            Stanowisko = s.Nazwa,
                            Rodzaj_umowy = ru.Nazwa,
                            pz.Pensja_Brutto
                        };

            dgvPracownicy.DataSource = query.ToList();

            dgvPracownicy.Columns["ID_Pracownicy"].Visible = false;
            dgvPracownicy.Columns["Rodzaj_umowy"].HeaderText = "Rodzaj Umowy";
            dgvPracownicy.Columns["Numer_Konta_Bankowego"].HeaderText = "Numer Konta Bankowego";
            dgvPracownicy.Columns["E_mail"].HeaderText = "E-mail";
            dgvPracownicy.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            /*
            dgvPracownicy.DataSource = db.Pracownicies.ToList();
            this.dgvPracownicy.Columns["ID_Pracownicy"].Visible = false;
            dgvPracownicy.Columns["Badanie_Maszyny"].Visible = false;
            dgvPracownicy.Columns["Zamowienia_Klienci"].Visible = false;
            dgvPracownicy.Columns["Pracownicy_Zatrudnienie"].Visible = false;
            dgvPracownicy.Columns["Pracownicy_RodzajUmowy"].Visible = false;
            dgvPracownicy.Columns["Pracownicy_Dzialy"].Visible = false;
            dgvPracownicy.Columns["Pracownicy_Stanowisko"].Visible = false;
            dgvPracownicy.Columns["Pracownicy_Jezyki"].Visible = false;
            dgvPracownicy.Columns["Koszty_Rozne"].Visible = false;
            dgvPracownicy.Columns["Dostawas"].Visible = false;
            dgvPracownicy.Columns["Fakturies"].Visible = false;
            dgvPracownicy.Columns["Obslugis"].Visible = false;
            dgvPracownicy.Columns["ObslugiPojazdows"].Visible = false;
            dgvPracownicy.Columns["Proces_Pracownicy"].Visible = false;
            dgvPracownicy.Columns["RozlozeniePolki_Materialy"].Visible = false;
            dgvPracownicy.Columns["RozlozeniePolki_Produkty"].Visible = false;
            dgvPracownicy.Columns["SkladWysylka_Produkt"].Visible = false;
            dgvPracownicy.Columns["StanLicznikas"].Visible = false;
            dgvPracownicy.Columns["TransportWewnetrznies"].Visible = false;
            dgvPracownicy.Columns["Urlopies"].Visible = false;
            dgvPracownicy.Columns["Wysylkas"].Visible = false;
            dgvPracownicy.Columns["Zlecenie_Magazynowe"].Visible = false;
            dgvPracownicy.Columns["Oplaty_Administracyjne"].Visible = false;
            dgvPracownicy.Columns["Dokumentacja_Pracownicy"].Visible = false;
            dgvPracownicy.Columns["Imie"].HeaderText = "Imię";
            dgvPracownicy.Columns["Nazwisko"].HeaderText = "Nazwisko";
            dgvPracownicy.Columns["PESEL"].HeaderText = "PESEL";
            dgvPracownicy.Columns["Adres_Ulica"].HeaderText = "Ulica";
            dgvPracownicy.Columns["Adres_Kod_Pocztowy"].HeaderText = "Kod pocztowy";
            dgvPracownicy.Columns["Adres_Miasto"].HeaderText = "Miasto";
            dgvPracownicy.Columns["E_mail"].HeaderText = "Email";
            dgvPracownicy.Columns["Telefon"].HeaderText = "Telefon";
            dgvPracownicy.Columns["Numer_Konta_Bankowego"].HeaderText = "Numer konta bankowego";
            dgvPracownicy.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);*/
        }
        private void AFPracownicyForm_Load(object sender, EventArgs e)
        {
            dgvPracownicy.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPracownicy.ClearSelection();
        }
        private void dgvPracownicy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flagSelected = true;
            int index;
            index = dgvPracownicy.CurrentRow.Index;
            DataGridViewRow selectedrow = dgvPracownicy.Rows[index];

            selectedPracownicy.ID_Pracownicy = int.Parse(selectedrow.Cells[0].Value.ToString());
            var query = from p in db.Pracownicies
                        where p.ID_Pracownicy == selectedPracownicy.ID_Pracownicy
                        select p;
            foreach (Pracownicy p in query)
            {
                selectedPracownicy.ID_Pracownicy = p.ID_Pracownicy;
                selectedPracownicy.Imie = p.Imie;
                selectedPracownicy.Nazwisko = p.Nazwisko;
                selectedPracownicy.PESEL = p.PESEL;
                selectedPracownicy.Adres_Ulica = p.Adres_Ulica;
                selectedPracownicy.Adres_Kod_Pocztowy = p.Adres_Kod_Pocztowy;
                selectedPracownicy.Adres_Miasto = p.Adres_Miasto;
                selectedPracownicy.Numer_Konta_Bankowego = p.Numer_Konta_Bankowego;
                selectedPracownicy.Telefon = p.Telefon;
                selectedPracownicy.E_mail = p.E_mail;
            }


        }


        //Wersja Dodawanie
        private void iBtnNew_Click(object sender, EventArgs e)
        {
            //openPracownikEdition(sender);
            using (AFPracownicyCU aF = new AFPracownicyCU())
            {
                aF.ShowDialog();
                initDgwPracownicy();
            }
        }
        //Wersja Edycja
        private void iBtnEdit_Click(object sender, EventArgs e)
        {
            if (flagSelected)
            {
                using (AFPracownicyCU aF = new AFPracownicyCU(selectedPracownicy))
                {
                    aF.ShowDialog();
                    initDgwPracownicy();
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano pracownika do edycji!");
            }

        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć?\n" + selectedPracownicy.Imie + " " + selectedPracownicy.Nazwisko, "Usuwanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var query = from p in db.Pracownicies
                            where p.ID_Pracownicy == selectedPracownicy.ID_Pracownicy
                            select p;
                foreach (Pracownicy p in query)
                    db.Pracownicies.Remove(p);
                db.SaveChanges();
                initDgwPracownicy();
            }
            else if (dialogResult == DialogResult.No)
            {
                //kod
            }


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filtr = txtSearch.Text;

            dgvPracownicy.DataSource = db.Pracownicies.Where(k =>
               k.Imie.Contains(filtr)
            || k.Nazwisko.Contains(filtr)
            || k.PESEL.Contains(filtr)
            || k.Adres_Ulica.Contains(filtr)
            || k.Adres_Kod_Pocztowy.Contains(filtr)
            || k.Adres_Miasto.Contains(filtr)
            || k.Telefon.Contains(filtr)
            || k.E_mail.Contains(filtr)
            || k.Numer_Konta_Bankowego.Contains(filtr)).ToList();
            dgvPracownicy.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


        }

        private void btnDzial_Click(object sender, EventArgs e)
        {
            {
                if (flagSelected)
                {
                    using (AFPracownicyDzialyCU aF = new AFPracownicyDzialyCU(selectedPracownicy))
                    {
                        aF.ShowDialog();
                        initDgwPracownicy();
                    }
                }
                else
                {
                    MessageBox.Show("Nie wybrano pracownika!");
                }
            }
        }

        private void btnStanowisko_Click(object sender, EventArgs e)
        {
            {
                if (flagSelected)
                {
                    using (AFPracownicyStanowiskoCU aF = new AFPracownicyStanowiskoCU(selectedPracownicy))
                    {
                        aF.ShowDialog();
                        initDgwPracownicy();
                    }
                }
                else
                {
                    MessageBox.Show("Nie wybrano pracownika!");
                }
            }
        }

        private void btnRodzajUmowy_Click(object sender, EventArgs e)
        {
            if (flagSelected)
            {
                using (AFPracownicyRodzajUmowyCU aF = new AFPracownicyRodzajUmowyCU(selectedPracownicy))
                {
                    aF.ShowDialog();
                    initDgwPracownicy();
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano pracownika!");
            }
        }

        private void btnZatrudnienie_Click(object sender, EventArgs e)
        {
            {
                if (flagSelected)
                {
                    using (AFPracownicyZatrudnienieCU aF = new AFPracownicyZatrudnienieCU(selectedPracownicy))
                    {
                        aF.ShowDialog();
                        initDgwPracownicy();
                    }
                }
                else
                {
                    MessageBox.Show("Nie wybrano pracownika!");
                }

            }

        }

        private void btnJezyki_Click(object sender, EventArgs e)
        {
            {
                if (flagSelected)
                {
                    using (AFPracownicyJezykiCU aF = new AFPracownicyJezykiCU(selectedPracownicy))
                    {
                        aF.ShowDialog();
                        initDgwPracownicy();
                    }
                }
                else
                {
                    MessageBox.Show("Nie wybrano pracownika!");
                }

            }

        }

        private void dgvPracownicy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
