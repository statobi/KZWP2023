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
    public partial class MaszynyCU : Form
    {

        private bool flagEdit = false;
        Maszyny_Ewidencja selectedMaszyny_Ewidencja = new Maszyny_Ewidencja();
        IDEAEntities db = IDEADatabase.GetInstance();

        public MaszynyCU()
        {
            InitializeComponent();
            initOpcjeRodzajMaszyny();
            initOpcjeRodzajStrategiiEksploatacji();
        }


        public MaszynyCU(Maszyny_Ewidencja _selectedMaszyny_Ewidencja)
        {

            flagEdit = true;
            InitializeComponent();
            selectedMaszyny_Ewidencja = _selectedMaszyny_Ewidencja;
            lblKindWindow.Text = "Edytowanie IstniejącejMaszyny";
            cbRodzajMaszyny.Text = selectedMaszyny_Ewidencja.Rodzaj_maszyny;
            txtSymbolMaszyny.Text = selectedMaszyny_Ewidencja.Symbol_maszyny;
            txtMarkaMaszyny.Text = selectedMaszyny_Ewidencja.Marka_maszyny;
            txtModelMaszyny.Text = selectedMaszyny_Ewidencja.Model_maszyny;
            dateDataPrzychodu.Value = selectedMaszyny_Ewidencja.Data_przychodu;
            //dateDataRozchodu.Value = (DateTime)selectedMaszyny_Ewidencja.Data_rozchodu;
            cbRodzajStrategiiEksploatacji.Text = selectedMaszyny_Ewidencja.Rodzaj_strategii_eksploatacji;

        }
        private void lblImie_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (flagEdit)
            {
                //Edycja
                Maszyny_Ewidencja updateMaszyny_Ewidencja = db.Maszyny_Ewidencja.First(p => p.Symbol_maszyny == selectedMaszyny_Ewidencja.Symbol_maszyny);
                updateMaszyny_Ewidencja.Rodzaj_maszyny = cbRodzajMaszyny.Text;
                updateMaszyny_Ewidencja.Symbol_maszyny = txtSymbolMaszyny.Text;
                updateMaszyny_Ewidencja.Marka_maszyny = txtMarkaMaszyny.Text;
                updateMaszyny_Ewidencja.Model_maszyny = txtModelMaszyny.Text;
                updateMaszyny_Ewidencja.Data_przychodu = dateDataPrzychodu.Value;
                //updateMaszyny_Ewidencja.Data_rozchodu = dateDataRozchodu.Value;
                updateMaszyny_Ewidencja.Rodzaj_strategii_eksploatacji = cbRodzajStrategiiEksploatacji.Text;
                db.SaveChanges();
            }
            else
            {
                //Dodanie nowego klienta
                Maszyny_Ewidencja Maszyny_EwidencjaNew = new Maszyny_Ewidencja();
                Maszyny_EwidencjaNew.Rodzaj_maszyny = cbRodzajMaszyny.Text;
                Maszyny_EwidencjaNew.Symbol_maszyny = txtSymbolMaszyny.Text;
                Maszyny_EwidencjaNew.Marka_maszyny = txtMarkaMaszyny.Text;
                Maszyny_EwidencjaNew.Model_maszyny = txtModelMaszyny.Text;
                Maszyny_EwidencjaNew.Data_przychodu = dateDataPrzychodu.Value;
                //Maszyny_EwidencjaNew.Data_rozchodu = dateDataRozchodu.Value;
                Maszyny_EwidencjaNew.Rodzaj_strategii_eksploatacji = cbRodzajStrategiiEksploatacji.Text;
                db.Maszyny_Ewidencja.Add(Maszyny_EwidencjaNew);
                db.SaveChanges();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void initOpcjeRodzajMaszyny()
        {
            var RodzajeMaszyn = db.Rodzaj_Maszyny
            .Select(x => x.Nazwa).ToList();
            cbRodzajMaszyny.DataSource = RodzajeMaszyn;
            cbRodzajMaszyny.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRodzajMaszyny.SelectedIndex = -1;
        }

        private void initOpcjeRodzajStrategiiEksploatacji()
        {
        var RodzajeStrategiiEksploatacji = db.Rodzaj_Strategii_Eksp
                .Select(s => s.Nazwa).ToList();
            cbRodzajStrategiiEksploatacji.DataSource = RodzajeStrategiiEksploatacji;
            cbRodzajStrategiiEksploatacji.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRodzajStrategiiEksploatacji.SelectedIndex = -1;
        }

        private void MaszynyCU_Load(object sender, EventArgs e)
        {

        }

        private void txtRodzajMaszyny_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbRodzajMaszyny_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajRodzMaszyny_Click(object sender, EventArgs e)
        {
            
                           
        }

        private void btnDodajRodzMaszyny_Click_1(object sender, EventArgs e)
        {
            RodzajMaszynyForm RodzajMaszyny = new RodzajMaszynyForm();
            RodzajMaszyny.ShowDialog();
        }
    }
}
