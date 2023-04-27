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

            initOpcjeRodzajStrategiiEksploatacji();
            initOpcjeRodzajMaszyny();
        }


        private void initDgwModelMaszyny()
        {
            dgvModelMaszyny.DataSource = db.ModelMaszyny_Parametry.ToList();
            dgvModelMaszyny.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }


        private void DodanieModeluMaszyny()
        {
            //Model_Maszyny ModelMaszynyNew = new Model_Maszyny();
            ////ModelMaszynyNew.ID_Rodzaj_Strategii_Eksp = int.Parse(cbRodzajStrategiiEksploatacji.Text);
            //ModelMaszynyNew.Model = txtModelMaszyny.Text;
            //ModelMaszynyNew.Marka = txtMarkaMaszyny.Text;
            ////ModelMaszynyNew.Rodzaj_Maszyny = cbRodzajMaszyny.Text;
            //ModelMaszynyNew.Koszt_Roboczogodziny = int.Parse(txtKosztRoboczogodziny.Text);
            //db.Model_Maszyny.Add(ModelMaszynyNew);
            //db.SaveChanges();
            //dgvModelMaszyny.Update();
            //dgvModelMaszyny.Refresh();
            //initDgwModelMaszyny();
        }


        private void initOpcjeRodzajMaszyny()
        {
            var RodzajMaszyny = db.Rodzaj_Maszyny
                .Select(rm => new { rm.ID_Rodzaj_Maszyny, rm.Nazwa }).ToList();
            cbRodzajMaszyny.DataSource = RodzajMaszyny;
            cbRodzajMaszyny.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRodzajMaszyny.SelectedIndex = -1;

        }
        private void initOpcjeRodzajStrategiiEksploatacji()
        {
            {
                var RodzajeStrategiiEksploatacji = db.Rodzaj_Strategii_Eksp
                        .Select(s =>new { s.ID_Rodzaj_Strategii_Eksp, s.Nazwa }).ToList();
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

        private void cbRodzajStrategiiEksploatacji_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
