using IDEA.App.Formularze.Produkcja;
using IDEA.Database;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App
{
    public partial class ProduktyCUForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagEdit = false;
        Produkt selectedProdukt = new Produkt();

        //---------------------------------------------------------------------------------------------Wersja Dodawanie
        public ProduktyCUForm()
        {
            InitializeComponent();
            initComboboxes();
        }
        //---------------------------------------------------------------------------------------------Wersja Edycja
        public ProduktyCUForm(Produkt _selectedProdukt)
        {
            flagEdit = true;
            InitializeComponent();
            selectedProdukt = _selectedProdukt;
            lblKindWindow.Text = "Edytowanie Istniejącego Produktu";

            initComboboxes();

            cbRodzajProduktu.SelectedIndex = selectedProdukt.ID_Rodzaj_Produktu - 1;
            txtNazwa.Text = selectedProdukt.Nazwa;
            numGlebokosc.Value = (int)selectedProdukt.Glebokosc;
            numSzerokosc.Value = (int)selectedProdukt.Szerokosc;
            numWysokosc.Value=(int)selectedProdukt.Wysokosc;
            numMasa.Value = (int)selectedProdukt.Masa;

        }


        private void initComboboxes()
        {
            var query1 = from p in db.Rodzaj_Produktu
                         select new { p.ID_Rodzaj_Produktu, p.Nazwa};
            cbRodzajProduktu.DataSource = query1.ToList();
            cbRodzajProduktu.DisplayMember = "Nazwa";
            cbRodzajProduktu.ValueMember = "ID_Rodzaj_Produktu";
            cbRodzajProduktu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRodzajProduktu.SelectedIndex = -1;

        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cbRodzajProduktu.SelectedIndex >= 0
                && txtNazwa.Text != null && txtNazwa.Text != "")
            {
                if (flagEdit)
                {
                    //Edycja
                    Produkt updateProdukt = db.Produkts.First(p => p.ID_Produkt == selectedProdukt.ID_Produkt);
                    updateProdukt.ID_Produkt=selectedProdukt.ID_Produkt;
                    updateProdukt.ID_Rodzaj_Produktu = (int)cbRodzajProduktu.SelectedValue;
                    updateProdukt.Nazwa= txtNazwa.Text;
                    updateProdukt.Szerokosc=(double)numSzerokosc.Value;
                    updateProdukt.Glebokosc= (double)numGlebokosc.Value;
                    updateProdukt.Wysokosc= (double)numWysokosc.Value;
                    updateProdukt.Masa = (double)numMasa.Value;



                    db.SaveChanges();
                }
                else
                {
                    //Dodanie nowego zamówienia
                    Produkt newProdukt = new Produkt();
                    newProdukt.ID_Produkt = selectedProdukt.ID_Produkt;
                    newProdukt.ID_Rodzaj_Produktu = (int)cbRodzajProduktu.SelectedValue;
                    newProdukt.Nazwa = txtNazwa.Text;
                    newProdukt.Szerokosc = (double)numSzerokosc.Value;
                    newProdukt.Glebokosc = (double)numGlebokosc.Value;
                    newProdukt.Wysokosc = (double)numWysokosc.Value;
                    newProdukt.Masa = (double)numMasa.Value;
                    db.Produkts.Add(newProdukt);
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




        //---------------------------------------------------------------------------------------------Przesuwanie okna myszą
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


        private void ProduktyCUForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajRodzajProduktu_Click(object sender, EventArgs e)
        {
            
            using (RodzajProduktuForm form1 = new RodzajProduktuForm())
            {
                form1.ShowDialog();
            }
            initComboboxes();
        }
    }
}
