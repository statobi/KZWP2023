using IDEA.Database;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class AFZamowieniaSkladCU : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagEdit = false;
        Zamowienia_Klienci selectedZamowienie = new Zamowienia_Klienci();
        Sklad_Zamowienia selectedSklad = new Sklad_Zamowienia();

        //Wersja Dodawanie
        public AFZamowieniaSkladCU(Zamowienia_Klienci _selectedZamowienie)
        {
            selectedZamowienie = _selectedZamowienie;
            InitializeComponent();

            initComboboxes();
            txtSugerowanaCenaNetto.Text = "";
        }
        //Wersja Edycja
        public AFZamowieniaSkladCU(Zamowienia_Klienci _selectedZamowienie, Sklad_Zamowienia _selectedSklad)
        {
            flagEdit = true;
            InitializeComponent();
            selectedSklad = _selectedSklad;
            selectedZamowienie = _selectedZamowienie;
            lblKindWindow.Text = "Edytowanie Istniejącego Zamówienia";

            initComboboxes();

            txtSugerowanaCenaNetto.Clear();
            txtSugerowanaCenaBrutto.Clear();
            cbProdukt.SelectedIndex = selectedSklad.ID_Produkt - 1;
            numIlosc.Value = selectedSklad.Ilosc;
            txtCenaNetto.Text = selectedSklad.Cena_Netto.ToString();
            txtCenaBrutto.Text = selectedSklad.Cena_Brutto.ToString();
            richTxtKomentarz.Text = selectedSklad.Komentarz;

            txtSugerowanaCenaNetto.Text = "";
        }
        private void initComboboxes()
        {
            var query = from p in db.Produkts
                        select new { p.ID_Produkt, Nazwa = p.Nazwa };
            cbProdukt.DataSource = query.ToList();
            cbProdukt.DisplayMember = "Nazwa";
            cbProdukt.ValueMember = "ID_Produkt";
            cbProdukt.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProdukt.SelectedIndex = -1;
        }
        private void cbProdukt_SelectedIndexChanged(object sender, EventArgs e)//-----------------------------------------------------------Kosztorys
        {
            txtSugerowanaCenaNetto.Text = "";
            txtSugerowanaCenaBrutto.Text = "";
            lblAlert.Visible = false;
            //Dodawanie tymczasowego
            if (cbProdukt.SelectedIndex >= 0)
            {
                Sklad_Zamowienia temporarySklad = new Sklad_Zamowienia();
                temporarySklad.ID_Zamowienia_Klienci = selectedZamowienie.ID_Zamowienia_Klienci;
                temporarySklad.ID_Produkt = cbProdukt.SelectedIndex + 1;
                temporarySklad.Ilosc = 1;
                temporarySklad.Cena_Netto = 0;
                temporarySklad.Cena_Brutto = 0;
                temporarySklad.Komentarz = null;
                db.Sklad_Zamowienia.Add(temporarySklad);
                db.SaveChanges();
                //Kosztorys
                var query = from p in db.Kosztorys
                            where p.ID_Sklad_Zamowienia == temporarySklad.ID_Sklad_Zamowienia
                            select p;
                foreach (Kosztory p in query)
                {
                    double cena = p.Cena ?? 0.0;
                    txtSugerowanaCenaNetto.Text = Math.Round(cena, 2).ToString("0.00");
                }
                    if (txtSugerowanaCenaNetto.Text == null || txtSugerowanaCenaNetto.Text == "")
                        lblAlert.Visible = true;

                //Usuwanie tymczasowego

                var query2 = from p in db.Sklad_Zamowienia
                             where p.ID_Sklad_Zamowienia == temporarySklad.ID_Sklad_Zamowienia
                             select p;
                foreach (Sklad_Zamowienia p in query2)
                    db.Sklad_Zamowienia.Remove(p);
                db.SaveChanges();
            }
        }
        private void txtCenaNetto_TextChanged(object sender, EventArgs e)
        {

            if (Double.TryParse(txtCenaNetto.Text, out double cenaNetto))
            {
                cenaNetto = double.Parse(txtCenaNetto.Text);
                double cenaBrutto = cenaNetto * 1.23;
                string cenaRounded = cenaBrutto.ToString("0.00");
                txtSugerowanaCenaBrutto.Text = cenaRounded;
            }
            else
            {
                txtCenaNetto.Clear();
                txtSugerowanaCenaBrutto.Clear();
            }
        }
        private void txtCenaBrutto_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(txtCenaBrutto.Text, out double cenaBrutto))
            {
                cenaBrutto = double.Parse(txtCenaBrutto.Text);
                double cenaNetto = cenaBrutto / 1.23;
                string cenaRounded = cenaNetto.ToString("0.00");
                txtSugerowanaCenaNetto.Text = cenaRounded;
            }
            else
            {
                txtCenaNetto.Clear();
                txtSugerowanaCenaBrutto.Clear();
            }
        }
        private void txtCenaNetto_Leave(object sender, EventArgs e)
        {
            if (Double.TryParse(txtCenaNetto.Text, out double cenaNetto))
                txtCenaNetto.Text = Math.Round(cenaNetto, 2).ToString("0.00");
        }
        private void txtCenaBrutto_Leave(object sender, EventArgs e)
        {
            if (Double.TryParse(txtCenaBrutto.Text, out double cenaBrutto))
                txtCenaBrutto.Text = Math.Round(cenaBrutto, 2).ToString("0.00");
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cbProdukt.SelectedIndex >= 0
                && numIlosc.Text != null
                && txtCenaNetto.Text != null && txtCenaNetto.Text != ""
                && txtCenaBrutto.Text != null && txtCenaBrutto.Text != "")
            {
                if (flagEdit)
                {
                    //Edycja
                    Sklad_Zamowienia updateSklad = db.Sklad_Zamowienia.First(p => p.ID_Sklad_Zamowienia == selectedSklad.ID_Sklad_Zamowienia);

                    updateSklad.ID_Produkt = (int)cbProdukt.SelectedValue;
                    updateSklad.Ilosc = (int)numIlosc.Value;
                    updateSklad.Cena_Netto = decimal.Parse(txtCenaNetto.Text);
                    updateSklad.Cena_Brutto = decimal.Parse(txtCenaBrutto.Text);
                    updateSklad.Komentarz = richTxtKomentarz.Text;
                    updateSklad.IloscWyslanychProduktow = 0;

                    db.SaveChanges();
                }
                else
                {
                    //Dodanie nowego składu

                    Sklad_Zamowienia newSklad = new Sklad_Zamowienia();

                    newSklad.ID_Zamowienia_Klienci = selectedZamowienie.ID_Zamowienia_Klienci;
                    newSklad.ID_Produkt = (int)cbProdukt.SelectedValue;
                    newSklad.Ilosc = (int)numIlosc.Value;
                    newSklad.Cena_Netto = decimal.Parse(txtCenaNetto.Text);
                    newSklad.Cena_Brutto = decimal.Parse(txtCenaBrutto.Text);
                    newSklad.IloscWyslanychProduktow = 0;
                    if (richTxtKomentarz.Text != null)
                        newSklad.Komentarz = richTxtKomentarz.Text;
                    else
                        newSklad.Komentarz = null;

                    db.Sklad_Zamowienia.Add(newSklad);
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

        private void btnCopy1_Click(object sender, EventArgs e)
        {
            if (txtSugerowanaCenaNetto.Text != "")
                txtCenaNetto.Text = txtSugerowanaCenaNetto.Text;
        }

        private void btnCopy2_Click(object sender, EventArgs e)
        {
            if (txtSugerowanaCenaBrutto.Text != "")
                txtCenaBrutto.Text = txtSugerowanaCenaBrutto.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
