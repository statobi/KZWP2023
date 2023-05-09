using IDEA.Database;
using IDEA.Logistyka.Observer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IDEA.App.Formularze.Logistyka.Wysylki
{


    public partial class WysylkiDodajForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        CommonPublisher commonPublisher = CommonPublisher.GetInstance();

        int IDpro, IDsz, IDpojazd;
        int skladSelectedRow = 1;
        int wysylkaID = 0;
        bool overload = false;
        bool liczbaproduktow = false;
        int ilosc = 0, odleglosc;
        double masaProduktow;
        double nosnoscPojazdu;
        double objetoscProduktow;
        double objetoscZaladunkowa;
        double x, y, z, m;

        public class Sklad
        {
            public int ID_Zamowienia { get; set; } 
            public int IDSkladZamowienia { get; set; }
            public string NrZam { get; set; }
            public int IDProdukt { get; set; }
            public string Produkt { get; set; }
            public string Klient { get; set; }
            public int IDMagazyn { get; set; }
            public string Magazyn { get; set; }
            public int IDPracownik { get; set; }
            public string Pracownik { get; set; }
            public int Ilosc { get; set; }
            public double Szerokosc { get; set; }
            public double Wysokosc { get; set; }
            public double Glebokosc { get; set; }
            public double Masa { get; set; }

        }
        public List<Sklad> listaSklad = new List<Sklad>();
        public class ListaProduktow
        {
            public int ID_Zamowienia { get; set; }
            public int ID_SkladZamowienia { get; set; }
            public string NrZam { get; set; }
            public string Produkt { get; set; }
            public string Klient { get; set; }
            public int Ilosc { get; set; }
            public string Adres { get; set; }
            public string Status { get; set; }

        }
        public List<ListaProduktow> listaProduktow = new List<ListaProduktow>();

        public WysylkiDodajForm()
        {
            InitializeComponent();
            generateControlsContent();
            initDgvLista();
            chceckControlsContent();
            clearControls();
            lblLadownosc.Visible = false;
            cbPojazd.SelectedItem = null;
        }


        void initDgvLista()
        {
            listaProduktow.Clear();
            var queryLista = (from zk in db.Zamowienia_Klienci
                              join k in db.Klients on zk.ID_Klient equals k.ID_Klient
                              join sz in db.Sklad_Zamowienia on zk.ID_Zamowienia_Klienci equals sz.ID_Zamowienia_Klienci
                              join p in db.Produkts on sz.ID_Produkt equals p.ID_Produkt
                              join status in db.ZamowieniaKlienci_StatusZamowienia on zk.ID_Zamowienia_Klienci equals status.ID_Zamowienia_Klienci
                              join s in db.Status_Zamowienia on status.ID_Status_Zamowienia equals s.ID_Status_Zamowienia
                              where (status.ID_Status_Zamowienia == 4 && sz.Ilosc - sz.IloscWyslanychProduktow > 0)
                              select new
                              {
                                  ID_Zamównienia = zk.ID_Zamowienia_Klienci,
                                  ID_SkladZamowienia = sz.ID_Sklad_Zamowienia,
                                  Nr_zam = zk.Numer,
                                  Produkt = p.Nazwa,
                                  Ilość = sz.Ilosc - sz.IloscWyslanychProduktow,
                                  Klient = k.Imie + " " + k.Nazwisko,
                                  Adres = "ul. " + k.Adres_Ulica + ", " + k.Adres_Kod_Pocztowy + " " + k.Adres_Miasto,
                                  Status_zamowienia = s.Nazwa
                              }).ToList();

            foreach (var item in queryLista)
            {
                ListaProduktow myClass = new ListaProduktow
                {
                    ID_Zamowienia = Int32.Parse(item.ID_Zamównienia.ToString()),
                    ID_SkladZamowienia = Int32.Parse(item.ID_SkladZamowienia.ToString()),
                    NrZam = item.Nr_zam,
                    Produkt = item.Produkt.ToString(),
                    Klient = item.Klient.ToString(),
                    Ilosc = Int32.Parse(item.Ilość.ToString()),
                    Adres = item.Adres.ToString(),
                    Status = item.Status_zamowienia.ToString(),
                };
                listaProduktow.Add(myClass);
            }
            dgvLista.DataSource = listaProduktow.ToList();
            dgvLista.Columns["ID_SkladZamowienia"].Visible = false;
            dgvLista.Columns["ID_SkladZamowienia"].HeaderText = "Zam nr.";
            dgvLista.Columns["ID_Zamowienia"].Visible = false;
            dgvLista.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLista.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        void refreshDgvLista()
        {
            initDgvLista();
            //odejmij produkty
            foreach (var item in listaSklad)
            {
                for (int i = listaProduktow.Count; i > 0; i--)
                {
                    if (listaProduktow[i - 1].ID_SkladZamowienia == item.IDSkladZamowienia)
                    {
                        int n = listaProduktow[i - 1].Ilosc - item.Ilosc;
                        if (n < 0)
                        {
                            MessageBox.Show("Przekroczono liczbę produktów dla danego zamówienia");
                            liczbaproduktow = true;
                            return;
                        }
                        else
                            liczbaproduktow = false;
                            listaProduktow[i - 1].Ilosc = n;
                    }
                }
            }
            dgvLista.DataSource = listaProduktow.ToList();
        }



        void SprawdzLadownosc()
        {
            var queryDane = (from p in db.Produkts
                              where p.ID_Produkt == IDpro
                              select new
                              {
                                  sze = p.Szerokosc,
                                  wys = p.Wysokosc,
                                  gle = p.Glebokosc,
                                  mas = p.Masa
                              }).ToList();
            foreach (var item in queryDane)
            {
                x = item.sze; y = item.wys; z = item.gle; m = item.mas; 
            }

            masaProduktow = (ilosc * m);
            for (int i = listaSklad.Count; i > 0; i--)
            {
                masaProduktow = masaProduktow + (listaSklad[i - 1].Ilosc * listaSklad[i - 1].Masa);
            }

            objetoscProduktow = (ilosc * x * y * z) / 1000000000;
            for (int i = listaSklad.Count; i > 0; i--)
            {
                objetoscProduktow = objetoscProduktow + (listaSklad[i - 1].Ilosc * listaSklad[i - 1].Szerokosc * listaSklad[i - 1].Wysokosc * listaSklad[i - 1].Glebokosc) / 1000000000;
            }

            if(objetoscProduktow > objetoscZaladunkowa)
            {
                lblLadownosc.Text = "Przekroczono maksymalną objętość załadunkową pojazdu!";
                lblLadownosc.Visible = true;
                overload = true;
            }
            else if(masaProduktow > nosnoscPojazdu)
            {
                lblLadownosc.Text = "Przekroczono dopuszczalną ładowność pojazdu!";
                lblLadownosc.Visible = true;
                overload = true;
            }
            else
            {
                overload = false;
                lblLadownosc.Visible = false;
            }

        }
        void generateControlsContent()
        {
            var queryZamowienie = (from zk in db.Zamowienia_Klienci
                                   join k in db.Klients on zk.ID_Klient equals k.ID_Klient
                                   join sz in db.Sklad_Zamowienia on zk.ID_Zamowienia_Klienci equals sz.ID_Zamowienia_Klienci
                                   join p in db.Produkts on sz.ID_Produkt equals p.ID_Produkt
                                   join status in db.ZamowieniaKlienci_StatusZamowienia on zk.ID_Zamowienia_Klienci equals status.ID_Zamowienia_Klienci
                                   join s in db.Status_Zamowienia on status.ID_Status_Zamowienia equals s.ID_Status_Zamowienia
                                   where status.ID_Status_Zamowienia == 4 && sz.Ilosc - sz.IloscWyslanychProduktow > 0
                                   select new
                                   {
                                       ID_Sklad = sz.ID_Sklad_Zamowienia,
                                       ID_Produkt = sz.ID_Produkt,
                                       Produkt = p.Nazwa + " [Zam. " + zk.Numer + "] ",
                                   }).ToList();

            cbZamowienie.DataSource = queryZamowienie.ToList();
            cbZamowienie.DisplayMember = "Produkt";
            cbZamowienie.ValueMember = "ID_Sklad";
            IDsz = Int32.Parse(cbZamowienie.SelectedValue.ToString());
            cbZamowienie.ValueMember = "ID_Produkt";
            IDpro = Int32.Parse(cbZamowienie.SelectedValue.ToString());



            var queryKierowca = (from prac in db.Pracownicies
                                 join d in db.Pracownicy_Stanowisko on prac.ID_Pracownicy equals d.ID_Pracownicy
                                 join s in db.Stanowiskoes on d.ID_Stanowisko equals s.ID_Stanowisko
                                 where s.Nazwa == "Kierowca"
                                 select new
                                 {
                                     ID_Pracownik = prac.ID_Pracownicy,
                                     Pracownik = prac.Imie + " " + prac.Nazwisko,
                                 }).ToList();
            cbKierowca.DataSource = queryKierowca.ToArray();
            cbKierowca.DisplayMember = "Pracownik";
            cbKierowca.ValueMember = "ID_Pracownik";


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


            var queryPojazd = (from p in db.Pojazds
                               join m in db.ModelePojazdus on p.ID_ModelPojazd equals m.ID_ModelPojazd
                               select new
                               {
                                   ID_Pojazd = p.ID_Pojazd,
                                   Pojazd = m.Marka + " " + m.Model + " [" + p.NrRejestracyjny + "]"
                               }).ToList();
            cbPojazd.DataSource = queryPojazd.ToList();
            cbPojazd.DisplayMember = "Pojazd";
            cbPojazd.ValueMember = "ID_Pojazd";
        }
        void clearControls()
        {
            dgvSkladWysylki.ClearSelection();
            cbKierowca.SelectedItem = null;
            cbMagazyn.SelectedItem = null;
            cbMagazynier.SelectedItem = null;
            cbPojazd.SelectedItem = null;
            cbZamowienie.SelectedItem = null;

        }
        void chceckControlsContent()
        {
            int.TryParse(tbIlosc.Text, out ilosc);
            //zapisz
            if (int.TryParse(tbOdleglosc.Text, out odleglosc)
            && string.IsNullOrEmpty(cbPojazd.Text) == false
            && string.IsNullOrEmpty(cbKierowca.Text) == false
            && listaSklad.Count > 0
            && liczbaproduktow == false
            && overload == false)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }

            //dodaj
            if (ilosc > 0
            && string.IsNullOrEmpty(cbMagazyn.Text) == false
            && string.IsNullOrEmpty(cbZamowienie.Text) == false
            && string.IsNullOrEmpty(cbMagazynier.Text) == false)
            {
                BtnDodaj.Enabled = true;
            }
            else
            {
                BtnDodaj.Enabled = false;
            }
             //edytuj usun
            if (listaSklad.Count>0 && dgvSkladWysylki.SelectedRows.Count > 0)
            {
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnEdit.Enabled =   false;
            }
            SprawdzLadownosc();
        }



        private void dgvSkladWysylki_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            skladSelectedRow = dgvSkladWysylki.CurrentCell.RowIndex + 1;
            chceckControlsContent();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            listaSklad.RemoveAt(skladSelectedRow-1);
            dgvSkladWysylki.DataSource = listaSklad.ToList();
            refreshDgvLista();
            chceckControlsContent();
            dgvSkladWysylki.ClearSelection();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            listaSklad.RemoveAt(skladSelectedRow - 1);

            var queryLista = (from zk in db.Zamowienia_Klienci
                              join k in db.Klients on zk.ID_Klient equals k.ID_Klient
                              join sz in db.Sklad_Zamowienia on zk.ID_Zamowienia_Klienci equals sz.ID_Zamowienia_Klienci
                              join p in db.Produkts on sz.ID_Produkt equals p.ID_Produkt
                              where sz.ID_Sklad_Zamowienia == IDsz
                              select new
                              {
                                  ID_Zamównienia = zk.ID_Zamowienia_Klienci,
                                  IDSklad = sz.ID_Sklad_Zamowienia,
                                  Produkt = p.Nazwa,
                                  IDProdukt = p.ID_Produkt,
                                  Klient = k.Imie + " " + k.Nazwisko,
                                  sze = p.Szerokosc,
                                  wys = p.Wysokosc,
                                  gle = p.Glebokosc,
                                  mas = p.Masa
                              }).ToList();


            foreach (var item in queryLista)
            {
                Sklad myClass = new Sklad
                {
                    ID_Zamowienia = Int32.Parse(item.ID_Zamównienia.ToString()),
                    IDSkladZamowienia = item.IDSklad,
                    IDProdukt = item.IDProdukt,
                    Produkt = item.Produkt.ToString(),
                    IDMagazyn = Int32.Parse(cbMagazyn.SelectedValue.ToString()),
                    Magazyn = cbMagazyn.Text.ToString(),
                    IDPracownik = Int32.Parse(cbMagazynier.SelectedValue.ToString()),
                    Pracownik = cbMagazynier.Text.ToString(),
                    Klient = item.Klient.ToString(),
                    Ilosc = Int32.Parse(tbIlosc.Text),
                    Szerokosc = item.sze,
                    Wysokosc = item.wys,
                    Glebokosc = item.gle,
                    Masa = item.mas,

                };
                listaSklad.Insert(skladSelectedRow - 1, myClass);
            }
            dgvSkladWysylki.DataSource = listaSklad.ToList();
            dgvSkladWysylki.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSkladWysylki.ClearSelection();
            refreshDgvLista();
            chceckControlsContent();
        }
        private void BtnDodaj_Click(object sender, EventArgs e)
        {

            //dodaj do Sklad zamowienia
            var queryLista = (from zk in db.Zamowienia_Klienci
                              join k in db.Klients on zk.ID_Klient equals k.ID_Klient
                              join sz in db.Sklad_Zamowienia on zk.ID_Zamowienia_Klienci equals sz.ID_Zamowienia_Klienci
                              join p in db.Produkts on sz.ID_Produkt equals p.ID_Produkt
                              where sz.ID_Sklad_Zamowienia == IDsz
                              select new
                              {
                                  ID_Zamównienia = zk.ID_Zamowienia_Klienci,
                                  IDSklad = sz.ID_Sklad_Zamowienia,
                                  Nr_zam = zk.Numer,
                                  Produkt = p.Nazwa,
                                  IDProdukt = p.ID_Produkt,
                                  Klient = k.Imie + " " + k.Nazwisko,
                                  sze = p.Szerokosc,
                                  wys = p.Wysokosc,
                                  gle = p.Glebokosc,
                                  mas = p.Masa
                              }).ToList();


            foreach (var item in queryLista)
            {
                Sklad myClass = new Sklad
                {
                    ID_Zamowienia = Int32.Parse(item.ID_Zamównienia.ToString()),
                    IDSkladZamowienia = item.IDSklad,
                    NrZam = item.Nr_zam,
                    IDProdukt = item.IDProdukt,
                    Produkt = item.Produkt.ToString(),
                    IDMagazyn = Int32.Parse(cbMagazyn.SelectedValue.ToString()),
                    Magazyn = cbMagazyn.Text.ToString(),
                    IDPracownik = Int32.Parse(cbMagazynier.SelectedValue.ToString()),
                    Pracownik = cbMagazynier.Text.ToString(),
                    Klient = item.Klient.ToString(),
                    Ilosc = Int32.Parse(tbIlosc.Text),
                    Szerokosc = item.sze,
                    Wysokosc = item.wys,
                    Glebokosc = item.gle,
                    Masa = item.mas,

                };
                listaSklad.Add(myClass);
            }
            dgvSkladWysylki.DataSource = listaSklad.ToList();
            dgvSkladWysylki.Columns["IDMagazyn"].Visible = false;
            dgvSkladWysylki.Columns["IDPracownik"].Visible = false;
            dgvSkladWysylki.Columns["IDProdukt"].Visible = false;
            dgvSkladWysylki.Columns["IDSkladZamowienia"].Visible = false;
            dgvSkladWysylki.Columns["ID_Zamowienia"].Visible = false;
            dgvSkladWysylki.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSkladWysylki.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSkladWysylki.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvSkladWysylki.ClearSelection();
            refreshDgvLista();
            chceckControlsContent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var newWysylka = new Wysylka
            {
                ID_Pojazd = Int32.Parse(cbPojazd.SelectedValue.ToString()),
                ID_Pracownik = Int32.Parse(cbKierowca.SelectedValue.ToString()),
                Odleglosc = odleglosc,
                Data = System.DateTime.Parse(dtData.Text),
            };
            db.Wysylkas.Add(newWysylka);
            db.SaveChanges();
            wysylkaID = newWysylka.ID_Wysylka;


            foreach(var item in listaSklad)
            {
                var newSkladWysylka = new SkladWysylka_Produkt
                {
                    ID_Wysylka = wysylkaID,
                    ID_ZamowieniaKlienci = item.ID_Zamowienia,
                    ID_Pracownik = item.IDPracownik,
                    ID_Magazyn = item.IDMagazyn,
                    ID_Produkt = item.IDProdukt,
                    Ilosc = item.Ilosc,
                };
                db.SkladWysylka_Produkt.Add(newSkladWysylka);
                db.SaveChanges();

                using (var context = new IDEAEntities())
                {
                    var substract = context.Sklad_Zamowienia.SingleOrDefault(d => d.ID_Sklad_Zamowienia == item.IDSkladZamowienia);
                    substract.IloscWyslanychProduktow = substract.IloscWyslanychProduktow + item.Ilosc;
                    context.SaveChanges();
                }
            }
            listaProduktow.Clear();
            listaSklad.Clear();            
            dgvSkladWysylki.DataSource = listaSklad.ToList();
            dgvSkladWysylki.ClearSelection();
            db.SaveChanges();
            MessageBox.Show("Zapisano");

            initDgvLista();
            clearControls();
            chceckControlsContent();
        }



        private void cbZamowienie_SelectedIndexChanged(object sender, EventArgs e)
        {
            chceckControlsContent();

            if (!string.IsNullOrEmpty(cbZamowienie.Text))
            {
                cbZamowienie.ValueMember = "ID_Sklad";
                IDsz = Int32.Parse(cbZamowienie.SelectedValue.ToString());
                cbZamowienie.ValueMember = "ID_Produkt";
                IDpro = Int32.Parse(cbZamowienie.SelectedValue.ToString());
            }
        }
        private void cbPojazd_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(cbPojazd.Text))
            {
                int.TryParse(cbPojazd.SelectedValue.ToString(), out IDpojazd);

                var queryPojazd = (from poj in db.Pojazds
                                   join p in db.ModelePojazdus on poj.ID_ModelPojazd equals p.ID_ModelPojazd
                                   where poj.ID_Pojazd == IDpojazd
                                   select new
                                   {
                                       sze = p.Szerokosc,
                                       wys = p.Wysokosc,
                                       gle = p.Glebokosc,
                                       mas = p.Nosnosc
                                   }).ToList();
                foreach (var item in queryPojazd)
                {
                    x = item.sze; y = item.wys; z = item.gle; nosnoscPojazdu = item.mas;
                }
                objetoscZaladunkowa = x * y * z;

            }
            SprawdzLadownosc();
            chceckControlsContent();

        }
        private void cbKierowca_SelectedIndexChanged(object sender, EventArgs e)
        {
            chceckControlsContent();

        }
        private void cbMagazyn_SelectedIndexChanged(object sender, EventArgs e)
        {
            chceckControlsContent();

        }
        private void cbMagazynier_SelectedIndexChanged(object sender, EventArgs e)
        {
            chceckControlsContent();

        }
        private void dtData_ValueChanged(object sender, EventArgs e)
        {
            chceckControlsContent();
        }
        private void tbOdleglosc_TextChanged(object sender, EventArgs e)
        {
            chceckControlsContent();
        }
        private void tbIlosc_TextChanged(object sender, EventArgs e)
        {
            chceckControlsContent();

            int.TryParse(tbIlosc.Text, out ilosc);
            if (!string.IsNullOrEmpty(cbPojazd.Text))
            {
                SprawdzLadownosc();
            }
        }

        private void WysylkiDodajForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(listaSklad.Count > 0)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    DialogResult result = MessageBox.Show("Czy na pewno chcesz wyjść?\nNiezapisane zmiany zostaną utracone", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                commonPublisher.Notify<WysylkiForm>();
            }
        }
    }
}
