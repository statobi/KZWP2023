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
    public partial class ObslugaMaszynForm : Form
    {

        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        Obslugi DodanaObsluga = new Obslugi();
        Obslugi UsuwanaObsluga = new Obslugi();
        public ObslugaMaszynForm()
        {
            InitializeComponent();
            //initSymbolMaszyny();
            initRodzajObslugi();
            initDGVObslugi();
            initWyborPracownicy();
            INITDGVObslugaDoWykonania();
            initOpcjeRodzajStrategiiEksploatacji();
          


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

        private void INITWyborSymbolu3()
        {
            string SymbolMaszyny = cbSymbolMaszyny.Text;
            var PodgladObslug = db.Przekroczenie_parametru
                .Where(x => x.Symbol_maszyny == SymbolMaszyny)
                .ToList();
            dgvPrzekroczenieParametru.DataSource = PodgladObslug;
        }

        private void INITWyborSymbolu2()
        {
            string SymbolMaszyny = cbSymbolMaszyny.Text;
            var PodgladObslug = db.Zblizajaca_obsuga_PP
                .Where(x => x.Symbol_maszyny == SymbolMaszyny)
                .ToList();
            dgvObslugaDoWykonaniaPP.DataSource = PodgladObslug;
        }
        private void InitWyborSymbolu()
        {
            string SymbolMaszyny = cbSymbolMaszyny.Text;
            var PodgladObslug = db.RodzajObsl_Model
                .Where(x=>x.Symbol_maszyny==SymbolMaszyny)
                .ToList();
            dgvObslugi.DataSource = PodgladObslug;
            
            
        }

        private void INITPrzeroczenieParametru()
        {
            dgvPrzekroczenieParametru.DataSource = db.Przekroczenie_parametru.ToList();
            dgvPrzekroczenieParametru.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void INITDGVObslugaDoWykonania()
        {
            dgvObslugaDoWykonaniaPP.DataSource = db.Zblizajaca_obsuga_PP.ToList();
            dgvObslugaDoWykonaniaPP.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.dgvObslugaDoWykonaniaPP.Columns["ID_Maszyny"].Visible = false;
            dgvObslugaDoWykonaniaPP.Columns["ID_Model_Maszyny"].Visible = false;
            dgvObslugaDoWykonaniaPP.Columns["ID_Rodzaj_Obslugi_Maszyny"].Visible = false;
        }
        private void initDGVObslugi()
        {
            dgvObslugi.DataSource = db.RodzajObsl_Model.ToList();
            dgvObslugi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void initSymbolMaszyny()
        {
            var wybranastrategi = db.Rodzaj_Strategii_Eksp
                .Where(x => x.Nazwa == cbRodzajStrategiiEksploatacji.Text)
                .Select(x => x.ID_Rodzaj_Strategii_Eksp)
                .FirstOrDefault();

            var SymbolMaszyny = db.Maszynies
               .Where(s => s.Model_Maszyny.ID_Rodzaj_Strategii_Eksp == wybranastrategi)
               .Select(s => new { s.ID_Maszyny, s.Symbol }).ToList();
            cbSymbolMaszyny.DataSource = SymbolMaszyny;
            cbSymbolMaszyny.ValueMember = "ID_Maszyny";
            cbSymbolMaszyny.DisplayMember = "Symbol";
            cbSymbolMaszyny.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSymbolMaszyny.SelectedIndex = -1;
        }

    
        private void initRodzajObslugi()
        {
            // wybor rodzaju obslugi
            // ggjkjk;l
            var Obsluga = db.Rodzaj_Obslugi_Maszyny
              .Select(o => new { o.ID_Rodzaj_Obslugi_Maszyny , o.Nazwa }).ToList();
            cbObsluga.DataSource = Obsluga;
            cbObsluga.ValueMember = "ID_Rodzaj_Obslugi_Maszyny";
            cbObsluga.DisplayMember = "Nazwa";
            cbObsluga.DropDownStyle = ComboBoxStyle.DropDownList;
            cbObsluga.SelectedIndex = -1;

        }

        private void initWyborPracownicy()
        {
            
            var WyborPracownika = db.V_Operatorzy_Maszyn
                    .Select(s => s.Nazwisko).ToList();
            cbPracownik.DataSource = WyborPracownika;
            cbPracownik.SelectedIndex = -1;

        }

        private void InitDodajObsluge()
        {
            var IDMaszyny = db.Maszynies
                .Where(x => x.Symbol == txtSymbolMaszyny.Text)
                .Select(x => x.ID_Maszyny)
                .FirstOrDefault();

            var IDObslugi = db.Rodzaj_Obslugi_Maszyny
                .Where(x => x.Nazwa == cbObsluga.Text)
                .Select(x => x.ID_Rodzaj_Obslugi_Maszyny)
                .FirstOrDefault();

            var IDPracownik = db.Pracownicies
                .Where(x => x.Nazwisko == cbPracownik.Text)
                .Select(x => x.ID_Pracownicy)
                .FirstOrDefault();


            Obslugi ObslugaNew = new Obslugi();
            ObslugaNew.ID_Maszyny = IDMaszyny;
            ObslugaNew.ID_Rodzaj_Obslugi_Maszyny = IDObslugi;
            ObslugaNew.ID_Pracownicy = IDPracownik;
            ObslugaNew.Koszt_netto = double.Parse(txtKosztNetto.Text);
            ObslugaNew.Koszt_brutto = double.Parse(txtKosztBrutto.Text);
            ObslugaNew.Data_od = dtpRozpoczecieObslugi.Value;
            ObslugaNew.Data_do = dtpZakonczenieObslugi.Value;
            ObslugaNew.Opis = txtopis.Text;


            db.Obslugis.Add(ObslugaNew);
            db.SaveChanges();
            dgvObslugi.Update();
            dgvObslugi.Refresh();
            initDGVObslugi();



        }

        private void initDVGE()
        {
            if (cbRodzajStrategiiEksploatacji.Text == "Strategia eksploatacji według planowanej profilaktyki")
            {
              
                dgvObslugaDoWykonaniaPP.DataSource = db.Zblizajaca_obsuga_PP.ToList();
                              
                
                dgvObslugaDoWykonaniaPP.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                gbPP.Refresh();
                gbST.Refresh();
                gbPP.Visible = true;
                gbST.Visible = false;
                dgvObslugaDoWykonaniaPP.Update();
                dgvObslugaDoWykonaniaPP.Refresh();
              

            }
            else if (cbRodzajStrategiiEksploatacji.Text == "Strategia eksploatacji według stanu technicznego")
            {
                dgvPrzekroczenieParametru.DataSource = db.Przekroczenie_parametru.ToList();
                dgvPrzekroczenieParametru.Width = 915;
                dgvPrzekroczenieParametru.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                gbPP.Refresh();
                gbST.Refresh();

                gbPP.Visible = false;
                gbST.Visible = true;
                dgvPrzekroczenieParametru.Update();
                dgvPrzekroczenieParametru.Refresh();
            }
            else
            {
                gbST.Visible = false;
                gbPP.Visible = false;
                gbPP.Refresh();
                gbST.Refresh();
                dgvPrzekroczenieParametru.Update();
                dgvPrzekroczenieParametru.Refresh();
                dgvObslugaDoWykonaniaPP.Update();
                dgvObslugaDoWykonaniaPP.Refresh();
            }


        }
        private void cbSymbolMaszyny_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitWyborSymbolu();
            INITWyborSymbolu2();
            INITWyborSymbolu3();
            LadowanieParametruProcesu();

        }

        private void ObslugaMaszynForm_Load(object sender, EventArgs e)
        {
            dgvObslugi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvObslugaDoWykonaniaPP.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPrzekroczenieParametru.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDodajObsluge_Click(object sender, EventArgs e)
        {
            groupBox1.Show();

            // UZupełnianie ID skladu zamowienia
            string Symbol = cbSymbolMaszyny.Text.ToString();
            txtSymbolMaszyny.Text = Symbol;
           
        }

        private void txtKosztNetto_TextChanged(object sender, EventArgs e)
        {
            InitObliczanieKosztuBrutto();
        }

        private void InitObliczanieKosztuBrutto()
        {
            double Brutto = 1.2 * double.Parse(txtKosztNetto.Text);
            txtKosztBrutto.Text = Brutto.ToString();
        }

        private void iBtnNew_Click(object sender, EventArgs e)
        {
            InitDodajObsluge();
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            initDGVObslugi();
            INITDGVObslugaDoWykonania();
            INITPrzeroczenieParametru();
            
         }

        private void usuwanie()
        {

            // if (flagSelected == true)
            //{
            var obsluga = from p in db.Obslugis
                          where p.ID_Obslugi == DodanaObsluga.ID_Obslugi
                          select p;
            foreach (Obslugi p in obsluga)
                db.Obslugis.Remove(p);
            db.SaveChanges();
            initDGVObslugi();
            flagSelected = false;
            //}

        }

        private void dgvObslugi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = dgvObslugi.CurrentRow.Index;

            DataGridViewRow selectedrow = dgvObslugi.Rows[index];
            DodanaObsluga.ID_Obslugi = int.Parse(selectedrow.Cells[0].Value.ToString());
        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {
            usuwanie();
        }

        private void dgvObslugi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbRodzajStrategiiEksploatacji_SelectedIndexChanged(object sender, EventArgs e)
        {
            initDVGE();
            initSymbolMaszyny();
        }

        private void LadowanieParametruProcesu()
        {
            var IDmodelmaszyny = db.Maszynies
                .Where(x => x.Symbol == cbSymbolMaszyny.Text)
                .Select(x => x.ID_Model_Maszyny)
                .FirstOrDefault();


            var Wyborpar = db.Parametr_Maszyny
                .Where(x => x.ID_Model_Maszyny == IDmodelmaszyny)
                .Select(x => x.Nazwa_Parametru)
                .ToList();
            cbParametry.DataSource = Wyborpar;
            cbParametry.DropDownStyle = ComboBoxStyle.DropDownList;
            cbParametry.SelectedIndex = -1;
        }

        private void btnPrognozy_Click(object sender, EventArgs e)
        {

            prognozowanie();


        }

        private void prognozowanie()
        {
            IDEA.Produkcja.PrognozowanieParametru prognoza = new IDEA.Produkcja.PrognozowanieParametru();

            var IDmodelmaszyny = db.Maszynies
               .Where(x => x.Symbol == cbSymbolMaszyny.Text)
               .Select(x => x.ID_Model_Maszyny)
               .FirstOrDefault();

            var IDMaszyny = db.Maszynies
               .Where(x => x.Symbol == cbSymbolMaszyny.Text)
               .Select(x => x.ID_Maszyny)
               .FirstOrDefault();


            var WyborParametrow = db.Parametr_Maszyny
                .Where(x => x.ID_Model_Maszyny == IDmodelmaszyny && x.Nazwa_Parametru == cbParametry.Text)
                .Select(x => x.ID_Parametr_Maszyny)
                .FirstOrDefault();

            var wybierzdolnagranice = db.Parametr_Maszyny
                .Where(x => x.ID_Parametr_Maszyny == WyborParametrow)
                .Select(x => x.Dolna_Granica)
                .FirstOrDefault();

            var wartoscibadan = db.Badany_Parametr
                .Where(x => x.ID_Parametr_Maszyny == WyborParametrow)
                .Select(x => x.Wartosc)
                .ToArray();
            var IDbadan = db.Badany_Parametr
                .Where(x => x.ID_Parametr_Maszyny == WyborParametrow)
                .Select(x => x.ID_Badanie)
                .ToArray();


            if (wartoscibadan.Length >= 3)
            {
                DateTime[] datybadan = { };
                for (int i = 0; i < wartoscibadan.Length; i++)
                {

                    var databadania = db.Badanie_Maszyny
                        .Where(x => x.ID_Badanie == IDbadan[i] && x.ID_Maszyny == IDMaszyny)
                        .Select(x => x.Data)
                        .FirstOrDefault();
                    datybadan[i] = databadania;
                }


                double[] wartosc = wartoscibadan;

                double granica = wybierzdolnagranice;


                MessageBox.Show("Data Przekroczenia: " + prognoza.Prognozowanie(wartosc, datybadan, granica).ToString());
            }
            else
            {
                MessageBox.Show("Za mało badań dla bieżącego parametru, należy wykonać conajmniej 3 badania ");
            }
        }
    }

}
