﻿using IDEA.Database;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class AFFakturyCU : Form
    {
        private bool flagEdit = false;
        Faktury selectedFaktura = new Faktury();
        IDEAEntities db = IDEADatabase.GetInstance();

        //Wersja Dodawanie
        public AFFakturyCU()
        {
            InitializeComponent();
            initComboboxes();
            initDatePickers();
            cbStanFaktury.SelectedIndex = 1;
            dDataZaplaty.Enabled = false;
            txtID_Faktury.Text = "";
        }
        //Wersja Edycja
        public AFFakturyCU(Faktury _selectedFaktura)
        {
            flagEdit = true;
            InitializeComponent();
            initComboboxes();
            initDatePickers();
            selectedFaktura = _selectedFaktura;
            lblKindWindow.Text = "Edytowanie Istniejącej Faktury";
            txtID_Faktury.Text = selectedFaktura.ID_Faktury.ToString();
            cbRodzajFaktury.SelectedIndex = selectedFaktura.ID_Rodzaj_Faktury - 1;
            dDataWplywu.Value = selectedFaktura.Data_Wplywu;
            numTerminPlatnosci.Value = selectedFaktura.Termin_platnosci;
            cbPracownik.SelectedValue = selectedFaktura.ID_Pracownicy;
            txtNazwa_Podmiotu.Text = selectedFaktura.Nazwa_Podmiotu;
            txtNIP.Text = selectedFaktura.NIP;
            txtUlica.Text = selectedFaktura.Adres_Ulica;
            maskTxtKod.Text = selectedFaktura.Adres_Kod_Pocztowy;
            txtMiasto.Text = selectedFaktura.Adres_Miasto;
            txtKwota_Netto.Text = selectedFaktura.Kwota_Netto.ToString();
            txtKwota_Brutto.Text = selectedFaktura.Kwota_Brutto.ToString();

            if (selectedFaktura.Data_Zaplaty != null)
            {
                cbStanFaktury.SelectedIndex = 0;
                dDataZaplaty.Value = (DateTime)selectedFaktura.Data_Zaplaty;
            }
            else
            {
                cbStanFaktury.SelectedIndex = 1;
            }


            cbStanFaktury.SelectedIndex = selectedFaktura.ID_Stan_Faktury - 1;
            txtID_Faktury.Text = selectedFaktura.ID_Faktury.ToString();
        }

        private void initComboboxes()
        {
            var query1 = from rf in db.Rodzaj_Faktury
                         select new { rf.ID_Rodzaj_Faktury, RodzajFaktury = rf.Nazwa };
            cbRodzajFaktury.DataSource = query1.ToList();
            cbRodzajFaktury.DisplayMember = "RodzajFaktury";
            cbRodzajFaktury.ValueMember = "ID_Rodzaj_Faktury";
            cbRodzajFaktury.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRodzajFaktury.SelectedIndex = -1;

            var query2 = from p in db.Pracownicies
                         join pd in db.Pracownicy_Dzialy on p.ID_Pracownicy equals pd.ID_Pracownicy
                         where pd.ID_Dzialy == 3
                         select new { p.ID_Pracownicy, ImieNazwisko = p.Imie + " " + p.Nazwisko };
            cbPracownik.DataSource = query2.ToList();
            cbPracownik.DisplayMember = "ImieNazwisko";
            cbPracownik.ValueMember = "ID_Pracownicy";
            cbPracownik.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPracownik.SelectedIndex = -1;

            var query3 = from sf in db.Stan_Faktury
                         select new { sf.ID_Stan_Faktury, StanFaktury = sf.Nazwa };
            cbStanFaktury.DataSource = query3.ToList();
            cbStanFaktury.DisplayMember = "StanFaktury";
            cbStanFaktury.ValueMember = "ID_Stan_Faktury";
            cbStanFaktury.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStanFaktury.SelectedIndex = -1;

            var query4 = from zk in db.Zamowienia_Klienci
                         select new { zk.ID_Zamowienia_Klienci, zk.Numer };
            cbZamowienie.DataSource = query4.ToList();
            cbZamowienie.DisplayMember = "Numer";
            cbZamowienie.ValueMember = "ID_Zamowienia_Klienci";
            cbZamowienie.DropDownStyle = ComboBoxStyle.DropDownList;
            cbZamowienie.SelectedIndex = -1;
        }
        private void initDatePickers()
        {
            dDataWplywu.CustomFormat = "yyyy-MM-dd";
            dDataWplywu.Format = DateTimePickerFormat.Custom;
            dDataWplywu.Value = DateTime.Today;

            dDataZaplaty.CustomFormat = "yyyy-MM-dd";
            dDataZaplaty.Format = DateTimePickerFormat.Custom;
            dDataZaplaty.Value = DateTime.Today;
            dDataZaplaty.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtID_Faktury != null
                && cbRodzajFaktury.SelectedIndex >= 0
                && cbPracownik.SelectedIndex >= 0
                && cbStanFaktury.SelectedIndex >= 0
                && dDataWplywu.Text != null
                && numTerminPlatnosci.Text != null
                && txtUlica.Text != null && txtUlica.Text != ""
                && maskTxtKod.Text != null && maskTxtKod.Text != "  -"
                && txtMiasto.Text != null && txtMiasto.Text != ""
                && txtKwota_Netto.Text != null && txtKwota_Netto.Text != ""
                && txtKwota_Brutto.Text != null && txtKwota_Netto.Text != "")
            {
                if (flagEdit)
                {
                    //Edycja
                    Faktury updateFaktury = db.Fakturies.First(p => p.ID_Faktury == (selectedFaktura.ID_Faktury));
                    updateFaktury.ID_Faktury = int.Parse(txtID_Faktury.Text);
                    updateFaktury.ID_Rodzaj_Faktury = (int)cbRodzajFaktury.SelectedValue;
                    updateFaktury.Data_Wplywu = dDataWplywu.Value;
                    updateFaktury.Termin_platnosci = (int)numTerminPlatnosci.Value;
                    updateFaktury.ID_Pracownicy = (int)cbPracownik.SelectedValue;
                    updateFaktury.Nazwa_Podmiotu = txtNazwa_Podmiotu.Text;
                    updateFaktury.NIP = txtNIP.Text;
                    updateFaktury.Adres_Ulica = txtUlica.Text;
                    updateFaktury.Adres_Kod_Pocztowy = maskTxtKod.Text;
                    updateFaktury.Adres_Miasto = txtMiasto.Text;
                    updateFaktury.Kwota_Netto = decimal.Parse(txtKwota_Netto.Text);
                    updateFaktury.Kwota_Brutto = decimal.Parse(txtKwota_Brutto.Text);

                    if (cbStanFaktury.SelectedIndex == 0)
                    {
                        updateFaktury.Data_Zaplaty = dDataWplywu.Value;
                    }
                    else if (cbStanFaktury.SelectedIndex == 1)
                    {
                        updateFaktury.Data_Zaplaty = null;
                    }

                    updateFaktury.ID_Stan_Faktury = (int)cbStanFaktury.SelectedValue;

                    db.SaveChanges();
                }
                else
                {
                    //Dodanie nowej faktury
                    Faktury fakturaNew = new Faktury();
                    fakturaNew.ID_Faktury = int.Parse(txtID_Faktury.Text);
                    fakturaNew.ID_Rodzaj_Faktury = (int)cbRodzajFaktury.SelectedValue;
                    fakturaNew.Data_Wplywu = dDataWplywu.Value;
                    fakturaNew.Termin_platnosci = (int)numTerminPlatnosci.Value;
                    fakturaNew.ID_Pracownicy = (int)cbPracownik.SelectedValue;
                    fakturaNew.Nazwa_Podmiotu = txtNazwa_Podmiotu.Text;
                    fakturaNew.NIP = txtNIP.Text;
                    fakturaNew.Adres_Ulica = txtUlica.Text;
                    fakturaNew.Adres_Kod_Pocztowy = maskTxtKod.Text;
                    fakturaNew.Adres_Miasto = txtMiasto.Text;
                    fakturaNew.Kwota_Netto = decimal.Parse(txtKwota_Netto.Text);
                    fakturaNew.Kwota_Brutto = decimal.Parse(txtKwota_Brutto.Text);

                    if (cbStanFaktury.SelectedIndex == 0)
                    {
                        fakturaNew.Data_Zaplaty = dDataWplywu.Value;
                    }
                    else if (cbStanFaktury.SelectedIndex == 1)
                    {
                        fakturaNew.Data_Zaplaty = null;
                    }

                    fakturaNew.ID_Stan_Faktury = (int)cbStanFaktury.SelectedValue;
                    db.Fakturies.Add(fakturaNew);
                    db.SaveChanges();

                    //-----------------------------------------------Zamówienie
                    /*
                    if (cbRodzajFaktury.SelectedIndex == 10 && cbZamowienie.SelectedIndex >= 0)
                    {
                        Zamowienia_Klienci updateZamowienie = db.Zamowienia_Klienci.First(p => p.ID_Zamowienia_Klienci == (int)cbZamowienie.SelectedValue);
                        updateZamowienie.ID_Faktury = int.Parse(txtID_Faktury.Text);
                        db.SaveChanges();
                    }
                    */

                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Nie wprowadzono wymaganych danych!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void txtKwota_Netto_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(txtKwota_Netto.Text, out double kwota))
            {
                //kod
            }
            else
            {
                txtKwota_Netto.Clear();
            }
        }
        private void txtKwota_Netto_Leave(object sender, EventArgs e)
        {
            if (Double.TryParse(txtKwota_Netto.Text, out double kwota))
                txtKwota_Netto.Text = Math.Round(kwota, 2).ToString("0.00");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)//kwota netto
        {
            if (Double.TryParse(txtKwota_Brutto.Text, out double kwota))
            {
                //kod
            }
            else
            {
                txtKwota_Brutto.Clear();
            }
        }

        private void txtKwota_Brutto_Leave(object sender, EventArgs e)
        {
            if (Double.TryParse(txtKwota_Brutto.Text, out double kwota))
                txtKwota_Brutto.Text = Math.Round(kwota, 2).ToString("0.00");
        }

        private void cbStanFaktury_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStanFaktury.SelectedIndex == 0 || cbStanFaktury.SelectedIndex == -1)
            {
                dDataZaplaty.Enabled = true;
            }
            else if (cbStanFaktury.SelectedIndex == 1)
            {
                dDataZaplaty.Enabled = false;
            }
        }
        private void cbRodzajFaktury_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRodzajFaktury.SelectedIndex >= 0)
            {
                int idFaktury;

                var query = (from f in db.Fakturies
                             where f.ID_Rodzaj_Faktury == (cbRodzajFaktury.SelectedIndex + 1)
                             select (int?)f.ID_Faktury)
                .Max();

                if (query != null)
                {
                    idFaktury = (int)query + 1;
                }
                else
                {
                    idFaktury = (cbRodzajFaktury.SelectedIndex + 1) * 1000 + 1;
                }

                txtID_Faktury.Text = idFaktury.ToString();
            }
            //------------------------------------------------------------------------------Zamowienia
            if (cbRodzajFaktury.SelectedIndex == 10)
            {
                lblZamowienie.Visible = true;
                cbZamowienie.Visible = true;
            }
            else
            {
                lblZamowienie.Visible = false;
                cbZamowienie.Visible = false;
            }
        }
        private void cbZamowienie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRodzajFaktury.SelectedIndex == 10)
            {
                var query = (from zk in db.Zamowienia_Klienci
                             join k in db.Klients on zk.ID_Klient equals k.ID_Klient
                             //join sz in db.Sklad_Zamowienia on zk.ID_Zamowienia_Klienci equals sz.ID_Zamowienia_Klienci
                             where zk.ID_Zamowienia_Klienci == (int)cbZamowienie.SelectedValue
                             select new { NazwaPodmiotu = k.Nazwa_Podmiotu, NIP = k.NIP, Ulica = k.Adres_Ulica, Kod = k.Adres_Kod_Pocztowy, Miasto = k.Adres_Miasto }).FirstOrDefault();

                if (query != null)
                {
                    txtNazwa_Podmiotu.Text = query.NazwaPodmiotu;
                    txtNIP.Text = query.NIP;
                    txtUlica.Text = query.Ulica;
                    maskTxtKod.Text = query.Kod;
                    txtMiasto.Text = query.Miasto;
                }

                var idZamowienia = (int)cbZamowienie.SelectedValue;

                var query2 = db.Sklad_Zamowienia
                    .Where(z => z.ID_Zamowienia_Klienci == idZamowienia)
                    .Sum(z => z.Cena_Netto * z.Ilosc);
                txtKwota_Netto.Text = query2.ToString();

                var query3 = db.Sklad_Zamowienia
                    .Where(z => z.ID_Zamowienia_Klienci == idZamowienia)
                    .Sum(z => z.Cena_Brutto * z.Ilosc);
                txtKwota_Brutto.Text = query3.ToString();
            }

        }
        private void AFKlienciCU_Load(object sender, EventArgs e)
        {

        }

        private void txtImie_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblKindWindow_Click(object sender, EventArgs e)
        {

        }

        private void lblImie_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dDataZaplaty_ValueChanged(object sender, EventArgs e)
        {

        }

        //Przesuwanie okna myszą
        private Point? lastPoint = null;
        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastPoint = new Point(e.X, e.Y);
            }
        }
        private void panelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (lastPoint.HasValue)
            {
                int deltaX = e.X - lastPoint.Value.X;
                int deltaY = e.Y - lastPoint.Value.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }
        private void panelMove_MouseUp(object sender, MouseEventArgs e)
        {
            lastPoint = null;
        }


    }
}
