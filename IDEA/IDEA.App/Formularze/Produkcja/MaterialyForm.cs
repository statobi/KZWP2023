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
    }
}
