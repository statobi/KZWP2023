using IDEA.Database;
using IDEA.Logistyka.Magazyny;
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
    public partial class PojazdyForm : Form

    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelected = false;
        public PojazdyForm()
        {
            InitializeComponent();
            InitGridPojazd();
        }
        private void InitGridPojazd()
        {
            dgv_pojazdymain.DataSource = db.Pojazds.ToList();
            dgv_pojazdymain.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }
        private void PojazdyForm_Load(object sender, EventArgs e)
        {
            dgv_pojazdymain.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dgv_pojazdymain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            dgv_pojazdymain.Columns["DataRozchodu"].Visible = false;
            dgv_pojazdymain.Columns["Data_ubezpieczenia"].HeaderText = "Data ubezpieczenia";
            dgv_pojazdymain.Columns["Data_przeglądu"].HeaderText = "Data przeglądu";
        }

        private void btn_usun_Click(object sender, EventArgs e)
        {

        }
    }
}
