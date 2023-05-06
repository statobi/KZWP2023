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

namespace IDEA.App.Formularze.Logistyka.Pojazdy
{
    public partial class PrzegladyForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        int dataSN = 1;
        int IDPrzeglad;
        public PrzegladyForm()
        {
            InitializeComponent();
            initgridPrzeglad();
            btn_usun_przeglad.Enabled = false;
        }
        private void initgridPrzeglad()
        {
            dgv_przeglad.DataSource = db.Przeglady_View.ToList();
        }
        private void dgv_przeglad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataSN = dgv_przeglad.CurrentCell.RowIndex;
            IDPrzeglad = Int32.Parse(dgv_przeglad.Rows[dataSN].Cells["ID_PrzegladPojazdu"].Value.ToString());
            btn_usun_przeglad.Enabled = true;
        }

        private void btn_usun_przeglad_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć zaznaczony rekord?\n", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (var context = new IDEAEntities())
                {
                    var usunSWP = context.PrzegladPojazdus.SingleOrDefault(p => p.ID_PrzegladPojazdu == IDPrzeglad);

                    context.PrzegladPojazdus.Attach(usunSWP);
                    context.PrzegladPojazdus.Remove(usunSWP);

                    context.SaveChanges();


                }


                initgridPrzeglad();


            }
            else if (dialogResult == DialogResult.No)
            {
                return;

            }


        }

        private void btn_dodaj_przeglad_Click(object sender, EventArgs e)
        {
            using (DodajPrzegladForm Pr = new DodajPrzegladForm())
            {
                Pr.ShowDialog();
                initgridPrzeglad();
            }
        }
    }
}
