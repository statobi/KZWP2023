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
                       
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DodanieMaszyny();
                        
        }

        private void initOpcjeModelMaszyny()
        {

            var IDRodzajMaszyny = db.Rodzaj_Maszyny
                .Where(x => x.Nazwa == cbRodzajMaszyny.Text)
                .Select(x => x.ID_Rodzaj_Maszyny)
                .FirstOrDefault();
            var ModelMaszyny = db.Model_Maszyny
                .Where(x => x.ID_Rodzaj_Maszyny == IDRodzajMaszyny)
                .Select(x => new {x.ID_Model_Maszyny, x.Model}).ToList();
            cbModelMaszyny.DataSource = ModelMaszyny;
            cbModelMaszyny.ValueMember = "ID_Model_Maszyny";
            cbModelMaszyny.DisplayMember= "Model";
                               
            UzupelnienieMarkiMaszyny();
            UzupelnienieKosztRoboczogodziny();
        }

        private void UzupelnienieMarkiMaszyny()
        {
            var MarkaMaszyny = db.Model_Maszyny
                .Where(x => x.Model == cbModelMaszyny.Text)
                .Select(x => x.Marka)
                .FirstOrDefault();
            
            txtMarkaMaszyny.Text = MarkaMaszyny;
        }

        private void UzupelnienieKosztRoboczogodziny()
        {
            var KosztRoboczoGodziny = db.Model_Maszyny
                .Where(x => x.Model == cbModelMaszyny.Text)
                .Select(x => x.Koszt_Roboczogodziny)
                .FirstOrDefault();
            txtKosztRoboczogodziny.Text = KosztRoboczoGodziny.ToString();
        }
        private void initOpcjeRodzajMaszyny()
        {
            var RodzajeMaszyn = db.Rodzaj_Maszyny
            .Select(x => new {x.ID_Rodzaj_Maszyny, x.Nazwa }).ToList();
            cbRodzajMaszyny.DataSource = RodzajeMaszyn;
            cbRodzajMaszyny.ValueMember = "ID_Rodzaj_Maszyny";
            cbRodzajMaszyny.DisplayMember= "Nazwa";
            cbRodzajMaszyny.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRodzajMaszyny.SelectedIndex = -1;
        }
              
       
        private void DodanieMaszyny()
        {
            MessageBox.Show("Dodano maszyne");
            Maszyny nowaMaszyna = new Maszyny();
 
            nowaMaszyna.ID_Model_Maszyny = (int)cbModelMaszyny.SelectedValue;
            nowaMaszyna.Symbol = txtSymbolMaszyny.Text;
            nowaMaszyna.Przebieg_poczatkowy = int.Parse(txtPrzebiegPoczatkowy.Text);
            nowaMaszyna.Data_przychodu = dateDataPrzychodu.Value;
            if (checkBoxDataRozchodu.Checked)
            {
                nowaMaszyna.Data_rozchodu = dateDataRozchodu.Value;
            }
            else
                nowaMaszyna.Data_rozchodu = null;
            db.Maszynies.Add(nowaMaszyna);
            db.SaveChanges();

        }
        private void MaszynyCU_Load(object sender, EventArgs e)
        {

        }


        private void cbRodzajMaszyny_SelectedIndexChanged(object sender, EventArgs e)
        {
            initOpcjeModelMaszyny();
        }

        private void btnDodajRodzMaszyny_Click_1(object sender, EventArgs e)
        {
            RodzajMaszynyForm RodzajMaszyny = new RodzajMaszynyForm();
            RodzajMaszyny.ShowDialog();
        }

        private void txtSymbolMaszyny_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDodajModelMaszyny_Click(object sender, EventArgs e)
        {
            DodajModelMaszynyForm ModelMaszyny = new DodajModelMaszynyForm();
            ModelMaszyny.ShowDialog();
        }

        private void cbRodzajMaszyny_Click(object sender, EventArgs e)
        {
            initOpcjeModelMaszyny();
        }

        private void checkBoxDataRozchodu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDataRozchodu.Checked)
            {
                dateDataRozchodu.Enabled= true;
            }
            else
            {
                dateDataRozchodu.Enabled = false;
            }
        }

        private void cbModelMaszyny_SelectedIndexChanged(object sender, EventArgs e)
        {
            UzupelnienieKosztRoboczogodziny();
            UzupelnienieMarkiMaszyny();
        }

        private void txtKosztRoboczogodziny_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
