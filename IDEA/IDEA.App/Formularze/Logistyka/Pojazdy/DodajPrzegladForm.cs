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

namespace IDEA.App.Formularze.Logistyka.Pojazdy
{
    public partial class DodajPrzegladForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        public DodajPrzegladForm()
        {
            InitializeComponent();
            initCombobox();
        }
        private void initCombobox()
        {
            var query2 = from p in db.Pojazds
                         join d in db.ModelePojazdus on p.ID_ModelPojazd equals d.ID_ModelPojazd
                         select new { p.ID_Pojazd, Data = d.Marka + " " + d.Model + " " + p.NrRejestracyjny};
            cb_Pojazd.DataSource = query2.ToList();
            cb_Pojazd.DisplayMember = "Data";
            cb_Pojazd.ValueMember = "ID_Pojazd";
            cb_Pojazd.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Pojazd.SelectedIndex = -1;
        }
        private void btn_dodaj_przeglad_Click(object sender, EventArgs e)
        {
            PrzegladPojazdu nowyPrzeglad = new PrzegladPojazdu();
            nowyPrzeglad.ID_Pojazd = (int)cb_Pojazd.SelectedValue;
            nowyPrzeglad.KosztBrutto = int.Parse(txt_kosztBrutto.Text);
            nowyPrzeglad.KosztNetto = int.Parse(txt_KosztNetto.Text);
            nowyPrzeglad.Data = dWykonaniaPrzegladu.Value;
            nowyPrzeglad.DataDoP = dDataWaznosci.Value;
            if (string.IsNullOrWhiteSpace(txt_KosztNetto?.Text) || string.IsNullOrWhiteSpace(txt_kosztBrutto?.Text))
            {
                MessageBox.Show("Nie wpisano wartości kosztu!");
                return;
            }
            db.PrzegladPojazdus.Add(nowyPrzeglad);
            db.SaveChanges();
            MessageBox.Show("Pomyślnie dodano przegląd techniczny!");
            this.Close();

        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
