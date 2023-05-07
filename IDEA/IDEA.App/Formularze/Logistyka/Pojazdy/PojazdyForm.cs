using IDEA.App.Formularze.Logistyka.Transport_wewnetrzny;
using IDEA.App.Models;
using IDEA.Database;
using IDEA.Logistyka.Magazyny;
using IDEA.Logistyka.Observer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Pojazdy
{
    public partial class PojazdyForm : Form

    {
        IDEAEntities db = IDEADatabase.GetInstance();
        //private IDEAEntities db;
        Pojazd selectedPojazd = new Pojazd();
        int dataSN = 1;
        int IDpojazd;
        public PojazdyForm()
        {
            InitializeComponent();
            InitGridPojazd();
            btn_usun_pojazd.Enabled = false;
        }
        private void InitGridPojazd()
        {
            dgv_pojazdymain.DataSource = db.Pojazdy_All.ToList();
            dgv_pojazdymain.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }
        private void PojazdyForm_Load(object sender, EventArgs e)
        {
            dgv_pojazdymain.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }


        private void btn_add_car_Click(object sender, EventArgs e)
        {

        }

        private void btn_modyfikuj_Click(object sender, EventArgs e)
        {

        }

        private void btn_dostepne_pojazdy_Click(object sender, EventArgs e)
        {
            dgv_pojazdymain.DataSource = db.Dostepne_Pojazdy.ToList();
            dgv_pojazdymain.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btn_usun_Click(object sender, EventArgs e)
        {

        }

        private void btn_odswiez_Click(object sender, EventArgs e)
        {
            InitGridPojazd();
            dgv_pojazdymain.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv_pojazdymain.Refresh();
        }

        private void btn_ubezpieczenia_Click(object sender, EventArgs e)
        {
            using (UbezpieczenieForm Pr = new UbezpieczenieForm())
            {
                Pr.ShowDialog();
                InitGridPojazd();
                dgv_pojazdymain.Refresh();
            }
        }

        private void btn_dodaj_pojazd_Click(object sender, EventArgs e)
        {
            using (DodajPojazdForm Pr = new DodajPojazdForm())
            {
                Pr.ShowDialog();
                InitGridPojazd();
                dgv_pojazdymain.Refresh();
            }
        }

        private void btn_usun_pojazd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć zaznaczony rekord?\n", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (var context = new IDEAEntities())
                {
                    var usunSWP = context.Pojazds.SingleOrDefault(p => p.ID_Pojazd == IDpojazd);

                    context.Pojazds.Attach(usunSWP);
                    context.Pojazds.Remove(usunSWP);

                    context.SaveChanges();


                }


                InitGridPojazd();
                dgv_pojazdymain.Refresh();


            }
            else if (dialogResult == DialogResult.No)
            {
                return;

            }


        }

        private void dgv_pojazdymain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataSN = dgv_pojazdymain.CurrentCell.RowIndex;
            IDpojazd = Int32.Parse(dgv_pojazdymain.Rows[dataSN].Cells["ID_Pojazd"].Value.ToString());
            btn_usun_pojazd.Enabled = true;
            
            int index;
            index = dgv_pojazdymain.CurrentRow.Index;

            DataGridViewRow selectedrow = dgv_pojazdymain.Rows[index];
            selectedPojazd.ID_Pojazd = int.Parse(selectedrow.Cells[0].Value.ToString());
            selectedPojazd.NrRejestracyjny = selectedrow.Cells[1].Value.ToString();
        }

        private void btn_przeglady_Click(object sender, EventArgs e)
        {
            using (PrzegladyForm Pr = new PrzegladyForm())
            {
                Pr.ShowDialog();
                InitGridPojazd();
                dgv_pojazdymain.Refresh();
            }
        }
    }
}
