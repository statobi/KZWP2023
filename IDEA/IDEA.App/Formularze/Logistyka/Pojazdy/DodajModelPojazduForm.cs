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
    public partial class DodajModelPojazduForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        public DodajModelPojazduForm()
        {
            InitializeComponent();
            initCombobox();
        }
        private void initCombobox()
        {
            var query2 = from p in db.RodzajPojazdus
                         select new { p.ID_RodzajPojazdu, Data = p.Nazwa };
            cb_RodzajPojazdu.DataSource = query2.ToList();

            cb_RodzajPojazdu.DisplayMember = "Data";
            cb_RodzajPojazdu.ValueMember = "ID_RodzajPojazdu";
            cb_RodzajPojazdu.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_RodzajPojazdu.SelectedIndex = -1;
        }


        private void btn_dodaj_modelPojazd_Click(object sender, EventArgs e)
        {
            ModelePojazdu nowyModelPojazdu = new ModelePojazdu();
            nowyModelPojazdu.Marka = txt_marka.Text;
            nowyModelPojazdu.Model = txt_model.Text;
            nowyModelPojazdu.ID_RodzajPojazdu = (int)cb_RodzajPojazdu.SelectedValue;
            if (int.TryParse(txt_nosnosc.Text, out int nosnoscPojazdu))
            {
                nowyModelPojazdu.Nosnosc = nosnoscPojazdu;
            }
            else
            {
            }
            if (int.TryParse(txtPojemnoscSilnika.Text, out int pojsil))
            {
                nowyModelPojazdu.PojemnoscSilnika = pojsil;
            }
            else
            {
            }
            if (int.TryParse(txt_wysokosc.Text, out int w))
            {
                nowyModelPojazdu.Wysokosc = w;
            }
            else
            {
            }
            if (int.TryParse(txt_glebokosc.Text, out int g))
            {
                nowyModelPojazdu.Glebokosc = g;
            }
            else
            {
            }
            if (int.TryParse(txt_szerokosc.Text, out int s))
            {
                nowyModelPojazdu.Szerokosc = s;
            }
            else
            {
            }
            db.ModelePojazdus.Add(nowyModelPojazdu);
            MessageBox.Show("Pomyślnie dodano nowy model!");
            db.SaveChanges();
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
