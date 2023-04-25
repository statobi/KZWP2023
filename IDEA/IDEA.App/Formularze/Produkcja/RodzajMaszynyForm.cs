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
    public partial class RodzajMaszynyForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
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
            flagSelected = true;
            initDgwRodzajMaszyny();
            //flagSelected = false;


        }


        private void usuwanie(int id)
        {
            if (flagSelected == true)
            {
                var produkt = from p in db.Rodzaj_Maszyny
                              where p.ID_Rodzaj_Maszyny == id
                              select p;
                foreach (Rodzaj_Maszyny p in produkt)
                    db.Rodzaj_Maszyny.Remove(p);
                db.SaveChanges();
                initDgwRodzajMaszyny();
            }

        }
        private void dgvRodzajMaszyny_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = dgvRodzajMaszyny.CurrentRow.Index;

            DataGridViewRow selectedrow = dgvRodzajMaszyny.Rows[index];

            int IDSK = int.Parse(selectedrow.Cells[0].Value.ToString());
            usuwanie(IDSK);
        }
    }
}
