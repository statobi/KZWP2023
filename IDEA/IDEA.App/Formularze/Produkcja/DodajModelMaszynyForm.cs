using IDEA.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Produkcja
{
    public partial class DodajModelMaszynyForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        Model_Maszyny DodanyRodzaj = new Model_Maszyny();
        public DodajModelMaszynyForm()
        {
            InitializeComponent();
            initDgwModelMaszyny();
            initOpcjeParametrMaszyny();
            initOpcjeRodzajStrategiiEksploatacji();
        }


        private void initDgwModelMaszyny()
        {
            dgvModelMaszyny.DataSource = db.ModelMaszyny_Parametry.ToList();
            dgvModelMaszyny.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initOpcjeParametrMaszyny()
        {
            var ParametrMaszyny = db.Parametr_Maszyny
                .Select(s => s.Nazwa_Parametru).ToList();
           cbParametrMaszyny.DataSource = ParametrMaszyny;
           cbParametrMaszyny.DropDownStyle = ComboBoxStyle.DropDownList;
           cbParametrMaszyny.SelectedIndex = -1;
        }

        //private void DodanieModeluMaszyny()
       // {
            //Model_Maszyny ModelMaszynyNew = new Model_Maszyny();
           //// ModelMaszynyNew.Model = txtModelMaszyny.Text;
          //  db.Model_Maszyny.Add(ModelMaszynyNew);
           // db.SaveChanges();
          //  dgvModelMaszyny.Update();
           // dgvModelMaszyny.Refresh();
           // initDgwModelMaszyny();
       // }




        private void DodanieModeluMaszyny()
        {
            if (txtModelMaszyny.Text != null && txtModelMaszyny.Text != "")
               // && txtNazwisko.Text != null && txtNazwisko.Text != ""
               // && txtUlica.Text != null && txtUlica.Text != ""
               // && maskTxtKod.Text != null && maskTxtKod.Text != "  -"
               // && txtMiasto.Text != null && txtMiasto.Text != "")
            {
              //  if (flagEdit)
               // {
               //     //Edycja
               //     Klient updateKlient = db.Klients.First(p => p.ID_Klient == selectedKlient.ID_Klient);
               //     updateKlient.Imie = txtImie.Text;
               //     updateKlient.Nazwisko = txtNazwisko.Text;
               //     updateKlient.Nazwa_Podmiotu = txtNazwaPodmiotu.Text;
               //     updateKlient.NIP = txtNIP.Text;
               //     updateKlient.Adres_Ulica = txtUlica.Text;
               //     updateKlient.Adres_Kod_Pocztowy = maskTxtKod.Text;
               //     updateKlient.Adres_Miasto = txtMiasto.Text;
               //     updateKlient.Telefon = txtTelefon.Text;
               //     updateKlient.E_mail = txtEmail.Text;
               //     db.SaveChanges();
                //}
                //else
                {
                    //Dodanie nowego klienta
                    Model_Maszyny ModelMaszynyNew = new Model_Maszyny();
                    ModelMaszynyNew.Model = txtModelMaszyny.Text;
                    //  klientNew.Nazwisko = txtNazwisko.Text;
                    //  klientNew.Nazwa_Podmiotu = txtNazwaPodmiotu.Text;
                    //  klientNew.NIP = txtNIP.Text;
                    //  klientNew.Adres_Ulica = txtUlica.Text;
                    //  klientNew.Adres_Kod_Pocztowy = maskTxtKod.Text;
                    //  klientNew.Adres_Miasto = txtMiasto.Text;
                    //  klientNew.Telefon = txtTelefon.Text;
                    //  klientNew.E_mail = txtEmail.Text;
                   
                    db.Model_Maszyny.Add(ModelMaszynyNew);
                    db.SaveChanges();
                    dgvModelMaszyny.Update();
                    dgvModelMaszyny.Refresh();
                    initDgwModelMaszyny();
                    
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Nie wprowadzono wymaganych danych!");
        }




        private void initOpcjeRodzajStrategiiEksploatacji()
        {
            {
                var RodzajeStrategiiEksploatacji = db.Rodzaj_Strategii_Eksp
                        .Select(s => s.Nazwa).ToList();
                cbRodzajStrategiiEksploatacji.DataSource = RodzajeStrategiiEksploatacji;
                cbRodzajStrategiiEksploatacji.DropDownStyle = ComboBoxStyle.DropDownList;
                cbRodzajStrategiiEksploatacji.SelectedIndex = -1;
            }
        }
        private void DodajModelMaszynyForm_Load(object sender, EventArgs e)
        {
          
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DodanieModeluMaszyny();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dgvModelMaszyny_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
