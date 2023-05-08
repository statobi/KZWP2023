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
        float kosztN = 0, kosztB = 0;
        int dostawaID = 0, materialID = 0;
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
            dgvSkladDostawy.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSkladDostawy.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSkladDostawy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvSkladDostawy.ClearSelection();
            //refreshDgvLista();
            //chceckControlsContent();
        }

        private void tbKosztB_Leave(object sender, EventArgs e)
        {
            float.TryParse(tbKosztB.Text, out kosztB);
            tbKosztN.Text = (kosztB * 0.813).ToString(("#.##"));
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

                //clearControls();
                //chceckControlsContent();
            
        }
        private void cbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
             Int32.TryParse(cbMaterial.SelectedValue.ToString(), out materialID);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void tbKosztN_Leave(object sender, EventArgs e)
        {
            float.TryParse(tbKosztN.Text, out kosztN);
            tbKosztB.Text = (kosztN * 1.23).ToString(("#.##"));
        }


    }
}
