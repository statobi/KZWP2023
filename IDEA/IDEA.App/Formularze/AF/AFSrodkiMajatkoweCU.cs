using IDEA.Database;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class AFSrodkiMajatkoweCU : Form
    {
        private bool flagEdit = false;
        Srodki_Majatkowe selectedSrodekMajatkowy = new Srodki_Majatkowe();
        IDEAEntities db = IDEADatabase.GetInstance();

        //Wersja Dodawanie
        public AFSrodkiMajatkoweCU()
        {
            InitializeComponent();
            initComboboxes();
            initDatePickers();

            checkBox1.Checked = false;
            txtPrzychod_Ze_Sprzedazy_Netto.Enabled = false;
            txtPrzychod_Ze_Sprzedazy_Brutto.Enabled = false;
            cbFaktury_Sprzedaz.Enabled = false;
            dData_Rozchodu.Enabled = false;
        }
        //Wersja Edycja
        public AFSrodkiMajatkoweCU(Srodki_Majatkowe _selectedSrodekMajatkowy)
        {
            flagEdit = true;
            InitializeComponent();
            initComboboxes();
            initDatePickers();

            selectedSrodekMajatkowy = _selectedSrodekMajatkowy;
            lblKindWindow.Text = "Edytowanie Istniejącego Środka Majątkowego";
            txtNazwa.Text = selectedSrodekMajatkowy.Nazwa.ToString();
            txtSymbol.Text = selectedSrodekMajatkowy.Symbol.ToString();
            cbID_Dzialy.SelectedIndex = selectedSrodekMajatkowy.ID_Dzialy - 1;
            txtKoszt_Zakupu_Netto.Text = selectedSrodekMajatkowy.Koszt_Zakupu_Netto.ToString();
            txtKoszt_Zakupu_Brutto.Text = selectedSrodekMajatkowy.Koszt_Zakupu_Brutto.ToString();
            //cbFaktury_Zakup.SelectedIndex = updateSrodekMajatkowy.ID_Faktury_Zakup - 1;
            dData_Przychodu.Value = selectedSrodekMajatkowy.Data_Przychodu;

            if (selectedSrodekMajatkowy.ID_Faktury_Zakup != null)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
                txtPrzychod_Ze_Sprzedazy_Netto.Enabled = false;
                txtPrzychod_Ze_Sprzedazy_Brutto.Enabled = false;
                cbFaktury_Sprzedaz.Enabled = false;
                dData_Rozchodu.Enabled = false;
            }

            txtPrzychod_Ze_Sprzedazy_Netto.Text = selectedSrodekMajatkowy.Przychod_Ze_Sprzedazy_Netto.ToString();
            txtPrzychod_Ze_Sprzedazy_Brutto.Text = selectedSrodekMajatkowy.Przychod_Ze_Sprzedazy_Brutto.ToString();
            //cbFaktury_Sprzedaz.SelectedIndex = (int)selectedSrodekMajatkowy.ID_Faktury_Sprzedaz - 1;
            //dData_Rozchodu.Value = (DateTime)selectedSrodekMajatkowy.Data_Rozchodu;

        }

        private void initComboboxes()
        {
            var query1 = from d in db.Dzialies
                         select new { d.ID_Dzialy, ID_Dzialu = d.Nazwa };
            cbID_Dzialy.DataSource = query1.ToList();
            cbID_Dzialy.DisplayMember = "ID_Dzialu";
            cbID_Dzialy.ValueMember = "ID_Dzialy";
            cbID_Dzialy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbID_Dzialy.SelectedIndex = -1;

            var query2 = from f in db.Fakturies
                         select f.ID_Faktury;
            cbFaktury_Zakup.DataSource = query2.ToList();
            //cbFaktury_Zakup.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cbFaktury_Zakup.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbFaktury_Zakup.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFaktury_Zakup.SelectedIndex = -1;

            var query3 = from f in db.Fakturies
                         select f.ID_Faktury;
            cbFaktury_Sprzedaz.DataSource = query3.ToList();
            //cbFaktury_Sprzedaz.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cbFaktury_Sprzedaz.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbFaktury_Sprzedaz.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFaktury_Sprzedaz.SelectedIndex = -1;
        }


        private void initDatePickers()
        {
            dData_Przychodu.CustomFormat = "yyyy-MM-dd";
            dData_Przychodu.Format = DateTimePickerFormat.Custom;
            dData_Przychodu.Value = DateTime.Today;

            dData_Rozchodu.CustomFormat = "yyyy-MM-dd";
            dData_Rozchodu.Format = DateTimePickerFormat.Custom;
            dData_Rozchodu.Value = DateTime.Today;
        }
        private void AFSrodkiMajatkoweCU_Load(object sender, EventArgs e)
        {

        }

        //Przesuwanie okna myszą
        private Point? lastPoint = null;
        private void panelMove_MouseUp(object sender, MouseEventArgs e)
        {
            lastPoint = null;
        }

        private void lblKindWindow_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedSrodekMajatkowy.ID_Faktury_Zakup != null)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
                txtPrzychod_Ze_Sprzedazy_Netto.Enabled = false;
                txtPrzychod_Ze_Sprzedazy_Brutto.Enabled = false;
                cbFaktury_Sprzedaz.Enabled = false;
                cbFaktury_Sprzedaz.SelectedIndex = -1;
                dData_Rozchodu.Enabled = false;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtNazwa.Text != null
            && txtSymbol.Text != null
            && cbID_Dzialy.SelectedIndex >= 0
            && txtKoszt_Zakupu_Netto.Text != null
            && txtKoszt_Zakupu_Brutto.Text != null
            && cbFaktury_Zakup.SelectedIndex >= 0
            && dData_Przychodu.Text != null)
            {
                if (flagEdit)
                {
                    //Edycja
                    Srodki_Majatkowe updateSrodekMajatkowy = db.Srodki_Majatkowe.First(sm => sm.ID_Srodki_Majatkowe == selectedSrodekMajatkowy.ID_Srodki_Majatkowe);

                    updateSrodekMajatkowy.Nazwa = txtNazwa.Text;
                    updateSrodekMajatkowy.Symbol = txtSymbol.Text;
                    updateSrodekMajatkowy.ID_Dzialy = (int)cbID_Dzialy.SelectedValue;
                    updateSrodekMajatkowy.Koszt_Zakupu_Netto = decimal.Parse(txtKoszt_Zakupu_Netto.Text);
                    updateSrodekMajatkowy.Koszt_Zakupu_Brutto = decimal.Parse(txtKoszt_Zakupu_Brutto.Text);
                    updateSrodekMajatkowy.ID_Faktury_Zakup = (int)cbFaktury_Zakup.SelectedValue;
                    updateSrodekMajatkowy.Data_Przychodu = dData_Przychodu.Value;

                    if (cbFaktury_Zakup.SelectedValue != null && checkBox1.Checked)
                    {
                        updateSrodekMajatkowy.ID_Faktury_Sprzedaz = (int)cbFaktury_Sprzedaz.SelectedValue;
                        updateSrodekMajatkowy.Przychod_Ze_Sprzedazy_Netto = decimal.Parse(txtPrzychod_Ze_Sprzedazy_Netto.Text);
                        updateSrodekMajatkowy.Przychod_Ze_Sprzedazy_Brutto = decimal.Parse(txtPrzychod_Ze_Sprzedazy_Brutto.Text);
                        updateSrodekMajatkowy.Data_Rozchodu = dData_Rozchodu.Value;
                    }

                    else
                    {
                        updateSrodekMajatkowy.ID_Faktury_Sprzedaz = null;
                        db.SaveChanges();
                    }

                }
                else
                {
                    //Dodanie nowego środka

                    Srodki_Majatkowe newSrodekMajatkowy = new Srodki_Majatkowe();
                    newSrodekMajatkowy.Nazwa = txtNazwa.Text;
                    newSrodekMajatkowy.Symbol = txtSymbol.Text;
                    newSrodekMajatkowy.ID_Dzialy = (int)cbID_Dzialy.SelectedValue;
                    newSrodekMajatkowy.Koszt_Zakupu_Netto = decimal.Parse(txtKoszt_Zakupu_Netto.Text);
                    newSrodekMajatkowy.Koszt_Zakupu_Brutto = decimal.Parse(txtKoszt_Zakupu_Brutto.Text);
                    newSrodekMajatkowy.ID_Faktury_Zakup = (int)cbFaktury_Zakup.SelectedValue;
                    newSrodekMajatkowy.Data_Przychodu = dData_Przychodu.Value;

                    if (cbFaktury_Zakup.SelectedValue != null && checkBox1.Checked)
                    {
                        newSrodekMajatkowy.ID_Faktury_Sprzedaz = (int)cbFaktury_Sprzedaz.SelectedValue;
                        newSrodekMajatkowy.Przychod_Ze_Sprzedazy_Netto = decimal.Parse(txtPrzychod_Ze_Sprzedazy_Netto.Text);
                        newSrodekMajatkowy.Przychod_Ze_Sprzedazy_Brutto = decimal.Parse(txtPrzychod_Ze_Sprzedazy_Brutto.Text);
                        newSrodekMajatkowy.Data_Rozchodu = dData_Rozchodu.Value;
                    }

                    else
                        newSrodekMajatkowy.ID_Faktury_Sprzedaz = null;
                    db.Srodki_Majatkowe.Add(newSrodekMajatkowy);
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
    }
}
