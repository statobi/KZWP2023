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


            var queryMagazyn = (from m in db.Magazyns
                                select new
                                {
                                    ID_Magazyn = m.ID_Magazyn,
                                    Magazyn = m.Nazwa,
                                }).ToList();
            cbMagazyn.DataSource = queryMagazyn.ToArray();
            cbMagazyn.DisplayMember = "Magazyn";
            cbMagazyn.ValueMember = "ID_Magazyn";


            var queryMaterial = (from m in db.Materials
                               select new
                               {
                                   ID_Material = m.ID_Material,
                                   Nazwa = m.Nazwa 
                               }).ToList();
            cbMaterial.DataSource = queryMaterial.ToList();
            cbMaterial.DisplayMember = "Nazwa";
            cbMaterial.ValueMember = "ID_Material";
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            //var newDostawy = new Wysylka
            //{
            //    ID_Pojazd = Int32.Parse(cbPojazd.SelectedValue.ToString()),
            //    ID_Pracownik = Int32.Parse(cbKierowca.SelectedValue.ToString()),
            //    Odleglosc = odleglosc,
            //    Data = System.DateTime.Parse(dtData.Text),
            //};
            //db.Wysylkas.Add(newWysylka);
            //db.SaveChanges();
            //wysylkaID = newWysylka.ID_Wysylka;


            //foreach (var item in listaSklad)
            //{
            //    var newSkladWysylka = new SkladWysylka_Produkt
            //    {
            //        ID_Wysylka = wysylkaID,
            //        ID_ZamowieniaKlienci = item.ID_Zamowienia,
            //        ID_Pracownik = item.IDPracownik,
            //        ID_Magazyn = item.IDMagazyn,
            //        ID_Produkt = item.IDProdukt,
            //        Ilosc = item.Ilosc,
            //    };
            //    db.SkladWysylka_Produkt.Add(newSkladWysylka);
            //    db.SaveChanges();

            //    using (var context = new IDEAEntities())
            //    {
            //        var substract = context.Sklad_Zamowienia.SingleOrDefault(d => d.ID_Sklad_Zamowienia == item.IDSkladZamowienia);
            //        substract.IloscWyslanychProduktow = substract.IloscWyslanychProduktow + item.Ilosc;
            //        context.SaveChanges();
            //    }
            //}
            //listaProduktow.Clear();
            //listaSklad.Clear();
            //dgvSkladWysylki.DataSource = listaSklad.ToList();
            //dgvSkladWysylki.ClearSelection();
            //db.SaveChanges();
            //MessageBox.Show("Zapisano");

            //initDgvLista();
            //clearControls();
            //chceckControlsContent();
        }


        private void tbKosztB_Leave(object sender, EventArgs e)
        {
            float.TryParse(tbKosztB.Text, out kosztB);
            tbKosztN.Text = (kosztB * 0.813).ToString(("#.##"));
        }

        private void tbKosztN_Leave(object sender, EventArgs e)
        {
            float.TryParse(tbKosztN.Text, out kosztN);
            tbKosztB.Text = (kosztN * 1.23).ToString(("#.##"));
        }
    }
}
