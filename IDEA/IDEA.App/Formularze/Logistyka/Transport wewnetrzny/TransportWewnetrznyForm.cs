using IDEA.App.Formularze.Produkcja;
using IDEA.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Transport_wewnetrzny
{
    public partial class TransportWewnetrznyForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        private bool flagSelectedZlecenieMagazynowe = false;
        private bool flagSelectedSklad = false;
        Zlecenie_Magazynowe selectedMaterial = new Zlecenie_Magazynowe();
        public TransportWewnetrznyForm()
        {
            InitializeComponent();
            initgrid_TW();
        }
        private void initgrid_TW()
        {
            //dgv_sklad_zamowienia_material.DataSource = db.Transport_wewnetrzny_Material.ToList();
            //dgv_sklad_zamowienia_produkt.DataSource = db.Transport_wewnetrzny_Produkt.ToList();
            var query = from s in db.Zlecenie_Magazynowe 
                        orderby s.Data descending
                        select s;
            dgv_zlecenie_magazynowe.DataSource = query.ToList(); 
            dgv_dostepne_pojazd.DataSource = db.Dostepne_Pojazdy.ToList();
            dgv_zlecenie_magazynowe.DataSource = db.Zlecenie_Magazynowe.ToList();
            dgv_zlecenie_magazynowe.Columns["ID_Sklad_zamowienia"].Visible = false;
            dgv_zlecenie_magazynowe.Columns["ID_Pracownicy"].Visible = false;
            dgv_zlecenie_magazynowe.Columns["CzyZlecenieStale"].Visible = false;
            dgv_zlecenie_magazynowe.Columns["Zwrot"].Visible = false;
            dgv_zlecenie_magazynowe.Columns["Pracownicy"].Visible = false;
            dgv_zlecenie_magazynowe.Columns["Sklad_Zlecenie_Magazynowe"].Visible = false;
            dgv_zlecenie_magazynowe.Columns["Sklad_Zlecenie_Produkt"].Visible = false;
            dgv_zlecenie_magazynowe.Columns["ZleceniaStales"].Visible = false;
            dgv_zlecenie_magazynowe.Columns["TransportWewnetrznies"].Visible = false;
            dgv_zlecenie_magazynowe.Columns["Sklad_Zamowienia"].Visible = false;
        }


        private void dgv_sklad_zamowienia_material_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_sklad_zamowienia_produkt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_dostepne_pojazd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TransportWewnetrznyForm_Load(object sender, EventArgs e)
        {
            dgv_sklad_zamowienia_material.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv_sklad_zamowienia_produkt.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv_dostepne_pojazd.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv_zlecenie_magazynowe.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dgv_zlecenie_magazynowe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_zlecenie_magazynowe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flagSelectedZlecenieMagazynowe = true;
            int index;
            index = dgv_zlecenie_magazynowe.CurrentRow.Index;

            DataGridViewRow selectedrow = dgv_zlecenie_magazynowe.Rows[index];

            selectedMaterial.ID_Zlecenie_Magazynowe = int.Parse(selectedrow.Cells[0].Value.ToString());
            var query = from p in db.Zlecenie_Magazynowe
                        where p.ID_Zlecenie_Magazynowe == selectedMaterial.ID_Zlecenie_Magazynowe
                        select p;
            foreach (Zlecenie_Magazynowe p in query)
            {
                selectedMaterial.ID_Zlecenie_Magazynowe = p.ID_Zlecenie_Magazynowe;
                selectedMaterial.Uwagi = p.Uwagi;
                selectedMaterial.Data = p.Data;

            }
            InitSkladMaterial();
            InitSkladProdukt();
        }
        private void InitSkladMaterial()
        {
            var query3 = from s in db.Transport_wewnetrzny_Material
                         join sz in db.Zlecenie_Magazynowe on s.ID_Zlecenie_Magazynowe equals sz.ID_Zlecenie_Magazynowe
                         where s.ID_Zlecenie_Magazynowe == selectedMaterial.ID_Zlecenie_Magazynowe
                         select new
                         {
                             s.ID_Zlecenie_Magazynowe,
                             s.Material,
                             s.Ilosc_sztuk,
                             s.Objetosc_zamowienia,
                             s.Masa_zamowienia
                         };
                             
                             
            dgv_sklad_zamowienia_material.DataSource = query3.ToList();
        }
        private void InitSkladProdukt()
        {
            var query4 = from b in db.Transport_wewnetrzny_Produkt
                         join sz in db.Zlecenie_Magazynowe on b.ID_Zlecenie_Magazynowe equals sz.ID_Zlecenie_Magazynowe
                         where b.ID_Zlecenie_Magazynowe == selectedMaterial.ID_Zlecenie_Magazynowe
                         select new
                         {
                             b.ID_Zlecenie_Magazynowe,
                             b.Produkt,
                             b.Ilosc_sztuk,
                             b.Objetosc_zamowienia,
                             b.Masa_zamowienia
                            
                         };
            dgv_sklad_zamowienia_produkt.DataSource = query4.ToList();
        }

        private void btn_Dodaj_Transport_wewnetrzny_Click(object sender, EventArgs e)
        {
            using (DodajTransportWewnetrznyForm Pr = new DodajTransportWewnetrznyForm())
            {
                Pr.ShowDialog();
                InitDodajTransport();
            }
        }
        private void InitDodajTransport()
        {
            this.Size = new Size(600, 600);
        }
    }
    
}
