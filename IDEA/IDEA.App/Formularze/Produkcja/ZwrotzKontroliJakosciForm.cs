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
    public partial class ZwrotzKontroliJakosciForm : Form
    {

        IDEAEntities db = IDEADatabase.GetInstance();
        public ZwrotzKontroliJakosciForm()
        {
            InitializeComponent();
        }

        private void ZwrotzKontroliJakosciForm_Load(object sender, EventArgs e)
        {
            initZwrotu();
        }


        private void initZwrotu()
        {
            dgvZwrot.DataSource = db.V_Zwrot_Kontrola_Jakosci.ToList();
            this.dgvZwrot.Columns["ID_Kontrola_Jakosci_Zamowienia"].Visible = false;
            dgvZwrot.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void iBtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
