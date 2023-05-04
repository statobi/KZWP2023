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
    public partial class ProcesyTechnologiczneForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        public ProcesyTechnologiczneForm()
        {
            InitializeComponent();
            initDgvProcesyTechnologiczne();
        }
        private void initDgvProcesyTechnologiczne()
        {
            dgvProcesyTechnologiczne.DataSource = db.Proces_Technologiczny_Produktu.ToList();
            //this.dgvProcesyTechnologiczne.Columns["ID_x"].Visible = false;
            dgvProcesyTechnologiczne.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
