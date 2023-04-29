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

namespace IDEA.App.Formularze.Logistyka.Transport_wewnetrzny
{
    public partial class TransportWewnetrznyForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        public TransportWewnetrznyForm()
        {
            InitializeComponent();
            initgrid_TW();
        }
        private void initgrid_TW()
        {
            dgv_sklad_zamowienia_material.DataSource = db.Transport_wewnetrzny_Material.ToList();
            dgv_sklad_zamowienia_produkt.DataSource = db.Transport_wewnetrzny_Produkt.ToList();
            dgv_dostepne_pojazd.DataSource = db.Dostepne_Pojazdy.ToList();
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
        }
    }
}
