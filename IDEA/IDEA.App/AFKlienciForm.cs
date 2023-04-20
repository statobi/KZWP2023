using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDEA.Database;

namespace IDEA.App
{
    public partial class AFKlienciForm : Form
    {
        IDEAEntities db = new IDEAEntities();
        Klient selectedKlient = new Klient();

        public AFKlienciForm()
        {
            InitializeComponent();
            ToolTip toolTipNew = new ToolTip();
            toolTipNew.SetToolTip(iBtnNew, "Nowy");
            ToolTip toolTipModify = new ToolTip();
            toolTipModify.SetToolTip(iBtnEdit, "Edytuj");
            ToolTip toolTipDelete = new ToolTip();
            toolTipDelete.SetToolTip(iBtnDelete, "Usuń");
            initDgwKlienci();
            
            
        }

        private void initDgwKlienci()
        {
            dgvKlienci.DataSource = db.Klient.ToList();
            this.dgvKlienci.Columns["ID_Klient"].Visible = false;
            dgvKlienci.Columns["Kontrola_Jakosci_Zamowienia"].Visible=false;
            dgvKlienci.Columns["Sklad_Zamowienia"].Visible = false;
            dgvKlienci.Columns["Zamowienia_Klienci"].Visible = false;
            dgvKlienci.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void AFKlienciForm_Load(object sender, EventArgs e)
        {
            

            dgvKlienci.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void openKlientEdition(object sender)
        {

        }
        private void openKlientEdition(object sender, Klient klient)
        {

        }
        private void iBtnNew_Click(object sender, EventArgs e)
        {
            if (selectedKlient != null)
            {
                openKlientEdition(sender);
            }
        }


    }
    }
