using IDEA.Database;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Produkcja
{
    public partial class DodajModelMaszynyForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        Model_Maszyny DodanyRodzaj = new Model_Maszyny();
        public DodajModelMaszynyForm()
        {
            InitializeComponent();
            initDgwModelMaszyny();
            initOpcjeParametrMaszyny();
            initOpcjeRodzajStrategiiEksploatacji();
            initOpcjeRodzajMaszyny();

        }

        private void initOpcjeRodzajMaszyny()
        {
            var RodzajeMaszyn = db.Rodzaj_Maszyny
            .Select(x => new { x.ID_Rodzaj_Maszyny, x.Nazwa }).ToList();
            cbRodzajMaszyny.DataSource = RodzajeMaszyn;
            cbRodzajMaszyny.ValueMember = "ID_Rodzaj_Maszyny";
            cbRodzajMaszyny.DisplayMember = "Nazwa";
            cbRodzajMaszyny.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRodzajMaszyny.SelectedIndex = -1;
        }
        private void initDgwModelMaszyny()
        {
            dgvModelMaszyny.DataSource = db.V_Dodawanie_Modelu.ToList();
            dgvModelMaszyny.Columns["ID_Model_Maszyny"].Visible = false;
            dgvModelMaszyny.Columns["ID_Rodzaj_Maszyny"].Visible = false;
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
        private void initOpcjeRodzajStrategiiEksploatacji()

        {
            var RodzajeStrategiiEksploatacji = db.Rodzaj_Strategii_Eksp
                    .Select(s => new { s.ID_Rodzaj_Strategii_Eksp, s.Nazwa }).ToList();
            cbRodzajStrategiiEksploatacji.DataSource = RodzajeStrategiiEksploatacji;
            cbRodzajStrategiiEksploatacji.ValueMember = "ID_Rodzaj_Strategii_Eksp";
            cbRodzajStrategiiEksploatacji.DisplayMember = "Nazwa";
            cbRodzajStrategiiEksploatacji.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRodzajStrategiiEksploatacji.SelectedIndex = -1;
        }

        private void DodanieModeluMaszyny()
        {
            if (txtModelMaszyny.Text != null && txtModelMaszyny.Text != "")
            {
                //Dodanie nowego modelu
                Model_Maszyny ModelMaszynyNew = new Model_Maszyny();
                ModelMaszynyNew.Marka = txtMarkaMaszyny.Text;
                ModelMaszynyNew.Model = txtModelMaszyny.Text;
                ModelMaszynyNew.ID_Rodzaj_Strategii_Eksp = int.Parse(cbRodzajStrategiiEksploatacji.SelectedValue.ToString());
                ModelMaszynyNew.ID_Rodzaj_Maszyny = int.Parse(cbRodzajMaszyny.SelectedValue.ToString());
                ModelMaszynyNew.Koszt_Roboczogodziny = int.Parse(txtKosztRob.Text);

                db.Model_Maszyny.Add(ModelMaszynyNew);
                db.SaveChanges();
                dgvModelMaszyny.Update();
                dgvModelMaszyny.Refresh();
                initDgwModelMaszyny();

            }
            else
                MessageBox.Show("Nie wprowadzono wymaganych danych!");
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
        private void iBtnDelete_Click(object sender, EventArgs e)
        {
            usuwanie();
            initDgwModelMaszyny();
            //flagSelected = false;


        }


        private void usuwanie()
        {

            // if (flagSelected == true)
            //{
            var model = from p in db.Model_Maszyny
                          where p.ID_Model_Maszyny == DodanyRodzaj.ID_Model_Maszyny
                          select p;
            foreach (Model_Maszyny p in model)
                db.Model_Maszyny.Remove(p);
            db.SaveChanges();
            initDgwModelMaszyny();
            flagSelected = false;
            //}
        }
    }
}
