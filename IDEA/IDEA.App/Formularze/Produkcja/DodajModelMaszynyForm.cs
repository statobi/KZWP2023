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

namespace IDEA.App.Formularze.Produkcja
{
    public partial class DodajModelMaszynyForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        public DodajModelMaszynyForm()
        {
            InitializeComponent();
            initDgwModelMaszyny();
        }


        private void initDgwModelMaszyny()
        {
            dgvModelMaszyny.DataSource = db.Model_Maszyny.ToList();
            this.dgvModelMaszyny.Columns["Rodzaj_Strategii_Eksp"].Visible = false;
            dgvModelMaszyny.Columns["Marka"].Visible=false;
            dgvModelMaszyny.Columns["ID_Rodzaj_Strategii_Eksp"].Visible =false;
            dgvModelMaszyny.Columns["Normy_Eksploatacyjne"].Visible = false;
            dgvModelMaszyny.Columns["Maszynies"].Visible = false;
            dgvModelMaszyny.Columns["Rodzaj_Maszyny"].Visible = false;
            dgvModelMaszyny.Columns["Parametr_Maszyny"].Visible = false;
            dgvModelMaszyny.Columns["ID_Rodzaj_Maszyny"].Visible = false;
            dgvModelMaszyny.Columns["Koszt_Roboczogodziny"].Visible = false;
            dgvModelMaszyny.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void DodanieModeluMaszyny()
        {
            Model_Maszyny ModelMaszynyNew = new Model_Maszyny();
           ModelMaszynyNew.Model = txtModelMaszyny.Text;
            db.Model_Maszyny.Add(ModelMaszynyNew);
            db.SaveChanges();
            dgvModelMaszyny.Update();
            dgvModelMaszyny.Refresh();
           initDgwModelMaszyny();
        }
        private void DodajModelMaszynyForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DodanieModeluMaszyny();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
