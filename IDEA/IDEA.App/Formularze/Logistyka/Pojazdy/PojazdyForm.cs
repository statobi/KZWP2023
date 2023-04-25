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
        //private IDEAEntities db;
        Pojazd selectedPojazd = new Pojazd();
        public PojazdyForm()
        {
            InitializeComponent();
            InitGridPojazd();
        }
        private void InitGridPojazd()
        {
            dgv_pojazdymain.DataSource = db.Pojazdy_All.ToList();
            dgv_pojazdymain.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }
        private void PojazdyForm_Load(object sender, EventArgs e)
        {
            dgv_pojazdymain.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dgv_pojazdymain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flagSelected = true;
            int index;
            index = dgv_pojazdymain.CurrentRow.Index;

            DataGridViewRow selectedrow = dgv_pojazdymain.Rows[index];
            selectedPojazd.ID_Pojazd = int.Parse(selectedrow.Cells[0].Value.ToString());
            selectedPojazd.NrRejestracyjny = selectedrow.Cells[1].Value.ToString();
 
            /*
            selectedPojazd.ModelePojazdu = selectedrow.Cells[2].Value.ToString();
            selectedPojazd.Nazwa_Podmiotu = selectedrow.Cells[3].Value.ToString();
            selectedPojazd.NIP = selectedrow.Cells[4].Value.ToString();
            selectedPojazd.Adres_Ulica = selectedrow.Cells[5].Value.ToString();
            selectedPojazd.Adres_Kod_Pocztowy = selectedrow.Cells[6].Value.ToString();
            selectedPojazd.Adres_Miasto = selectedrow.Cells[7].Value.ToString();
            selectedPojazd.Telefon = selectedrow.Cells[8].Value.ToString();
            selectedPojazd.E_mail = selectedrow.Cells[9].Value.ToString(); */
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

        private void btn_odswiez_Click(object sender, EventArgs e)
        {
            dgv_pojazdymain.DataSource = db.Pojazdy_All.ToList();
            dgv_pojazdymain.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
