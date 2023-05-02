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
        //private bool flagaStanTechniczny = false;

        private void EksploatacjaMaszynForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Wybierz rodzaj strategii eksploatacji maszyn");
        }
        public EksploatacjaMaszynForm()
        {
            
            InitializeComponent();
            initOpcjeParametrMaszyny();
            initOpcjeSymbolMaszyny();
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


        private void initOpcjeSymbolMaszyny()
        {
            var SymbolMaszyny = db.Maszynies
                .Select(s => s.Symbol).ToList();
            cbSymbolMaszyny.DataSource = SymbolMaszyny;
            cbSymbolMaszyny.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSymbolMaszyny.SelectedIndex = -1;
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
                groupBox1.Refresh();
                groupBox2.Refresh();
                groupBox1.Visible = true;
                groupBox2.Visible = false;

            }
            else if (cbRodzajStrategiiEksploatacji.Text == "Strategia eksploatacji według stanu technicznego")
            {
                dgvEksploatacjaMaszyn.DataSource = db.Widok_Model_Strategia_ST.ToList();
                dgvEksploatacjaMaszyn.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                groupBox1.Refresh();
                groupBox2.Refresh();

                groupBox1.Visible = false ; groupBox2.Visible = true;
                


            }
            else
            {

               
                groupBox2.Visible = false; groupBox1.Visible = true;
                groupBox1.Visible = false;
                groupBox1.Refresh();
                groupBox2.Refresh();
            }


        }
        private void DodanieEksploatacji_ST()
        {
            //if (txtModelMaszyny.Text != null && txtModelMaszyny.Text != "")
            {
                //Dodanie nowej ekspoatacji
                Parametr_Maszyny PMaszynyNew = new Parametr_Maszyny();
                //PMaszynyNew.Marka = int.Parse(cbSymbolMaszyny.SelectedValue.ToString());
                PMaszynyNew.Nazwa_Parametru = cbParametrMaszyny.Text;
                PMaszynyNew.Dolna_Granica = int.Parse(txtMinP.Text);
                PMaszynyNew.Gorna_Granica = int.Parse(txtMaxP.Text);

                db.Parametr_Maszyny.Add(PMaszynyNew);
                db.SaveChanges();
                dgvEksploatacjaMaszyn.Update();
                dgvEksploatacjaMaszyn.Refresh();
                initOpcjeParametrMaszyny();

                Badany_Parametr BadanyPMaszynyNew = new Badany_Parametr();
                BadanyPMaszynyNew.Wartosc = int.Parse(txtZbadana.Text);
                
                db.Badany_Parametr.Add(BadanyPMaszynyNew);
                db.SaveChanges();
                dgvEksploatacjaMaszyn.Update();
                dgvEksploatacjaMaszyn.Refresh();
                initOpcjeParametrMaszyny();

            }
           // else
                MessageBox.Show("Nie wprowadzono wymaganych danych!");
        }

        private void iBtnNew_Click(object sender, EventArgs e)
        {
            DodanieEksploatacji_ST();
        }

        private void btnPrzekroczeniaParametru_Click(object sender, EventArgs e)
        {
            //int max = 1500; 
            //int min = 0;
            //float parametr = 5000;
            //float granica = 3000;
            IDEA.Produkcja.PrognozowanieParametru prognoza = new IDEA.Produkcja.PrognozowanieParametru();



            //MessageBox.Show("Parametr zostanie przekroczony za " + prognoza.Prognozowanie(parametr, granica,min,max).ToString() + "dni");

            double[] x = { 10.0, 9.5, 8.8 };
            DateTime[] y = { new DateTime(2022, 4, 1), new DateTime(2022, 4, 5), new DateTime(2022, 5, 02) };
            double granica = 6.0;

            
            MessageBox.Show("Data spadku: " + prognoza.Prognozowanie(x, y, granica).ToString());

        }
    }
}
