using IDEA.Database;
using System;
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
        }
        //Wersja Edycja
        public AFFakturyCU(Faktury _selectedFaktura)
        {
            flagEdit = true;
            InitializeComponent();
            selectedFaktura = _selectedFaktura;
            lblKindWindow.Text = "Edytowanie IstniejącejFaktury";
            txtID_Faktury.Text = selectedFaktura.ID_Faktury.ToString();
            txtID_Rodzaj_Faktury.Text = selectedFaktura.ID_Rodzaj_Faktury.ToString();
            txtData_Wplywu.Text = selectedFaktura.Data_Wplywu.ToString();
            txtTermin_Platnosci.Text = selectedFaktura.Termin_platnosci.ToString();
            txtID_Pracownicy.Text = selectedFaktura.ID_Pracownicy.ToString();
            txtNazwa_Podmiotu.Text = selectedFaktura.Nazwa_Podmiotu;
            txtNIP.Text = selectedFaktura.NIP;
            txtUlica.Text = selectedFaktura.Adres_Ulica;
            maskTxtKod.Text = selectedFaktura.Adres_Kod_Pocztowy;
            txtMiasto.Text = selectedFaktura.Adres_Miasto;
            txtKwota_Netto.Text = selectedFaktura.Kwota_Netto.ToString();
            txtKwota_Brutto.Text = selectedFaktura.Kwota_Brutto.ToString();
            txtData_Zaplaty.Text = selectedFaktura.Data_Zaplaty.ToString();
            txtID_Stan_Faktury.Text = selectedFaktura.ID_Stan_Faktury.ToString();
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (flagEdit)
            {
                //Edycja
                Faktury updateFaktury = db.Fakturies.First(p => p.ID_Faktury == (selectedFaktura.ID_Faktury));
                updateFaktury.ID_Faktury = int.Parse(txtID_Faktury.Text);
                updateFaktury.ID_Rodzaj_Faktury = int.Parse(txtID_Rodzaj_Faktury.Text);
                updateFaktury.Data_Wplywu = DateTime.Parse(txtData_Wplywu.Text);
                updateFaktury.Termin_platnosci = int.Parse(txtTermin_Platnosci.Text);
                updateFaktury.ID_Pracownicy = int.Parse(txtData_Wplywu.Text);
                updateFaktury.Nazwa_Podmiotu = txtNazwa_Podmiotu.Text;
                updateFaktury.NIP = txtNIP.Text;
                updateFaktury.Adres_Ulica = txtUlica.Text;
                updateFaktury.Adres_Kod_Pocztowy = maskTxtKod.Text;
                updateFaktury.Adres_Miasto = txtMiasto.Text;
                updateFaktury.Kwota_Netto = int.Parse(txtKwota_Netto.Text);
                updateFaktury.Kwota_Brutto = int.Parse(txtKwota_Brutto.Text);
                updateFaktury.Data_Zaplaty = DateTime.Parse(txtData_Zaplaty.Text);
                updateFaktury.ID_Stan_Faktury = int.Parse(txtID_Stan_Faktury.Text);
                db.SaveChanges();
            }
            else
            {
                //Dodanie nowej faktury
                Faktury fakturaNew = new Faktury();
                fakturaNew.ID_Faktury = int.Parse(txtID_Faktury.Text);
                fakturaNew.ID_Rodzaj_Faktury = int.Parse(txtID_Rodzaj_Faktury.Text);
                fakturaNew.Data_Wplywu = DateTime.Parse(txtData_Wplywu.Text);
                fakturaNew.Termin_platnosci = int.Parse(txtTermin_Platnosci.Text);
                fakturaNew.ID_Pracownicy = int.Parse(txtData_Wplywu.Text);
                fakturaNew.Nazwa_Podmiotu = txtNazwa_Podmiotu.Text;
                fakturaNew.NIP = txtNIP.Text;
                fakturaNew.Adres_Ulica = txtUlica.Text;
                fakturaNew.Adres_Kod_Pocztowy = maskTxtKod.Text;
                fakturaNew.Adres_Miasto = txtMiasto.Text;
                fakturaNew.Kwota_Netto = int.Parse(txtKwota_Netto.Text);
                fakturaNew.Kwota_Brutto = int.Parse(txtKwota_Brutto.Text);
                fakturaNew.Data_Zaplaty = DateTime.Parse(txtData_Zaplaty.Text);
                fakturaNew.ID_Stan_Faktury = int.Parse(txtID_Stan_Faktury.Text);
                db.Fakturies.Add(fakturaNew);
                db.SaveChanges();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
