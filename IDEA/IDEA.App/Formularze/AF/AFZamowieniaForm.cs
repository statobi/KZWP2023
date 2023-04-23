﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using IDEA.Database;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Common;
using System.Data.SqlClient;

namespace IDEA.App
{
    public partial class AFZamowieniaForm : Form
    {
        IDEAEntities db = IDEADatabase.db;

        //private IDEAEntities db;
        Klient selectedKlient = new Klient();

        public AFZamowieniaForm()
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
            dgvZamowienia.DataSource = db.Zamowienia_Klienci.ToList();
            this.dgvZamowienia.Columns["ID_Klient"].Visible = false;
            dgvZamowienia.Columns["Kontrola_Jakosci_Zamowienia"].Visible=false;
            dgvZamowienia.Columns["Sklad_Zamowienia"].Visible = false;
            dgvZamowienia.Columns["Zamowienia_Klienci"].Visible = false;
            dgvZamowienia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void AFKlienciForm_Load(object sender, EventArgs e)
        {
            dgvZamowienia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void dgvKlienci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = dgvZamowienia.CurrentRow.Index;

            DataGridViewRow selectedrow = dgvZamowienia.Rows[index];

            selectedKlient.Imie = selectedrow.Cells[1].Value.ToString();
            selectedKlient.Nazwisko = selectedrow.Cells[2].Value.ToString();
            selectedKlient.Nazwa_Podmiotu = selectedrow.Cells[3].Value.ToString();
            selectedKlient.NIP = selectedrow.Cells[4].Value.ToString();
            selectedKlient.Adres_Ulica = selectedrow.Cells[5].Value.ToString();
            selectedKlient.Adres_Kod_Pocztowy = selectedrow.Cells[6].Value.ToString();
            selectedKlient.Adres_Miasto = selectedrow.Cells[7].Value.ToString();
            selectedKlient.Telefon = selectedrow.Cells[8].Value.ToString();
            selectedKlient.E_mail = selectedrow.Cells[9].Value.ToString();
        }
        /*
        private void openKlientEdition(object sender)
        {

        }
        private void openKlientEdition(object sender, Klient klient)
        {

        }*/

        //Wersja Dodawanie
        private void iBtnNew_Click(object sender, EventArgs e)
        {
            //openKlientEdition(sender);

            AFKlienciCU aF = new AFKlienciCU();
            aF.ShowDialog();
        }
        //Wersja Edycja
        private void iBtnEdit_Click(object sender, EventArgs e)
        {
            AFKlienciCU aF = new AFKlienciCU(selectedKlient);
            aF.ShowDialog();
        }

        private void iBtnDelete_Click(object sender, EventArgs e)
        {

        }
        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filtr = txtSearch.Text;
            
            dgvZamowienia.DataSource = db.Klient.Where(k => k.Imie.Contains(filtr)).ToList();
            dgvZamowienia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


        }
    }
    }
