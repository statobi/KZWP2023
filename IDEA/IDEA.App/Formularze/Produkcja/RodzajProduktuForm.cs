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
    public partial class RodzajProduktuForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        Rodzaj_Produktu DodanyRodzaj = new Rodzaj_Produktu();
        public RodzajProduktuForm()
        {
            InitializeComponent();
            initDgwRodzajProduktu();
        }

        private void initDgwRodzajProduktu()
        {
            dgvRodzajProduktu.DataSource = db.Rodzaj_Produktu.ToList();
            this.dgvRodzajProduktu.Columns["ID_Rodzaj_Produktu"].Visible = false;
            dgvRodzajProduktu.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void DodanieRodzajProduktu()
        {
            Rodzaj_Produktu newRodzajProduktu = new Rodzaj_Produktu();
            newRodzajProduktu.Nazwa = txtRodzajProduktu.Text;
            db.Rodzaj_Produktu.Add(newRodzajProduktu);
            db.SaveChanges();
            dgvRodzajProduktu.Update();
            dgvRodzajProduktu.Refresh();
            initDgwRodzajProduktu();
        }
        private void lblKindWindow_Click(object sender, EventArgs e)
        {

        }

        private void dgvRodzajMaszyny_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            DodanieRodzajProduktu();

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
            initDgwRodzajProduktu();
            //flagSelected = false;


        }


        private void usuwanie()
        {
            
           // if (flagSelected == true)
            //{
                var query = from p in db.Rodzaj_Produktu
                              where p.ID_Rodzaj_Produktu == DodanyRodzaj.ID_Rodzaj_Produktu
                              select p;
                foreach (Rodzaj_Produktu p in query)
                    db.Rodzaj_Produktu.Remove(p);
                db.SaveChanges();
                initDgwRodzajProduktu();
                flagSelected = false;
            //}

        }


        private void dgvRodzajProduktu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRodzajProduktu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = dgvRodzajProduktu.CurrentRow.Index;

            DataGridViewRow selectedrow = dgvRodzajProduktu.Rows[index];
            DodanyRodzaj.ID_Rodzaj_Produktu = int.Parse(selectedrow.Cells[0].Value.ToString());
        }
    }
}
