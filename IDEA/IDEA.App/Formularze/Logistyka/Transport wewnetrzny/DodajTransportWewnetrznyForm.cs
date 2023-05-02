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

namespace IDEA.App.Formularze.Logistyka.Transport_wewnetrzny
{
    public partial class DodajTransportWewnetrznyForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        public DodajTransportWewnetrznyForm()
        {
            InitializeComponent();
            initCombobox();
        }
        private void initCombobox()
        {
            var query1 = from p in db.Zlecenie_Magazynowe
                         select new { p.ID_Zlecenie_Magazynowe, Data ="nr" + " "+p.ID_Zlecenie_Magazynowe + "   " + p.Data };
            cb_Zlecenie_magazynowe.DataSource = query1.ToList();
            cb_Zlecenie_magazynowe.DisplayMember = "ID_Zlecenie_Magazynowe";
            cb_Zlecenie_magazynowe.DisplayMember = "Data";
            cb_Zlecenie_magazynowe.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Zlecenie_magazynowe.SelectedIndex = -1;

            var query2 = from p in db.Magazyns
                         select new { p.ID_Magazyn, Data =  p.Nazwa };
            cb_magazyn_poczatkowy.DataSource = query2.ToList();

            cb_magazyn_poczatkowy.DisplayMember = "Data";
            cb_magazyn_poczatkowy.ValueMember = "ID_Magazyn";
            cb_magazyn_poczatkowy.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_magazyn_poczatkowy.SelectedIndex = -1;

            var query3 = from p in db.Magazyns
                         select new { p.ID_Magazyn, Data = p.Nazwa };
            cb_magazyn_koncowy.DataSource = query3.ToList();
            cb_magazyn_koncowy.DisplayMember = "Data";
            cb_magazyn_koncowy.ValueMember = "ID_Magazyn";
            cb_magazyn_koncowy.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_magazyn_koncowy.SelectedIndex = -1;

            var query4 = from p in db.Pracownicies
                         select new { p.ID_Pracownicy, ImieNazwisko = p.Imie + " " + p.Nazwisko };
            cb_pracownik.DataSource = query4.ToList();
            cb_pracownik.DisplayMember = "ImieNazwisko";
            cb_pracownik.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_pracownik.SelectedIndex = -1;

            var query5 = from p in db.Dostepne_Pojazdy
                         select new { p.ID_Pojazd, Model = p.Marka + " " + p.Model + " " + p.Numer_rejestracyjny };
            cb_pojazd.DataSource = query5.ToList();
            cb_pojazd.DisplayMember = "Model";
            cb_pojazd.ValueMember = "ID_Pojazd";
            cb_pojazd.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_pojazd.SelectedIndex = -1;
        }
        private void panelMove_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cb_Zlecenie_magazynowe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_magazyn_poczatkowy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_magazyn_koncowy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_pracownik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_pojazd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
