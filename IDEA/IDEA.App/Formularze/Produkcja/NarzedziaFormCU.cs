using IDEA.App.Formularze.Produkcja;
using IDEA.Database;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Data.Entity.Migrations;

namespace IDEA.App
{
    public partial class NarzedziaFormCU : Form
    {
        private bool flagEdit = false;
        Narzedzia selectedNarzedzia = new Narzedzia();
        IDEAEntities db = IDEADatabase.GetInstance();

        public NarzedziaFormCU()
        {
            InitializeComponent();
            initComboboxes();
            initDatePickers();
           // cbNazwa.SelectedIndex = 1;
        }
        //Wersja Edycja
        public NarzedziaFormCU(Narzedzia _selectedNarzedzia)
        {
            flagEdit = true;
            InitializeComponent();
            initComboboxes();
            initDatePickers();
            selectedNarzedzia = _selectedNarzedzia;
            lblKindWindow.Text = "Edytowanie narzedzi";
            txtNazwa.SelectedIndex = selectedNarzedzia.ID_Rodzaj_Narzedzia-1;
            txtSymbol.Text = selectedNarzedzia.Symbol.ToString();
            //txtOpis.Text = selectedNarzedzia.Opis.ToString();
            dprzychodu.Value = selectedNarzedzia.Data_przychodu;
            //drozchodu.Value = (DateTime)selectedNarzedzia.Data_rozchodu;


        }
        private void initComboboxes()
        {
            var query1 = from rf in db.Rodzaj_Narzedzia
                         select new { rf.ID_Rodzaj_Narzedzia, Nazwa = rf.Nazwa };
            txtNazwa.DataSource = query1.ToList();
            txtNazwa.DisplayMember = "Nazwa";
            txtNazwa.ValueMember = "ID_Rodzaj_Narzedzia";
            txtNazwa.DropDownStyle = ComboBoxStyle.DropDownList;
            //txtNazwa.SelectedIndex = -1;

        }
        private void initDatePickers()
        {
            dprzychodu.CustomFormat = "yyyy-MM-dd";
            dprzychodu.Format = DateTimePickerFormat.Custom;
            dprzychodu.Value = DateTime.Today;

            drozchodu.CustomFormat = "yyyy-MM-dd";
            drozchodu.Format = DateTimePickerFormat.Custom;
            drozchodu.Value = DateTime.Today;
            //drozchodu.Enabled = false;
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {


            //Edycja
            Narzedzia updateNarzedzia = db.Narzedzias.First((p => p.ID_Narzedzia == selectedNarzedzia.ID_Narzedzia));
            updateNarzedzia.ID_Narzedzia = selectedNarzedzia.ID_Narzedzia;
            updateNarzedzia.ID_Rodzaj_Narzedzia = (int)txtNazwa.SelectedValue;
            updateNarzedzia.Symbol = txtSymbol.Text;
            updateNarzedzia.Opis = txtOpis.Text;
            updateNarzedzia.Data_przychodu = dprzychodu.Value;
            updateNarzedzia.Data_rozchodu = drozchodu.Value;
            db.Narzedzias.AddOrUpdate(updateNarzedzia);
            db.SaveChanges();

            
            // //Dodanie nowego klienta
            // V_Kontrola_Jakosci V_Kontrola_JakosciNew = new V_Kontrola_Jakosci();
            // V_Kontrola_JakosciNew.Zaakcpetowane = int.Parse(txtZaakceptowane.Text);
            // V_Kontrola_JakosciNew.Odrzucone = int.Parse(txtOdrzucone.Text);
            //V_Kontrola_JakosciNew.Data_kontroli = DateTime.ParseExact(txtDataKontroli.Text, "dd/MM/yyyy", null);
            // V_Kontrola_JakosciNew.Uwagi = txtUwagi.Text;
            // db.V_Kontrola_Jakosci.Add(V_Kontrola_JakosciNew);
            // //db.SaveChanges();

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtImie_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblKindWindow_Click(object sender, EventArgs e)
        {

        }

        private void lblImie_Click(object sender, EventArgs e)
        {

        }
    }
}
