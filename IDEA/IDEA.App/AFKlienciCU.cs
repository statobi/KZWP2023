using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDEA.Database;

namespace IDEA.App
{
    public partial class AFKlienciCU : Form
    {
        Klient selectedKlient = new Klient();
        //Wersja Dodawanie
        public AFKlienciCU()
        {
            InitializeComponent();


        }
        //Wersja Edycja
        public AFKlienciCU(Klient _selectedKlient)
        {
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
            txtEmail.Text = selectedKlient.Telefon;

        }
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
