using IDEA.App.Formularze.Logistyka.Wysylki;
using IDEA.Database;
using IDEA.Logistyka.Observer;
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
        CommonPublisher commonPublisher = CommonPublisher.GetInstance();
        int dataSN = 1, IDdostawy = 1;

        public DostawyForm()
        {
            InitializeComponent();
            initDgvWysylka();
            initDgvSkladDostawy();
        }

        public void GetNotification()
        {

            initDgvWysylka();
            initDgvSkladDostawy();
        }

        void initDgvWysylka()
        {
            dgvDostawa.DataSource = db.Dostawy_All.ToList();
            dgvDostawa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvDostawa.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDostawa.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDostawa.Rows[0].Selected = true;
        }

        private void initDgvSkladDostawy()
        {
            var query = (from s in db.SkladDostawa_Material
                         join m in db.Materials on s.ID_Material equals m.ID_Material
                         where s.ID_Dostawa == IDdostawy
                         select new
                         {
                             ID_Dostawy = IDdostawy,
                             ID_Material = m.ID_Material,
                             Nazwa = m.Nazwa,
                             Ilość = s.Ilosc,
                             KN = s.KosztNetto,
                             KB = s.KosztBrutto,
                             Faktura = s.ID_Faktury
                         }).ToList();
            dgvSkladDostawy.DataSource = query.ToList();
            dgvSkladDostawy.Columns["ID_Dostawy"].Visible = false;
            dgvSkladDostawy.Columns["KN"].HeaderText = "Koszt netto";
            dgvSkladDostawy.Columns["KB"].HeaderText = "Koszt brutto";
            dgvSkladDostawy.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSkladDostawy.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSkladDostawy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgvDostawa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataSN = dgvDostawa.CurrentCell.RowIndex;
            IDdostawy = Int32.Parse(dgvDostawa.Rows[dataSN].Cells["ID_Dostawa"].Value.ToString());
            initDgvSkladDostawy();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DostawyDodajForm secondForm = new DostawyDodajForm();
            secondForm.Show();
        }

        private void DostawyForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
      
    }
}
