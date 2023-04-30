using IDEA.Database;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace IDEA.App
{
    public partial class AFSrodkiMajatkoweCU : Form
    {
        private bool flagEdit = false;
        Srodki_Majatkowe selectedSrodkiMajatkowe = new Srodki_Majatkowe();
        IDEAEntities db = IDEADatabase.GetInstance();

        //Wersja Dodawanie
        public AFSrodkiMajatkoweCU()
        {
            InitializeComponent();
            initComboboxes();
            initDatePickers();
        }
        //Wersja Edycja
        public AFSrodkiMajatkoweCU(Srodki_Majatkowe _selectedSrodkiMajatkowe)
        {
            flagEdit = true;
            InitializeComponent();
            initComboboxes();
            initDatePickers();
            selectedSrodkiMajatkowe = _selectedSrodkiMajatkowe;
            lblKindWindow.Text = "Edytowanie Istniejącego Środka Majątkowego";
            txtID_Srodki_Majatkowe.Text = selectedSrodkiMajatkowe.ID_Srodki_Majatkowe.ToString();
            txtNazwa.Text = selectedSrodkiMajatkowe.Nazwa.ToString();
            txtSymbol.Text = selectedSrodkiMajatkowe.Symbol.ToString();
            cbID_Dzialy.SelectedIndex = selectedSrodkiMajatkowe.ID_Dzialy- 1;
            txtKoszt_Zakupu_Netto.Text = selectedSrodkiMajatkowe.Koszt_Zakupu_Netto.ToString();
            txtKoszt_Zakupu_Brutto.Text = selectedSrodkiMajatkowe.Koszt_Zakupu_Brutto.ToString();
          //  cbFaktury_Zakup.SelectedIndex = selectedSrodkiMajatkowe.ID_Faktury_Zakup - 1;
            dData_Przychodu.Value = selectedSrodkiMajatkowe.Data_Przychodu;
            txtPrzychod_Ze_Sprzedazy_Netto.Text = selectedSrodkiMajatkowe.Przychod_Ze_Sprzedazy_Netto.ToString();
            txtPrzychod_Ze_Sprzedazy_Brutto.Text = selectedSrodkiMajatkowe.Przychod_Ze_Sprzedazy_Brutto.ToString();
           // cbFaktury_Sprzedaz.SelectedIndex = selectedSrodkiMajatkowe.ID_Faktury_Sprzedaz - 1;
           // dData_Rozchodu.Value = selectedSrodkiMajatkowe.Data_Rozchodu;

        }

        private void initComboboxes()
        {
            var query1 = from d in db.Dzialies
                         select new { d.ID_Dzialy, ID_Dzialu = d.ID_Dzialy };
            cbID_Dzialy.DataSource = query1.ToList();
            cbID_Dzialy.DisplayMember = "ID_Dzialu";
            cbID_Dzialy.ValueMember = "ID_Dzialy";
            cbID_Dzialy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbID_Dzialy.SelectedIndex = -1;
        }


        private void initDatePickers()
        {
            dData_Przychodu.CustomFormat = "yyyy-MM-dd";
            dData_Przychodu.Format = DateTimePickerFormat.Custom;
            dData_Przychodu.Value = DateTime.Today;
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
    }
}
