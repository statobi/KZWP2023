using IDEA.App.Formularze.Logistyka.Wysylki;
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

namespace IDEA.App.Formularze.Logistyka.Dostawy
{
    public partial class DostawyForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();

        public DostawyForm()
        {
            InitializeComponent();
            initDGV();
        }

        void initDGV()
        {
            dgvDostawy.DataSource = db.Dostawy_All.ToList();
            dgvDostawy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DostawyDodajForm secondForm = new DostawyDodajForm();
            secondForm.Show();
        }
    }
}
