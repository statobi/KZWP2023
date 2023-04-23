﻿using IDEA.Database;
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
    public partial class PlanowanieProcesyForm : Form
    {
        IDEAEntities db = IDEADatabase.db;
        private bool flagSelected = false;
        //private IDEAEntities db;
        public PlanowanieProcesyForm()
        {
            
            InitializeComponent();
            ToolTip toolTipNew = new ToolTip();
            toolTipNew.SetToolTip(iBtnNew, "Nowy");
            ToolTip toolTipModify = new ToolTip();
            toolTipModify.SetToolTip(iBtnEdit, "Edytuj");
            ToolTip toolTipDelete = new ToolTip();
            toolTipDelete.SetToolTip(iBtnDelete, "Usuń");
            initDgvProcesy();
        }
        private void initDgvProcesy()
        {
            dgvProcesy.DataSource = db.Proces.ToList();
            //this.dgvProcesy.Columns["ID_Klient"].Visible = false;
            //dgvProcesy.Columns["Kontrola_Jakosci_Zamowienia"].Visible = false;
            //dgvProcesy.Columns["Sklad_Zamowienia"].Visible = false;
            //dgvProcesy.Columns["Zamowienia_Klienci"].Visible = false;

            //dgvProcesy.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void PlanowanieProcesyForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvProcesy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
