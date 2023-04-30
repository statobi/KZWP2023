using IDEA.Database;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Produkcja
{
    public partial class EksploatacjaMaszynForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();

        public EksploatacjaMaszynForm()
        {
            InitializeComponent();
            initOpcjeParametrMaszyny();
            initOpcjeRodzajStrategiiEksploatacji();
            //initDgvEksploatacja_PP();
            // initDgvEksploatacja_ST();
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






        private void initOpcjeParametrMaszyny()
        {
            var ParametrMaszyny = db.Parametr_Maszyny
                .Select(s => s.Nazwa_Parametru).ToList();
            cbParametrMaszyny.DataSource = ParametrMaszyny;
            cbParametrMaszyny.DropDownStyle = ComboBoxStyle.DropDownList;
            cbParametrMaszyny.SelectedIndex = -1;
        }

        private void cbRodzajStrategiiEksploatacji_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRodzajStrategiiEksploatacji.Text == "Strategia eksploatacji według planowanej profilaktyki")
            {
                dgvEksploatacjaMaszyn.DataSource = db.Widok_Model_Stategia_PP.ToList();
                dgvEksploatacjaMaszyn.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }
            else if (cbRodzajStrategiiEksploatacji.Text == "Strategia eksploatacji według stanu technicznego")
            {
                dgvEksploatacjaMaszyn.DataSource = db.Widok_Model_Strategia_ST.ToList();
                dgvEksploatacjaMaszyn.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else
            {
                //MessageBox.Show("test");
            }

        }
    }
}
