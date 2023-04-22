using IDEA.Database;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class AFKlienciCU : Form
    {
        private bool flagEdit = false;
        Klient selectedKlient = new Klient();
        IDEAEntities db = IDEADatabase.db;

        //Wersja Dodawanie
        public AFKlienciCU()
        {
            InitializeComponent();
        }
        //Wersja Edycja
        public AFKlienciCU(Klient _selectedKlient)
        {
            flagEdit = true;
            InitializeComponent();
            selectedKlient = _selectedKlient;
            lblKindWindow.Text = "Edytowanie IstniejącegoKlienta";
            txtImie.Text = selectedKlient.Imie;
            txtNazwisko.Text = selectedKlient.Nazwisko;
            txtNazwaPodmiotu.Text = selectedKlient.Nazwa_Podmiotu;
            txtNIP.Text = selectedKlient.NIP;
            txtUlica.Text = selectedKlient.Adres_Ulica;
            maskTxtKod.Text = selectedKlient.Adres_Kod_Pocztowy;
            txtMiasto.Text = selectedKlient.Adres_Miasto;
            txtTelefon.Text = selectedKlient.Telefon;
            txtEmail.Text = selectedKlient.E_mail;
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (flagEdit)
            {
                //Edycja
                Klient updateKlient = db.Klient.First(p => p.ID_Klient == selectedKlient.ID_Klient);
                updateKlient.Imie = txtImie.Text;
                updateKlient.Nazwisko = txtNazwisko.Text;
                updateKlient.Nazwa_Podmiotu = txtNazwaPodmiotu.Text;
                updateKlient.NIP = txtNIP.Text;
                updateKlient.Adres_Ulica = txtUlica.Text;
                updateKlient.Adres_Kod_Pocztowy = maskTxtKod.Text;
                updateKlient.Adres_Miasto = txtMiasto.Text;
                updateKlient.Telefon = txtTelefon.Text;
                updateKlient.E_mail = txtEmail.Text;
                db.SaveChanges();
            }
            else
            {
                //Dodanie nowego klienta
                Klient klientNew = new Klient();
                klientNew.Imie = txtImie.Text;
                klientNew.Nazwisko = txtNazwisko.Text;
                klientNew.Nazwa_Podmiotu = txtNazwaPodmiotu.Text;
                klientNew.NIP = txtNIP.Text;
                klientNew.Adres_Ulica = txtUlica.Text;
                klientNew.Adres_Kod_Pocztowy = maskTxtKod.Text;
                klientNew.Adres_Miasto = txtMiasto.Text;
                klientNew.Telefon = txtTelefon.Text;
                klientNew.E_mail = txtEmail.Text;
                db.Klient.Add(klientNew);
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
    }
}
