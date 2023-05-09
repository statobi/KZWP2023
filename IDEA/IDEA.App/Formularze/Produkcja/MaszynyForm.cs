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
    public partial class MaszynyForm : Form
    {

        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        //private IDEAEntities db;
        Maszyny selectedMaszyny = new Maszyny();

        public MaszynyForm()
        {
            InitializeComponent();
            ToolTip toolTipNew = new ToolTip();
            toolTipNew.SetToolTip(iBtnNew, "Nowy");
            ToolTip toolTipModify = new ToolTip();
            toolTipModify.SetToolTip(iBtnEdit, "Edytuj");
            ToolTip toolTipDelete = new ToolTip();
            toolTipDelete.SetToolTip(iBtnDelete, "Usuń");
            initDgwMaszyny();
        }


         private void initDgwMaszyny()
        {
            dgvMaszyny.DataSource = db.Maszyny_Ewidencja.ToList();
           dgvMaszyny.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dgvMaszyny_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filtr = txtSearch.Text;

            dgvMaszyny.DataSource = db.Maszyny_Ewidencja.Where(k => k.Rodzaj_maszyny.Contains(filtr)).ToList();
            dgvMaszyny.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void iBtnNew_Click(object sender, EventArgs e)
        {
            using (MaszynyCU Pr = new MaszynyCU())
            {
                Pr.ShowDialog();
                initDgwMaszyny();
            }
        }

        private void iBtnEdit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEksploatacja_Click(object sender, EventArgs e)
        {
            EksploatacjaMaszynForm EksploatacjaMaszyn = new EksploatacjaMaszynForm();
            EksploatacjaMaszyn.ShowDialog();
            
        }

        private void btnKontrolaJakosci_Click(object sender, EventArgs e)
        {

        }

        private void btnObsluga_Click(object sender, EventArgs e)
        {
            ObslugaMaszynForm ObslugaMaszyn = new ObslugaMaszynForm();
            ObslugaMaszyn.ShowDialog();
        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {
            usuwanie();
        }

        private void usuwanie()
        {

            // if (flagSelected == true)
            //{
            var maszyna = from p in db.Maszynies
                          where p.ID_Maszyny == selectedMaszyny.ID_Maszyny
                          select p;
            foreach (Maszyny p in maszyna)
                db.Maszynies.Remove(p);
            db.SaveChanges();
            initDgwMaszyny();
            flagSelected = false;
            //}

        }

        private void dgvMaszyny_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = dgvMaszyny.CurrentRow.Index;

            DataGridViewRow selectedrow =dgvMaszyny.Rows[index];
            selectedMaszyny.ID_Maszyny = int.Parse(selectedrow.Cells[0].Value.ToString());
        }

        private void MaszynyForm_Load(object sender, EventArgs e)
        {
            dgvMaszyny.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
