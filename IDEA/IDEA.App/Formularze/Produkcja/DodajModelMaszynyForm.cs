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
            initOpcjeParametrMaszyny();
            initOpcjeRodzajStrategiiEksploatacji();
        }


        private void initDgwModelMaszyny()
        {
            dgvModelMaszyny.DataSource = db.ModelMaszyny_Parametry.ToList();
            dgvModelMaszyny.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void initOpcjeParametrMaszyny()
        {
            var ParametrMaszyny = db.Parametr_Maszyny
                .Select(s => s.Nazwa_Parametru).ToList();
           cbParametrMaszyny.DataSource = ParametrMaszyny;
           cbParametrMaszyny.DropDownStyle = ComboBoxStyle.DropDownList;
           cbParametrMaszyny.SelectedIndex = -1;
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

        private void initOpcjeRodzajStrategiiEksploatacji()
        {
            {
                var RodzajeStrategiiEksploatacji = db.Rodzaj_Strategii_Eksp
                        .Select(s => s.Nazwa).ToList();
                cbRodzajStrategiiEksploatacji.DataSource = RodzajeStrategiiEksploatacji;
                cbRodzajStrategiiEksploatacji.DropDownStyle = ComboBoxStyle.DropDownList;
                cbRodzajStrategiiEksploatacji.SelectedIndex = -1;
            }
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

        private void dgvModelMaszyny_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
