using IDEA.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Pojazdy
{
    public partial class UbezpieczenieForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();        
        private int _selectedIndex = 0;
        int dataSN = 1;
        int IDubezpieczenie;
        Ubezpieczenie selectedUbezpieczenie = new Ubezpieczenie();

        public UbezpieczenieForm()
        {
            InitializeComponent();
            initgridUbezpieczenia();
            btn_usunUbezpieczenie.Enabled = false;
        }

        private void initgridUbezpieczenia()
        {
            dgv_ubezpieczenia.DataSource = db.Ubezpieczenie_View.ToList();
        }


        private void btn_dodajUbezpieczenie_Click(object sender, EventArgs e)
        {
            using (DodajUbezpieczenieForm Pr = new DodajUbezpieczenieForm())
            {
                Pr.ShowDialog();
                initgridUbezpieczenia();
                dgv_ubezpieczenia.Refresh();
            }
        }

        private void dgv_ubezpieczenia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataSN = dgv_ubezpieczenia.CurrentCell.RowIndex;
            IDubezpieczenie = Int32.Parse(dgv_ubezpieczenia.Rows[dataSN].Cells["ID_Ubezpieczenie"].Value.ToString());
            btn_usunUbezpieczenie.Enabled = true;

        }

        private void btn_usunUbezpieczenie_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć zaznaczony rekord?\n", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (var context = new IDEAEntities())
                {
                    var usunSWP = context.Ubezpieczenies.SingleOrDefault(p => p.ID_Ubezpieczenie == IDubezpieczenie);

                    context.Ubezpieczenies.Attach(usunSWP);
                    context.Ubezpieczenies.Remove(usunSWP);

                    context.SaveChanges();


                }


                initgridUbezpieczenia();
                dgv_ubezpieczenia.Refresh();

            }
            else if (dialogResult == DialogResult.No)
            {
                return;

            }


        }


    }
}
