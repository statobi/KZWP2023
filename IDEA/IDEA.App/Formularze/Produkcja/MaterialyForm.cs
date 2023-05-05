using IDEA.App.Models;
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
    public partial class MaterialyForm : Form
    {

        IDEAEntities db = IDEADatabase.GetInstance();
        int idmaterial;


        public MaterialyForm()
        {
            InitializeComponent();
            InitDwgMaterialy();
        }

        private void InitDwgMaterialy()
        {
            var PodgladMaterialu = db.Materials
                .Select(x => new PodgladMaterialu
                {
                    ID_Material = x.ID_Material,
                    ID_Rodzaj_Materialu = x.ID_Rodzaj_Materialu,
                    Nazwa_Materialu = x.Nazwa,
                    Rodzaj_Materialu = x.Rodzaj_Materialu.Nazwa,
                    Jednostka =  x.Jednostka_miary.Nazwa,
                    Szerokosc = (double)x.Szerokosc,
                    Glebokosc = (double)x.Glebokosc,
                    Wysokosc = (double)x.Wysokosc,
                    Masa = (double)x.Masa,
                    Opis = x.Opis
                })
                .ToList();
            dgvMaterial.DataSource = PodgladMaterialu;
            dgvMaterial.Columns["ID_Material"].Visible = false;
            dgvMaterial.Columns["ID_Rodzaj_Materialu"].Visible = false;
            dgvMaterial.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }



        private void MaterialyForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idmaterial = int.Parse(dgvMaterial.Rows[e.RowIndex].Cells[0].Value.ToString());

            WybranieWlasciwosci();
        }

        private void WybranieWlasciwosci()
        {
            var podgladwlasciwosic = db.Material_Wlasciwosc_Material
                .Where(x => x.ID_Material == idmaterial)
                .Select(x => new WlasciwosciMaterialu
                {
                    ID_Material = x.ID_Material,
                    Nazwa_Materialu = x.Material.Nazwa,
                    Nazwa_Wlasciwosci = x.Wlasciwosc_Materialu.Nazwa,
                    Wartosc = x.Wartosc,
                    Jednostka = x.Wlasciwosc_Materialu.Jednostka_miary.Nazwa
                })
                .ToList();
            dgvWlasciowsci.DataSource= podgladwlasciwosic;
            dgvWlasciowsci.Columns["ID_Material"].Visible = false;
            dgvWlasciowsci.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filtr = txtSearch.Text;
            var PodgladMaterialu = db.Materials
                .Where(x =>x.Nazwa.Contains(filtr) || x.Rodzaj_Materialu.Nazwa.Contains(filtr))
             .Select(x => new PodgladMaterialu
             {
                 ID_Material = x.ID_Material,
                 ID_Rodzaj_Materialu = x.ID_Rodzaj_Materialu,
                 Nazwa_Materialu = x.Nazwa,
                 Rodzaj_Materialu = x.Rodzaj_Materialu.Nazwa,
                 Jednostka = x.Jednostka_miary.Nazwa,
                 Szerokosc = (double)x.Szerokosc,
                 Glebokosc = (double)x.Glebokosc,
                 Wysokosc = (double)x.Wysokosc,
                 Masa = (double)x.Masa,
                 Opis = x.Opis
             })
             .ToList();
            dgvMaterial.DataSource = PodgladMaterialu;
            dgvMaterial.Columns["ID_Material"].Visible = false;
            dgvMaterial.Columns["ID_Rodzaj_Materialu"].Visible = false;
            dgvMaterial.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MaterialCU zw = new MaterialCU())
            {
                zw.ShowDialog();

            }
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            using (WlasciwosciMaterialuCU zw = new WlasciwosciMaterialuCU())
            {
                zw.ShowDialog();

            }
        }
    }
}
