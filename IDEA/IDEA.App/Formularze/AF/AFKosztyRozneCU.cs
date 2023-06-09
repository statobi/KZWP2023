﻿using IDEA.Database;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App.Formularze.AF
{
    public partial class AFKosztyRozneCU : Form
    {
        private bool flagEdit = false;
        Koszty_Rozne selectedKoszty_Rozne = new Koszty_Rozne();
        IDEAEntities db = IDEADatabase.GetInstance();

        //Wersja Dodawnie
        public AFKosztyRozneCU()
        {
            InitializeComponent();
            initComboboxes();
            initDatePickers();
        }
        //Wersja Edytowanie
        public AFKosztyRozneCU(Koszty_Rozne _selectedKoszty_Rozne)
        {
            flagEdit = true;
            InitializeComponent();
            initComboboxes();
            initDatePickers();

            selectedKoszty_Rozne = _selectedKoszty_Rozne;
            lblKindWindow.Text = "Edytowanie Istniejącego Kosztu";

            cbRodzajKosztu.SelectedIndex = selectedKoszty_Rozne.ID_Rodzaj_Koszty_Rozne - 1;
            cbPracownik.SelectedValue = selectedKoszty_Rozne.ID_Pracownicy;
            txtKwota_Netto.Text = selectedKoszty_Rozne.Kwota_Netto.ToString();
            txtKwota_Brutto.Text = selectedKoszty_Rozne.Kwota_Brutto.ToString();
            cbFaktury.SelectedItem = selectedKoszty_Rozne.ID_Faktury;
            dData.Value = selectedKoszty_Rozne.Data;
        }

        private void initComboboxes()
        {
            var query1 = from p in db.Pracownicies
                         join pd in db.Pracownicy_Dzialy on p.ID_Pracownicy equals pd.ID_Pracownicy
                         where pd.ID_Dzialy == 3
                         select new { p.ID_Pracownicy, ImieNazwisko = p.Imie + " " + p.Nazwisko };
            cbPracownik.DataSource = query1.ToList();
            cbPracownik.DisplayMember = "ImieNazwisko";
            cbPracownik.ValueMember = "ID_Pracownicy";
            cbPracownik.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPracownik.SelectedIndex = -1;

            var query2 = from rkr in db.Rodzaj_Koszty_Rozne
                         select new {rkr.ID_Rodzaj_Koszty_Rozne, RodzajKosztyRozne = rkr.Nazwa };
            cbRodzajKosztu.DataSource = query2.ToList();
            cbRodzajKosztu.DisplayMember = "RodzajKosztyRozne";
            cbRodzajKosztu.ValueMember = "ID_Rodzaj_Koszty_Rozne";
            cbRodzajKosztu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRodzajKosztu.SelectedIndex = -1;

            var query3 = from f in db.Fakturies
                         select f.ID_Faktury;
            cbFaktury.DataSource = query3.ToList();
            //cbFaktury.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cbFaktury.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbFaktury.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFaktury.SelectedIndex = -1;
        }

        private void initDatePickers()
        {
            dData.CustomFormat = "yyyy-MM-dd";
            dData.Format = DateTimePickerFormat.Custom;
            dData.Value = DateTime.Today;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cbRodzajKosztu.SelectedIndex >= 0
                && cbPracownik.SelectedIndex >= 0)

            {
                if (flagEdit)
                {
                    //Edycja
                    Koszty_Rozne updateKoszty_Rozne = db.Koszty_Rozne.First(p => p.ID_Koszty_Rozne == (selectedKoszty_Rozne.ID_Koszty_Rozne));
                    updateKoszty_Rozne.ID_Rodzaj_Koszty_Rozne = (int)cbRodzajKosztu.SelectedValue;
                    updateKoszty_Rozne.ID_Pracownicy = (int)cbPracownik.SelectedValue;
                    updateKoszty_Rozne.Kwota_Netto = decimal.Parse(txtKwota_Netto.Text);
                    updateKoszty_Rozne.Kwota_Brutto = decimal.Parse(txtKwota_Brutto.Text);
                    updateKoszty_Rozne.ID_Faktury = (int)cbFaktury.SelectedValue;
                    updateKoszty_Rozne.Data = dData.Value;

                    db.SaveChanges();
                }
                else
                {
                    //Dodawanie
                    Koszty_Rozne newKoszty_Rozne = new Koszty_Rozne();
                    newKoszty_Rozne.ID_Rodzaj_Koszty_Rozne = (int)cbRodzajKosztu.SelectedValue;
                    newKoszty_Rozne.ID_Pracownicy = (int)cbPracownik.SelectedValue;
                    newKoszty_Rozne.Kwota_Netto = decimal.Parse(txtKwota_Netto.Text);
                    newKoszty_Rozne.Kwota_Brutto = decimal.Parse(txtKwota_Brutto.Text);
                    newKoszty_Rozne.ID_Faktury = (int)cbFaktury.SelectedValue;
                    newKoszty_Rozne.Data = dData.Value;

                    db.Koszty_Rozne.Add(newKoszty_Rozne);
                    db.SaveChanges();
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Nie wprowadzono wymaganych danych!");
        }
    }
}


