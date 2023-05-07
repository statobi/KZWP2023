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
using System.Windows.Markup;

namespace IDEA.App.Formularze.Logistyka.Pojazdy
{
    public partial class DodajUbezpieczenieForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();

        public DodajUbezpieczenieForm()
        {
            InitializeComponent();
            initCombobox();
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void initCombobox()
        {
            var query2 = from p in db.Ubezpieczyciels
                         select new { p.ID_Ubezpieczyciel, Data = p.NazwaFirmy };
            cb_ubezpieczyciel.DataSource = query2.ToList();

            cb_ubezpieczyciel.DisplayMember = "Data";
            cb_ubezpieczyciel.ValueMember = "ID_Ubezpieczyciel";
            cb_ubezpieczyciel.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_ubezpieczyciel.SelectedIndex = -1;


            var query4 = from p in db.RodzajUbezpieczenias
                         select new { p.ID_RodzajUbezpieczenia, RUbezp = p.Nazwa };
            cb_rodzajUbezpieczenia.DataSource = query4.ToList();
            cb_rodzajUbezpieczenia.ValueMember = "ID_RodzajUbezpieczenia";
            cb_rodzajUbezpieczenia.DisplayMember = "RUbezp";
            cb_rodzajUbezpieczenia.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_rodzajUbezpieczenia.SelectedIndex = -1;

            var query5 = from p in db.Pojazds
                         join d in db.ModelePojazdus on p.ID_ModelPojazd equals d.ID_ModelPojazd
                         select new { p.ID_Pojazd, Model = d.Marka + " " + d.Model + " " + p.NrRejestracyjny };
            cb_Pojazd.DataSource = query5.ToList();
            cb_Pojazd.DisplayMember = "Model";
            cb_Pojazd.ValueMember = "ID_Pojazd";
            cb_Pojazd.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Pojazd.SelectedIndex = -1;
        }

        private void btn_dodaj_ubezpieczenie_Click(object sender, EventArgs e)
        {
            Ubezpieczenie noweUbezpieczenie = new Ubezpieczenie();
            if (cb_Pojazd.SelectedValue == null || !int.TryParse(cb_Pojazd.SelectedValue.ToString(), out int pojazdID))
            {
                MessageBox.Show("Nie wybrano ubezpieczenia!");
                return;
            }
            if (cb_ubezpieczyciel.SelectedValue == null || !int.TryParse(cb_ubezpieczyciel.SelectedValue.ToString(), out int ubezpID))
            {
                MessageBox.Show("Nie wybrano ubezpieczyciela!");
                return;
            }
            if (cb_rodzajUbezpieczenia.SelectedValue == null || !int.TryParse(cb_rodzajUbezpieczenia.SelectedValue.ToString(), out int rodzajID))
            {
                MessageBox.Show("Nie wybrano pojazdu!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtKosztNetto?.Text) || string.IsNullOrWhiteSpace(txt_kosztBrutto?.Text))
            {
                MessageBox.Show("Nie wpisano wartości kosztu!");
                return;
            }

            noweUbezpieczenie.KosztNetto = int.Parse(txtKosztNetto.Text);
            noweUbezpieczenie.KosztBrutto = int.Parse(txt_kosztBrutto.Text);

            noweUbezpieczenie.ID_RodzajUbezpieczenia = rodzajID;
            noweUbezpieczenie.ID_Ubezpieczyciel = ubezpID;
            noweUbezpieczenie.ID_Pojazd = pojazdID;


            noweUbezpieczenie.ID_Ubezpieczyciel = (int)cb_ubezpieczyciel.SelectedValue;
            noweUbezpieczenie.ID_Pojazd = (int)cb_Pojazd.SelectedValue;
            noweUbezpieczenie.ID_RodzajUbezpieczenia = (int)cb_rodzajUbezpieczenia.SelectedValue;
            noweUbezpieczenie.KosztBrutto = int.Parse(txt_kosztBrutto.Text);
            noweUbezpieczenie.KosztNetto = int.Parse(txtKosztNetto.Text);           
            noweUbezpieczenie.DataDo = dataWaznosciUbezpieczenia.Value;
            noweUbezpieczenie.DataOd = dDataZakupuUbezpieczenia.Value;
            db.Ubezpieczenies.Add(noweUbezpieczenie);
            db.SaveChanges();
            MessageBox.Show("Pomyślnie dodano ubezpieczenie!");
            this.Close();
        }

        private void cb_Pojazd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
