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

        IDEAEntities db = IDEADatabase.db;
        private bool flagSelected = false;
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
        private void DgwMaszyny()
        {
            dgvMaszynyEwidencja.DataSource = db.Maszyny_Ewidencja.ToList();
            this.dgvMaszynyEwidencja.Columns["Rodzaj_Maszyny"].Visible= false;
            dgvMaszynyEwidencja.Columns["Symbol_maszyny"].Visible = false;
            dgvMaszynyEwidencja.Columns["Marka_maszyny"].Visible = false;
            dgvMaszynyEwidencja.Columns["Data_przychodu"].Visible = false;
            dgvMaszynyEwidencja.Columns["Data_rozchodu"].Visible = false;
            dgvMaszynyEwidencja.Columns["Rodzaj_stategi_eksploatacji"].Visible = false;
            dgvMaszynyEwidencja.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }
   
        private void MaszynyForm_Load(object sender, EventArgs e)
        {
            dgvMaszynyEwidencja.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void 
    }

}
