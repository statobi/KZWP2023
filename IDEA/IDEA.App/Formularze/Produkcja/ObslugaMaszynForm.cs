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
    public partial class ObslugaMaszynForm : Form
    {

        IDEAEntities db = IDEADatabase.GetInstance();

        public ObslugaMaszynForm()
        {
            InitializeComponent();
            initSymbolMaszyny();
            initRodzajObslugi();
            initDGVObslugi();
            initWyborPracownicy();



        }

        private void InitWyborSymbolu()
        {
            string SymbolMaszyny = cbSymbolMaszyny.Text;
            var PodgladObslug = db.RodzajObsl_Model
                .Where(x=>x.Symbol_maszyny==SymbolMaszyny)
                .ToList();
            dgvObslugi.DataSource = PodgladObslug;

        }
        private void initDGVObslugi()
        {
            dgvObslugi.DataSource = db.RodzajObsl_Model.ToList();
            dgvObslugi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void initSymbolMaszyny()
        {
            var SymbolMaszyny = db.Maszynies
               .Select(s => new { s.ID_Maszyny, s.Symbol }).ToList();
            cbSymbolMaszyny.DataSource = SymbolMaszyny;
            cbSymbolMaszyny.ValueMember = "ID_Maszyny";
            cbSymbolMaszyny.DisplayMember = "Symbol";
            cbSymbolMaszyny.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSymbolMaszyny.SelectedIndex = -1;
        }

    
        private void initRodzajObslugi()
        {
            // wybor rodzaju obslugi
            // ggjkjk;l
            var Obsluga = db.Rodzaj_Obslugi_Maszyny
              .Select(o => new { o.ID_Rodzaj_Obslugi_Maszyny , o.Nazwa }).ToList();
            cbObsluga.DataSource = Obsluga;
            cbObsluga.ValueMember = "ID_Rodzaj_Obslugi_Maszyny";
            cbObsluga.DisplayMember = "Nazwa";
            cbObsluga.DropDownStyle = ComboBoxStyle.DropDownList;
            cbObsluga.SelectedIndex = -1;

        }

        private void initWyborPracownicy()
        {
            
            var WyborPracownika = db.V_Operatorzy_Maszyn
                    .Select(s => s.Nazwisko).ToList();
            cbPracownik.DataSource = WyborPracownika;
            cbPracownik.SelectedIndex = -1;

        }

        private void InitDodajObsluge()
        {
            Obslugi ObslugaNew = new Obslugi();
            ObslugaNew.ID_Maszyny = int.Parse(txtSymbolMaszyny.Text.ToString());
            ObslugaNew.ID_Rodzaj_Obslugi_Maszyny = int.Parse(cbObsluga.Text);
            ObslugaNew.ID_Pracownicy = int.Parse(cbPracownik.SelectedValue.ToString());
            ObslugaNew.Koszt_netto = double.Parse(txtKosztNetto.Text);
            ObslugaNew.Koszt_brutto = double.Parse(txtKosztBrutto.Text);
            ObslugaNew.Data_od = dtpRozpoczecieObslugi.Value;
            ObslugaNew.Data_do = dtpZakonczenieObslugi.Value;
            ObslugaNew.Opis = txtopis.Text;

            db.Obslugis.Add(ObslugaNew);
            db.SaveChanges();
            dgvObslugi.Update();
            dgvObslugi.Refresh();
            initDGVObslugi();



        }
        private void cbSymbolMaszyny_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitWyborSymbolu();
        }

        private void ObslugaMaszynForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDodajObsluge_Click(object sender, EventArgs e)
        {
            groupBox1.Show();

            // UZupełnianie ID skladu zamowienia
            string Symbol = cbSymbolMaszyny.Text.ToString();
            txtSymbolMaszyny.Text = Symbol;
           
        }

        private void txtKosztNetto_TextChanged(object sender, EventArgs e)
        {
            InitObliczanieKosztuBrutto();
        }

        private void InitObliczanieKosztuBrutto()
        {
            double Brutto = 1.2 * double.Parse(txtKosztNetto.Text);
            txtKosztBrutto.Text = Brutto.ToString();
        }

        private void iBtnNew_Click(object sender, EventArgs e)
        {
            InitDodajObsluge();
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            initDGVObslugi();
        }
    }
}
