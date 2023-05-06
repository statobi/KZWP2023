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
            //initDgvEksploatacja_ST();
            initOpcjeNorma();
            initOpcjeSymbol();
            initOpcjeSymbol_PP();
            initWyborPracownicy();
            initOpcjeRodzajObslugi();




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

        private void initWyborPracownicy()
        {

            var WyborPracownika = db.V_Operatorzy_Maszyn
                    .Select(s => s.Nazwisko).ToList();
            cbPracownik.DataSource = WyborPracownika;
            cbModelMaszyny.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPracownik.SelectedIndex = -1;
        }

        private void initOpcjeSymbolMaszyny()
        {
            var ModelMaszyny = db.Model_Maszyny
                .Select(s => s.Model).ToList();
            cbModelMaszyny.DataSource = ModelMaszyny;
            cbModelMaszyny.DropDownStyle = ComboBoxStyle.DropDownList;
            cbModelMaszyny.SelectedIndex = -1;
        }
        private void initOpcjeRodzajObslugi()
        {
            var RodzajObslugi = db.Rodzaj_Obslugi_Maszyny
                .Select(s => s.Nazwa).ToList();
            cbRodzajObslugi.DataSource = RodzajObslugi;
            cbRodzajObslugi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRodzajObslugi.SelectedIndex = -1;
        }


        private void initOpcjeParametrMaszyny()
        {
            var ParametrMaszyny = db.Parametr_Maszyny
                .Select(s => s.Nazwa_Parametru).ToList();
            cbParametrMaszyny.DataSource = ParametrMaszyny;
            cbParametrMaszyny.DropDownStyle = ComboBoxStyle.DropDownList;
            cbParametrMaszyny.SelectedIndex = -1;
        }

        private void initOpcjeNorma()
        {
            var NormyEksploatacyjne = db.Normy_Eksploatacyjne
                .Select(s => s.Nr_Normy).ToList();
            cbNormy.DataSource = NormyEksploatacyjne;
            cbNormy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNormy.SelectedIndex = -1;
        }

        private void initOpcjeSymbol()
        {
            var SymbolMaszyny = db.Maszynies
                .Select(s => s.Symbol).ToList();
            cbSymbolMaszyny.DataSource = SymbolMaszyny;
            cbSymbolMaszyny.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSymbolMaszyny.SelectedIndex = -1;
        }

        private void initOpcjeSymbol_PP()
        {
            var SymbolMaszyny = db.Model_Maszyny
                .Select(s => s.Model).ToList();
            cbSymbol.DataSource = SymbolMaszyny;
            cbSymbol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSymbol.SelectedIndex = -1;
        }

        private void cbSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            LadowanieParametruProcesu_PP();

        }
        private void LadowanieParametruProcesu_PP()
        {
            var IDmodelmaszyny = db.Maszynies
                .Where(x => x.Symbol == cbSymbol.Text)
                .Select(x => x.ID_Model_Maszyny)
                .FirstOrDefault();

        }
            private void cbRodzajStrategiiEksploatacji_SelectedIndexChanged(object sender, EventArgs e)
        {
            initDVGE();
        }

        private void DodanieEksploatacji_ST()
        {

            //if (txtModelMaszyny.Text != null && txtModelMaszyny.Text != "")
            {
                //Dodanie nowej ekspoatacji

                Parametr_Maszyny PMaszynyNew = new Parametr_Maszyny();
                //PMaszynyNew.Marka = int.Parse(cbSymbolMaszyny.SelectedValue.ToString());
                // dodawanie ID Maszyny
                //string WybranaMaszyna = cb.Text;
                // var IDMaszyny = db.Model_Maszyny
                //.Where(x => x.Symbol == WybranaMaszyna)
                // .Select(x => x.ID_Maszyny)
                //.FirstOrDefault();

                //NowyProces.ID_Maszyny = IDMaszyny;


                //PMaszynyNew.Nazwa_Parametru = cbParametrMaszyny.Text;
                //PMaszynyNew.Dolna_Granica = int.Parse(txtMinP.Text);
                //PMaszynyNew.Gorna_Granica = int.Parse(txtMaxP.Text);

                //db.Parametr_Maszyny.Add(PMaszynyNew);
                // db.SaveChanges();
                // dgvEksploatacjaMaszyn.Update();
                //dgvEksploatacjaMaszyn.Refresh();
                //initOpcjeParametrMaszyny();

                Badany_Parametr BadanyPMaszynyNew = new Badany_Parametr();
                BadanyPMaszynyNew.Wartosc = int.Parse(txtZbadana.Text);

                db.Badany_Parametr.Add(BadanyPMaszynyNew);
                db.SaveChanges();
                dgvEksploatacjaMaszyn.Update();
                dgvEksploatacjaMaszyn.Refresh();
                //initOpcjeParametrMaszyny();

                Badanie_Maszyny BadaniePMaszynyNew = new Badanie_Maszyny();
                BadaniePMaszynyNew.Data = dtpDataBadania.Value;



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

        private void iBtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void DodawanieNowejNormy()
        {
            Normy_Eksploatacyjne NEksplNew = new Normy_Eksploatacyjne();
            string Maszyna = cbSymbol.Text;
            var ID_ModelMaszyny = db.Model_Maszyny
                .Where(x => x.Model == Maszyna)
                .Select(x => x.ID_Model_Maszyny)
                .FirstOrDefault();
            NEksplNew.ID_Model_Maszyny = ID_ModelMaszyny;
            NEksplNew.Nr_Normy = txtNowaNorma.Text;

            db.Normy_Eksploatacyjne.Add(NEksplNew);
            db.SaveChanges();
            dgvEksploatacjaMaszyn.Update();
            dgvEksploatacjaMaszyn.Refresh();
            MessageBox.Show("Dodano nową normę");
            initDVGE();

        }

        private void btnDodajNorme_Click(object sender, EventArgs e)
        {
            DodawanieNowejNormy();

        }

        private void btnDodajParametr_Click(object sender, EventArgs e)
        {
            DodawanieNowegoParametru();

        }
        private void DodawanieNowegoParametru()
        {
            Parametr_Maszyny PMaszynyNew = new Parametr_Maszyny();
            // dodawanie ID Maszyny
            string WybranaMaszyna = cbModelMaszyny.Text;
            var ID_ModelMaszyny = db.Model_Maszyny
           .Where(x => x.Model == WybranaMaszyna)
            .Select(x => x.ID_Model_Maszyny)
           .FirstOrDefault();

            PMaszynyNew.ID_Model_Maszyny = ID_ModelMaszyny;

            PMaszynyNew.Nazwa_Parametru = txtParametrMaszyny.Text;
            PMaszynyNew.Dolna_Granica = int.Parse(txtMinP.Text);
            PMaszynyNew.Gorna_Granica = int.Parse(txtMaxP.Text);
            PMaszynyNew.Wartosc_Nominalna = int.Parse(txtZbadana.Text);

            db.Parametr_Maszyny.Add(PMaszynyNew);
            db.SaveChanges();
            dgvEksploatacjaMaszyn.Update();
            dgvEksploatacjaMaszyn.Refresh();
            initDVGE();

        }

        private void DodawanieNowejObslugi()
        {

            Rodzaj_Obslugi_Maszyny NowyRodzajObslugi = new Rodzaj_Obslugi_Maszyny();
            NowyRodzajObslugi.Nazwa = txtNowaObsluga.Text;
            db.Rodzaj_Obslugi_Maszyny.Add(NowyRodzajObslugi);
            db.SaveChanges();
            //dgv .Update();
            //dgv .Refresh();
            MessageBox.Show("Dodano rodzaj obslugi");
            //initOpcjeParametrMaszyny();
            //initDVGE();

        }


        private void DodawanieNowegoBadania()
        {
            Badanie_Maszyny BadanieMaszynyNew = new Badanie_Maszyny();

            string Symbolmaszyna = cbSymbolMaszyny.Text;
            var IDmaszyny = db.Maszynies
                .Where(x => x.Symbol == Symbolmaszyna)
                .Select(x => x.ID_Maszyny)
                .FirstOrDefault();
            BadanieMaszynyNew.ID_Maszyny = IDmaszyny;

            string NazwiskoPracownika = cbPracownik.Text;
            var BadaniePracownik = db.Pracownicies
                .Where(x => x.Nazwisko == NazwiskoPracownika)
                .Select(x => x.ID_Pracownicy)
                .FirstOrDefault();
            BadanieMaszynyNew.ID_Pracownicy = BadaniePracownik;

            string ParametrMaszyny = cbParametrMaszyny.Text;
            var IDparametrmaszyny = db.Parametr_Maszyny
                .Where(x => x.Nazwa_Parametru == ParametrMaszyny)
                .Select(x => x.ID_Parametr_Maszyny)
                .FirstOrDefault();
            //BadanieMaszynyNew.
            BadanieMaszynyNew.Data = dtpDataBadania.Value;
            BadanieMaszynyNew.Opis = "brak";

            db.Badanie_Maszyny.Add(BadanieMaszynyNew);

            Badany_Parametr BadanyParametrNew = new Badany_Parametr();
            BadanyParametrNew.ID_Badanie = BadanieMaszynyNew.ID_Badanie;
            BadanyParametrNew.ID_Parametr_Maszyny = IDparametrmaszyny;
            BadanyParametrNew.Wartosc = int.Parse(txtWartosc.Text);

           db.Badany_Parametr.Add(BadanyParametrNew);
            db.SaveChanges();
            dgvEksploatacjaMaszyn.Update();
            dgvEksploatacjaMaszyn.Refresh();
            MessageBox.Show("Dodano");
            initOpcjeParametrMaszyny();
            initDVGE();
            //BadanieMaszynyNew.ID_Parametr_Maszyny = BadaniePracownik;

        }

        private void cbSymbolMaszyny_SelectedIndexChanged(object sender, EventArgs e)
        {
            LadowanieParametruProcesu();

        }
        private void LadowanieParametruProcesu()
        {
            var IDmodelmaszyny = db.Maszynies
                .Where(x => x.Symbol == cbSymbolMaszyny.Text)
                .Select(x => x.ID_Model_Maszyny)
                .FirstOrDefault();


            var WyborProcesow = db.Parametr_Maszyny
                .Where(x => x.ID_Model_Maszyny == IDmodelmaszyny)
                .Select(x => x.Nazwa_Parametru)
                .ToList();
            cbParametrMaszyny.DataSource = WyborProcesow;

        }

        private void btnDodajBadanie_Click(object sender, EventArgs e)
        {
            DodawanieNowegoBadania();
            dgvEksploatacjaMaszyn.Update();
            dgvEksploatacjaMaszyn.Refresh();
            initOpcjeParametrMaszyny();

        }
        private void initDVGE()
        {
            if (cbRodzajStrategiiEksploatacji.Text == "Strategia eksploatacji według planowanej profilaktyki")
            {
                //dgvEksploatacjaMaszyn.Size = new Size(100, 50);
                dgvEksploatacjaMaszyn.DataSource = db.Widok_Model_Stategia_PP.ToList();
                dgvObslugi.DataSource = db.RodzajObsl_Model.ToList();
                this.dgvObslugi.Columns["ID_Obslugi"].Visible = false;
                dgvObslugi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvEksploatacjaMaszyn.Width=510;
                dgvEksploatacjaMaszyn.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                groupBox1.Refresh();
                groupBox2.Refresh();
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                dgvEksploatacjaMaszyn.Update();
                dgvEksploatacjaMaszyn.Refresh();

            }
            else if (cbRodzajStrategiiEksploatacji.Text == "Strategia eksploatacji według stanu technicznego")
            {
                dgvEksploatacjaMaszyn.DataSource = db.Widok_Model_Strategia_ST.ToList();
                dgvEksploatacjaMaszyn.Width = 915;
                dgvEksploatacjaMaszyn.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                groupBox1.Refresh();
                groupBox2.Refresh();

                groupBox1.Visible = false;
                groupBox2.Visible = true;
                dgvEksploatacjaMaszyn.Update();
                dgvEksploatacjaMaszyn.Refresh();
            }
            else
            {
                groupBox2.Visible = false;
                groupBox1.Visible = false;
                groupBox1.Refresh();
                groupBox2.Refresh();
                dgvEksploatacjaMaszyn.Update();
                dgvEksploatacjaMaszyn.Refresh();
            }


        }

        private void btnDodajNorme_Click_1(object sender, EventArgs e)
        {
            DodawanieNowejNormy();
        }

        private void btnDodajObslugePP_Click(object sender, EventArgs e)
        {
            DodawanieNowejObslugi();
            initOpcjeRodzajObslugi();
        }
    }
}
