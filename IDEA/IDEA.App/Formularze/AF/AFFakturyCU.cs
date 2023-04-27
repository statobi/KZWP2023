using IDEA.Database;
using System;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
        }
        //Wersja Edycja
        public AFFakturyCU(Faktury _selectedFaktura)
        {
            flagEdit = true;
            InitializeComponent();
            initComboboxes();
            initDatePickers();
            selectedFaktura = _selectedFaktura;
            lblKindWindow.Text = "Edytowanie IstniejącejFaktury";
            txtID_Faktury.Text = selectedFaktura.ID_Faktury.ToString();
            cbRodzajFaktury.SelectedIndex = selectedFaktura.ID_Rodzaj_Faktury-1;
            dDataWplywu.Value = selectedFaktura.Data_Wplywu;
            numTerminPlatnosci.Value = selectedFaktura.Termin_platnosci;
            cbPracownik.SelectedIndex = selectedFaktura.ID_Pracownicy-1;
            txtNazwa_Podmiotu.Text = selectedFaktura.Nazwa_Podmiotu;
            txtNIP.Text = selectedFaktura.NIP;
            txtUlica.Text = selectedFaktura.Adres_Ulica;
            maskTxtKod.Text = selectedFaktura.Adres_Kod_Pocztowy;
            txtMiasto.Text = selectedFaktura.Adres_Miasto;
            txtKwota_Netto.Text = selectedFaktura.Kwota_Netto.ToString();
            txtKwota_Brutto.Text = selectedFaktura.Kwota_Brutto.ToString();

            if (selectedFaktura.Data_Zaplaty != null)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;  
            }

            dDataZaplaty.Value = (DateTime)selectedFaktura.Data_Zaplaty;
            cbStanFaktury.SelectedIndex = selectedFaktura.ID_Stan_Faktury-1;
        }

        private void initComboboxes()
        {
            var query1 = from rf in db.Rodzaj_Faktury
                         select new { rf.ID_Rodzaj_Faktury, RodzajFaktury = rf.Nazwa};
            cbRodzajFaktury.DataSource = query1.ToList();
            cbRodzajFaktury.DisplayMember = "RodzajFaktury";
            cbRodzajFaktury.ValueMember = "ID_Rodzaj_Faktury";
            cbRodzajFaktury.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRodzajFaktury.SelectedIndex = -1;

            var query2 = from p in db.Pracownicies
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
                updateFaktury.Kwota_Netto = int.Parse(txtKwota_Netto.Text);
                updateFaktury.Kwota_Brutto = int.Parse(txtKwota_Brutto.Text);

                if (checkBox1.Checked)
                {
                    updateFaktury.Data_Zaplaty = dDataWplywu.Value;
                }
                else 
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
                fakturaNew.Kwota_Netto = int.Parse(txtKwota_Netto.Text);
                fakturaNew.Kwota_Brutto = int.Parse(txtKwota_Brutto.Text);

                if (checkBox1.Checked)
                {
                    fakturaNew.Data_Zaplaty = dDataWplywu.Value;
                }
                else
                {
                    fakturaNew.Data_Zaplaty = null;
                }

                fakturaNew.ID_Stan_Faktury = (int)cbStanFaktury.SelectedValue;
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



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           if (checkBox1.Checked)
            {
                dDataZaplaty.Enabled = true;
            }
            else
            {
                dDataZaplaty.Enabled = false;
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

        
    }
}
