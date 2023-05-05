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
    public partial class MaterialCU : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        public MaterialCU()
        {
            InitializeComponent();
            InitCBRodajMaterialu();
            InitrJednostka();
        }

        private void InitCBRodajMaterialu()
        {
            var rodzaje = db.Rodzaj_Materialu
                .Select(x =>x.Nazwa).ToList();
            cbRodzajMaterialu.DataSource = rodzaje;
            cbRodzajMaterialu.SelectedIndex = -1;
        }

        private void InitrJednostka()
        {
            var jednostki = db.Jednostka_miary
                .Select(x =>x.Nazwa).ToList();
            cbJednostka.DataSource = jednostki;
            cbJednostka.SelectedIndex = -1;
        }

        private void DodawanieMaterialu()
        {
            Material NewMaterial= new Material();

            var idrodzaju = db.Rodzaj_Materialu
                .Where(x => x.Nazwa== cbRodzajMaterialu.Text)
                .Select(x => x.ID_Rodzaj_Materialu)
                .FirstOrDefault();

            NewMaterial.ID_Rodzaj_Materialu = idrodzaju;

            var idjednostki = db.Jednostka_miary
                .Where(x => x.Nazwa== cbJednostka.Text)
                .Select(x =>x.ID_Jednostka_miary) 
                .FirstOrDefault();

            NewMaterial.ID_Jednostka_miary = idjednostki;
            NewMaterial.Nazwa = txtNazwa.Text;
            NewMaterial.Glebokosc = double.Parse(txtGlebokosc.Text);
            NewMaterial.Szerokosc = double.Parse(txtSzerokosc.Text);
            NewMaterial.Wysokosc = double.Parse(txtWysokosc.Text);
            NewMaterial.Opis = txtOpis.Text;
            NewMaterial.Masa = double.Parse(txtMasa.Text);

            db.Materials.Add(NewMaterial);
            db.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DodawanieMaterialu();
        }
    }
}
