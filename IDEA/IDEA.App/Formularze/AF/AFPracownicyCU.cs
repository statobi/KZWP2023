using IDEA.Database;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace IDEA.App
{
    public partial class AFPracownicyCU : Form
    {
        private bool flagEdit = false;
        Pracownicy selectedPracownicy = new Pracownicy();
        IDEAEntities db = IDEADatabase.GetInstance();

        //Wersja Dodawanie
        public AFPracownicyCU()
        {
            InitializeComponent();
        }
        //Wersja Edytowanie
        public AFPracownicyCU(Pracownicy _selectedPracownicy)
        {
            flagEdit = true;
            InitializeComponent();
            selectedPracownicy = _selectedPracownicy;
            lblKindWindow.Text = "Edytowanie Istniejącego Pracownika";
            txtImie.Text = selectedPracownicy.Imie;
            txtNazwisko.Text = selectedPracownicy.Nazwisko;
            txtPESEL.Text = selectedPracownicy.PESEL;
            txtUlica.Text = selectedPracownicy.Adres_Ulica;
            maskTxtKod.Text = selectedPracownicy.Adres_Kod_Pocztowy;
            txtMiasto.Text = selectedPracownicy.Adres_Miasto;
            txtTelefon.Text = selectedPracownicy.Telefon;
            txtEmail.Text = selectedPracownicy.E_mail;
            txtNumerKontaBankowego.Text = selectedPracownicy.Numer_Konta_Bankowego;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtImie.Text != null && txtImie.Text != ""
                && txtNazwisko.Text != null && txtNazwisko.Text != ""
                && txtPESEL.Text != null && txtPESEL.Text != ""
                && txtUlica.Text != null && txtUlica.Text != ""
                && maskTxtKod.Text != null && maskTxtKod.Text != "  -"
                && txtMiasto.Text != null && txtMiasto.Text != "")
            {
                if (flagEdit)
                {
                    //Edycja
                    Pracownicy updatePracownicy = db.Pracownicies.First(p => p.ID_Pracownicy == selectedPracownicy.ID_Pracownicy);
                    updatePracownicy.Imie = txtImie.Text;
                    updatePracownicy.Nazwisko = txtNazwisko.Text;
                    updatePracownicy.PESEL = txtPESEL.Text;
                    updatePracownicy.Adres_Ulica = txtUlica.Text;
                    updatePracownicy.Adres_Kod_Pocztowy = maskTxtKod.Text;
                    updatePracownicy.Adres_Miasto = txtMiasto.Text;
                    updatePracownicy.Telefon = txtTelefon.Text;
                    updatePracownicy.E_mail = txtEmail.Text;
                    updatePracownicy.Numer_Konta_Bankowego = txtNumerKontaBankowego.Text;
                    db.SaveChanges();
                }
                else
                {
                    //Dodanie nowego pracownika
                    Pracownicy PracownikNew = new Pracownicy();
                    PracownikNew.Imie = txtImie.Text;
                    PracownikNew.Nazwisko = txtNazwisko.Text;
                    PracownikNew.PESEL = txtPESEL.Text;
                    PracownikNew.Adres_Ulica = txtUlica.Text;
                    PracownikNew.Adres_Kod_Pocztowy = maskTxtKod.Text;
                    PracownikNew.Adres_Miasto = txtMiasto.Text;
                    PracownikNew.Telefon = txtTelefon.Text;
                    PracownikNew.E_mail = txtEmail.Text;
                    PracownikNew.Numer_Konta_Bankowego = txtNumerKontaBankowego.Text;
                    db.Pracownicies.Add(PracownikNew);
                    db.SaveChanges();
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

        private void AFKlienciCU_Load(object sender, EventArgs e)
        {

        }

        private void txtImie_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblKindWindow_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void AFPracownicyCU_Load_1(object sender, EventArgs e)
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
