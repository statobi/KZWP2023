using IDEA.Database;
using System;
using System.Data;
using System.Linq;
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
            InitCBRodajZasobu();
        }

        private void InitCBRodajMaterialu()
        {
            var rodzaje = db.Rodzaj_Materialu
                .Select(x => x.Nazwa).ToList();
            cbRodzajMaterialu.DataSource = rodzaje;
            cbRodzajMaterialu.SelectedIndex = -1;
        }

        private void InitCBRodajZasobu()
        {
            var rodzaje = db.TypZasobus
                .Select(x => x.Nazwa).ToList();
            cbTypZasobu.DataSource = rodzaje;
            cbTypZasobu.SelectedIndex = -1;
        }

        private void InitrJednostka()
        {
            var jednostki = db.Jednostka_miary
                .Select(x => x.Nazwa).ToList();
            cbJednostka.DataSource = jednostki;
            cbJednostka.SelectedIndex = -1;
        }

        private void DodawanieMaterialu()
        {
            Material NewMaterial = new Material();

            var idrodzaju = db.Rodzaj_Materialu
                .Where(x => x.Nazwa == cbRodzajMaterialu.Text)
                .Select(x => x.ID_Rodzaj_Materialu)
                .FirstOrDefault();

            NewMaterial.ID_Rodzaj_Materialu = idrodzaju;

            var idjednostki = db.Jednostka_miary
                .Where(x => x.Nazwa == cbJednostka.Text)
                .Select(x => x.ID_Jednostka_miary)
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

        private void btnDodajRodzajProduktu_Click(object sender, EventArgs e)
        {
            gbNowyRodzajMaterialu.Visible = true;

        }

        private void DodawanieNowegoRodzajuMaterialu()
        {
            Rodzaj_Materialu NewRodzaj = new Rodzaj_Materialu();
            NewRodzaj.Nazwa = txtDodajNowyRodzajM.Text;

            var typzasobu = db.TypZasobus
               .Where(x => x.Nazwa == cbTypZasobu.Text)
               .Select(x => x.ID_TypZasobu)
               .FirstOrDefault();

            NewRodzaj.ID_TypZasobu = typzasobu;

            db.Rodzaj_Materialu.Add(NewRodzaj);
            db.SaveChanges();
            InitCBRodajMaterialu();

        }

        private void btnDodajNowyRodzajM_Click(object sender, EventArgs e)
        {
            DodawanieNowegoRodzajuMaterialu();
            InitCBRodajMaterialu();
            MessageBox.Show("Dodano nowy rodzaj materiału");
            //this.DialogResult = DialogResult.OK;
            //this.Close();
            gbNowyRodzajMaterialu.Visible = false;
        }

        private void iBtnBack_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.OK;
            //this.Close();
            gbNowyRodzajMaterialu.Visible = false;
        }
    }
}
