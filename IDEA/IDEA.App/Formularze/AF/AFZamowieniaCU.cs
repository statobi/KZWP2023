using IDEA.Database;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class AFZamowieniaCU : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagEdit = false;
        Zamowienia_Klienci selectedZamowienie = new Zamowienia_Klienci();

        //Wersja Dodawanie
        public AFZamowieniaCU()
        {
            InitializeComponent();

            initDatePickers();
            initComboboxes();
            checkBox1.Checked = false;
            cbFaktura.Enabled = false;
        }
        //Wersja Edycja
        public AFZamowieniaCU(Zamowienia_Klienci _selectedZamowienie)
        {
            flagEdit = true;
            InitializeComponent();
            selectedZamowienie = _selectedZamowienie;
            lblKindWindow.Text = "Edytowanie Istniejącego Zamówienia";

            initDatePickers();
            initComboboxes();

            cbKlient.SelectedIndex = selectedZamowienie.ID_Klient - 1;
            cbPracownik.SelectedIndex = selectedZamowienie.ID_Pracownicy - 1;
            dateDataZamowienia.Value = selectedZamowienie.Data_Zamowienia;
            dateDataRealizacji.Value = selectedZamowienie.Data_Realizacji;
            txtNumer.Text = selectedZamowienie.Numer;
            if (selectedZamowienie.ID_Faktury != null)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
                cbFaktura.Enabled = false;
            }
            cbFaktura.SelectedItem = selectedZamowienie.ID_Faktury;
        }
        private void initDatePickers()
        {
            dateDataZamowienia.CustomFormat = "yyyy-MM-dd";
            dateDataZamowienia.Format = DateTimePickerFormat.Custom;
            dateDataZamowienia.Value = DateTime.Today;

            dateDataRealizacji.CustomFormat = "yyyy-MM-dd";
            dateDataRealizacji.Format = DateTimePickerFormat.Custom;
            dateDataRealizacji.Value = DateTime.Today;
        }
        private void initComboboxes()
        {
            var query1 = from p in db.Pracownicies
                         select new { p.ID_Pracownicy, ImieNazwisko = p.Imie + " " + p.Nazwisko };
            cbPracownik.DataSource = query1.ToList();
            cbPracownik.DisplayMember = "ImieNazwisko";
            cbPracownik.ValueMember = "ID_Pracownicy";
            //cbPracownik.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cbPracownik.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbPracownik.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPracownik.SelectedIndex = -1;

            var query2 = from k in db.Klients
                         select new { k.ID_Klient, ImieNazwisko = k.Imie + " " + k.Nazwisko + " - " + k.Nazwa_Podmiotu };
            cbKlient.DataSource = query2.ToList();
            cbKlient.DisplayMember = "ImieNazwisko";
            cbKlient.ValueMember = "ID_Klient";
            //cbKlient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cbKlient.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbKlient.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKlient.SelectedIndex = -1;

            var query3 = from f in db.Fakturies
                         select f.ID_Faktury;
            cbFaktura.DataSource = query3.ToList();
            //cbFaktura.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cbFaktura.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbFaktura.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFaktura.SelectedIndex = -1;
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (flagEdit)
            {
                //Edycja
                Zamowienia_Klienci updateZamowienie = db.Zamowienia_Klienci.First(p => p.ID_Zamowienia_Klienci == selectedZamowienie.ID_Zamowienia_Klienci);

                updateZamowienie.ID_Klient = (int)cbKlient.SelectedValue;
                updateZamowienie.ID_Pracownicy = (int)cbPracownik.SelectedValue;
                updateZamowienie.Data_Zamowienia = dateDataZamowienia.Value;
                updateZamowienie.Data_Realizacji = dateDataRealizacji.Value;
                updateZamowienie.Numer = txtNumer.Text;
                if (cbFaktura.SelectedValue != null && checkBox1.Checked)
                    updateZamowienie.ID_Faktury = (int)cbFaktura.SelectedValue;
                else
                    updateZamowienie.ID_Faktury = null;
                db.SaveChanges();
            }
            else
            {
                //Dodanie nowego zamówienia

                Zamowienia_Klienci newZamowienie = new Zamowienia_Klienci();
                newZamowienie.ID_Klient = (int)cbKlient.SelectedValue;
                newZamowienie.ID_Pracownicy = (int)cbPracownik.SelectedValue;
                newZamowienie.Data_Zamowienia = dateDataZamowienia.Value;
                newZamowienie.Data_Realizacji = dateDataRealizacji.Value;
                newZamowienie.Numer = txtNumer.Text;
                if (cbFaktura.SelectedValue != null && checkBox1.Checked)
                    newZamowienie.ID_Faktury = (int)cbFaktura.SelectedValue;
                else
                    newZamowienie.ID_Faktury = null;
                db.Zamowienia_Klienci.Add(newZamowienie);
                db.SaveChanges();

                //Dodawanie statusu 1
                ZamowieniaKlienci_StatusZamowienia newStatus = new ZamowieniaKlienci_StatusZamowienia();
                newStatus.ID_Zamowienia_Klienci = newZamowienie.ID_Zamowienia_Klienci;
                newStatus.ID_Status_Zamowienia = 1;
                newStatus.Data = dateDataZamowienia.Value;

                db.ZamowieniaKlienci_StatusZamowienia.Add(newStatus);
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

        private void lblKindWindow_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cbFaktura.Enabled = true;
            }
            else
            {
                cbFaktura.Enabled = false;
                cbFaktura.SelectedIndex = -1;
            }
        }
    }
}
