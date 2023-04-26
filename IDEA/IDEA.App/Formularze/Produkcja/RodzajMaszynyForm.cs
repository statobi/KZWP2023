using IDEA.Database;
using Newtonsoft.Json.Linq;
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
    public partial class RodzajMaszynyForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        Rodzaj_Maszyny DodanyRodzaj = new Rodzaj_Maszyny();
        public RodzajMaszynyForm()
        {
            InitializeComponent();
            initDgwRodzajMaszyny();
                    }

        private void initDgwRodzajMaszyny()
        {
            dgvRodzajMaszyny.DataSource = db.Rodzaj_Maszyny.ToList();
            this.dgvRodzajMaszyny.Columns["Model_Maszyny"].Visible = false;
            dgvRodzajMaszyny.Columns["Proces_Technologiczny"].Visible = false;
            dgvRodzajMaszyny.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void DodanieRodzajMaszyny()
        {
            Rodzaj_Maszyny Rodzaj_maszynynew = new Rodzaj_Maszyny();
            Rodzaj_maszynynew.Nazwa = txtRodzajMaszyny.Text;
            db.Rodzaj_Maszyny.Add(Rodzaj_maszynynew);
            db.SaveChanges();
            dgvRodzajMaszyny.Update();
            dgvRodzajMaszyny.Refresh();
            initDgwRodzajMaszyny();
        }
        private void lblKindWindow_Click(object sender, EventArgs e)
        {

        }

        private void dgvRodzajMaszyny_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            DodanieRodzajMaszyny();

        }

        private void RodzajMaszynyForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {
            usuwanie();
            initDgwRodzajMaszyny();
            //flagSelected = false;


        }


        private void usuwanie()
        {
            
           // if (flagSelected == true)
            //{
                var produkt = from p in db.Rodzaj_Maszyny
                              where p.ID_Rodzaj_Maszyny == DodanyRodzaj.ID_Rodzaj_Maszyny
                              select p;
                foreach (Rodzaj_Maszyny p in produkt)
                    db.Rodzaj_Maszyny.Remove(p);
                db.SaveChanges();
                initDgwRodzajMaszyny();
                flagSelected = false;
            //}

        }
        private void dgvRodzajMaszyny_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = dgvRodzajMaszyny.CurrentRow.Index;

            DataGridViewRow selectedrow = dgvRodzajMaszyny.Rows[index];
            DodanyRodzaj.ID_Rodzaj_Maszyny = int.Parse(selectedrow.Cells[0].Value.ToString());
            
            
        }
    }
}
