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

namespace IDEA.App.Formularze.Logistyka.Dostawy
{
    public partial class DostawyDodajForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        int skladSelectedRow = 1;
        float kosztN = 0, kosztB = 0;
        int dostawaID = 0, materialID = 0;
        int ilosc;
        int faktura;

        public class Sklad
        {
            public int ID_Material { get; set; }
            public string Nazwa { get; set; }
            public int Ilosc { get; set; }
            public int ID_Faktury { get; set; }
            public decimal KosztNetto { get; set; }
            public decimal KosztBrutto { get; set; }
        }
        public List<Sklad> listaSklad = new List<Sklad>();

        public DostawyDodajForm()
        {
            InitializeComponent();
            generateControlsContent();
            clearControls();
            cbDostawca.SelectedItem = null;
            cbMagazynier.SelectedItem = null;
            chceckControlsContent();
        }

        void generateControlsContent()
        {
            var queryDostawca = (from d in db.Dostawcies
                                   select new
                                   {
                                      IDdostawcy = d.ID_Dostawcy,
                                      Firma = d.NazwaFirmy 
                                   }).ToList();

            cbDostawca.DataSource = queryDostawca.ToList();
            cbDostawca.DisplayMember = "Firma";
            cbDostawca.ValueMember = "IDdostawcy";

            var queryMaterial = (from m in db.Materials
                               select new
                               {
                                   ID_Material = m.ID_Material,
                                   Nazwa = m.Nazwa 
                               }).ToList();
            cbMaterial.DataSource = queryMaterial.ToList();
            cbMaterial.DisplayMember = "Nazwa";
            cbMaterial.ValueMember = "ID_Material";

            var queryMagazynier = (from prac in db.Pracownicies
                                   join d in db.Pracownicy_Stanowisko on prac.ID_Pracownicy equals d.ID_Pracownicy
                                   join s in db.Stanowiskoes on d.ID_Stanowisko equals s.ID_Stanowisko
                                   where s.Nazwa == "Magazynier"
                                   select new
                                   {
                                       ID_Pracownik = prac.ID_Pracownicy,
                                       Pracownik = prac.Imie + " " + prac.Nazwisko,
                                   }).ToList();
            cbMagazynier.DataSource = queryMagazynier.ToArray();
            cbMagazynier.DisplayMember = "Pracownik";
            cbMagazynier.ValueMember = "ID_Pracownik";
        }

        void clearControls()
        {
            dgvSkladDostawy.ClearSelection();
            cbMaterial.SelectedItem = null;
            tbFaktura.Text = null;
            tbIlosc.Text = null;
            tbKosztB.Text = null;
            tbKosztN.Text = null;   
        }

        void chceckControlsContent()
        {
            int.TryParse(tbIlosc.Text, out ilosc);
            //zapisz
            if (
               string.IsNullOrEmpty(cbDostawca.Text) == false
            && string.IsNullOrEmpty(cbMagazynier.Text) == false
            && listaSklad.Count > 0)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }

            //dodaj
            if (ilosc > 0
            && float.TryParse(tbKosztN.Text, out kosztN)
            && float.TryParse(tbKosztB.Text, out kosztB)
            && string.IsNullOrEmpty(cbMaterial.Text) == false)
            {
                BtnDodaj.Enabled = true;
            }
            else
            {
                BtnDodaj.Enabled = false;
            }
            //edytuj usun
            if (listaSklad.Count > 0 && dgvSkladDostawy.SelectedRows.Count > 0)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {

            //dodaj do Sklad dostawy
            var queryMaterial = (from m in db.Materials
                             where m.ID_Material == materialID
                             select new
                             {
                                 ID_Material = m.ID_Material,
                                 Nazwa = m.Nazwa,
                         }).ToList();


            foreach (var item in queryMaterial)
            {
                Sklad myClass = new Sklad
                {
                    ID_Material = Int32.Parse(item.ID_Material.ToString()),
                    Nazwa = item.Nazwa,
                    KosztNetto = Convert.ToDecimal(kosztN),
                    KosztBrutto = Convert.ToDecimal(kosztB),
                    Ilosc = Int32.Parse(tbIlosc.Text),
                    ID_Faktury = faktura,
                };
                listaSklad.Add(myClass);
            }

            dgvSkladDostawy.DataSource = listaSklad.ToList();
            dgvSkladDostawy.Columns["ID_Faktury"].Visible = false;
            dgvSkladDostawy.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSkladDostawy.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSkladDostawy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvSkladDostawy.ClearSelection();
            clearControls();
            chceckControlsContent();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            var newDostawa = new Dostawa
            {
                ID_Dostawcy = Int32.Parse(cbDostawca.SelectedValue.ToString()),
                ID_Pracownik = Int32.Parse(cbMagazynier.SelectedValue.ToString()),
                Data = System.DateTime.Parse(dtData.Text),
            };
            db.Dostawas.Add(newDostawa);
            db.SaveChanges();
            dostawaID = newDostawa.ID_Dostawa;


            foreach (var item in listaSklad)
            {
                var newSkladDostawa = new SkladDostawa_Material
                {
                    ID_Dostawa = dostawaID,
                    ID_Material = materialID,
                    Ilosc = item.Ilosc,
                    KosztNetto = item.KosztNetto,
                    KosztBrutto = item.KosztBrutto,
                    //ID_Faktury = item.ID_Faktury,

                };
                db.SkladDostawa_Material.Add(newSkladDostawa);
                db.SaveChanges();

                var newNP = new Nierozlozone_Materialy
                {
                    ID_Material = materialID,
                    Ilosc = item.Ilosc,
                    DataOd = System.DateTime.Parse(dtData.Text),
                };
                db.Nierozlozone_Materialy.Add(newNP);
                db.SaveChanges();
            }

            listaSklad.Clear();
            dgvSkladDostawy.DataSource = listaSklad.ToList();
            dgvSkladDostawy.ClearSelection();
            MessageBox.Show("Zapisano");

            clearControls();
            chceckControlsContent();
            
        }
        private void cbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            chceckControlsContent();
            if (!string.IsNullOrEmpty(cbMaterial.Text))
            {
                Int32.TryParse(cbMaterial.SelectedValue.ToString(), out materialID);
            }
        }

        private void cbDostawca_SelectedIndexChanged(object sender, EventArgs e)
        {
            chceckControlsContent();
        }

        private void dtData_ValueChanged(object sender, EventArgs e)
        {
            chceckControlsContent();
        }

        private void cbMagazynier_SelectedIndexChanged(object sender, EventArgs e)
        {
            chceckControlsContent();
        }

        private void tbIlosc_TextChanged(object sender, EventArgs e)
        {
            chceckControlsContent();
        }

        private void tbKosztN_TextChanged(object sender, EventArgs e)
        {
            chceckControlsContent();
        }

        private void tbKosztB_TextChanged(object sender, EventArgs e)
        {
            chceckControlsContent();
        }

        private void tbFaktura_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(tbFaktura.Text, out faktura);
            chceckControlsContent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listaSklad.RemoveAt(skladSelectedRow-1);
            dgvSkladDostawy.DataSource = listaSklad.ToList();
            dgvSkladDostawy.ClearSelection();
            chceckControlsContent();
        }

        private void dgvSkladDostawy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            skladSelectedRow = dgvSkladDostawy.CurrentCell.RowIndex + 1;
            chceckControlsContent();
        }

        private void tbKosztN_Leave(object sender, EventArgs e)
        {
            float.TryParse(tbKosztN.Text, out kosztN);
            tbKosztB.Text = (kosztN * 1.23).ToString(("#.##"));
            chceckControlsContent();
        }

        private void tbKosztB_Leave(object sender, EventArgs e)
        {
            float.TryParse(tbKosztB.Text, out kosztB);
            tbKosztN.Text = (kosztB * 0.813).ToString(("#.##"));
            chceckControlsContent();
        }

    }
}
