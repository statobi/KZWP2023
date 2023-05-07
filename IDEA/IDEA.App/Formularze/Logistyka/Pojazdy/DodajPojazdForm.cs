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
    public partial class DodajPojazdForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        public DodajPojazdForm()
        {
            InitializeComponent();
            initCombobox();
            

        }
        private void initCombobox()
        {
            var query2 = from p in db.ModelePojazdus
                         select new { p.ID_ModelPojazd, Data = p.Marka + " " + p.Model };
            cb_ModelPojazdu.DataSource = query2.ToList();

            cb_ModelPojazdu.DisplayMember = "Data";
            cb_ModelPojazdu.ValueMember = "ID_ModelPojazd";
            cb_ModelPojazdu.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_ModelPojazdu.SelectedIndex = -1;
        }
        private void btn_dodaj_pojazd_Click(object sender, EventArgs e)
        {
            Pojazd nowyPojazd = new Pojazd();
            

            nowyPojazd.NrRejestracyjny = txt_nr_rejestracyjny.Text;
            if (int.TryParse(txt_stanLicznika.Text, out int stanLicznika))
            {
                nowyPojazd.StanLicznikaPoczatkowy = stanLicznika;
            }
            else
            {
                MessageBox.Show("Nieprawidłowa wartość stanu licznika początkowego!");
                return;
            }
            nowyPojazd.RokProdukcji = dRokProdukcji.Value;
            nowyPojazd.DataPrzychodu = dDataPrzychodu.Value;
            if (cbx_aktywuj_date_rozchodu.Checked)
            {
                nowyPojazd.DataRozchodu = dDataRozchodu.Value;
            }
            else
                nowyPojazd.DataRozchodu = null;
            nowyPojazd.ID_ModelPojazd = (int)cb_ModelPojazdu.SelectedValue;




            db.Pojazds.Add(nowyPojazd);
            db.SaveChanges();
            MessageBox.Show("Pomyślnie dodano nowy pojazd!");
            this.Close();
        }

        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_nowy_model_Click(object sender, EventArgs e)
        {
            using (DodajModelPojazduForm Pr = new DodajModelPojazduForm())
            {
                Pr.ShowDialog();
                initCombobox();
                
            }
        }


        private void cbx_aktywuj_date_rozchodu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_aktywuj_date_rozchodu.Checked)
            {
                dDataRozchodu.Enabled = true;
            }
            else
            {
                dDataRozchodu.Enabled = false;
            }
        }
    }
}
