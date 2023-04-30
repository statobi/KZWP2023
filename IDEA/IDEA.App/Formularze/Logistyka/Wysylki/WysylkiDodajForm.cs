using IDEA.Database;
using System;
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

namespace IDEA.App.Formularze.Logistyka.Wysylki
{


    public partial class WysylkiDodajForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        int IDpro;
        int IDzk;
        int wysylkaID = 0;
        bool dodane = false;

        public class Sklad
        {
            public int Zam { get; set; }
            public string Pro { get; set; }
            public string Kli { get; set; }
            public int Ilo { get; set; }
        }
        public List<Sklad> lista = new List<Sklad>();

        public WysylkiDodajForm()
        {
            
            InitializeComponent();
            initDgvLista();

        }
        void initDgvLista()
        {
            var queryLista = (from zk in db.Zamowienia_Klienci
                              join k in db.Klients on zk.ID_Klient equals k.ID_Klient
                              join sz in db.Sklad_Zamowienia on zk.ID_Zamowienia_Klienci equals sz.ID_Zamowienia_Klienci
                              join p in db.Produkts on sz.ID_Produkt equals p.ID_Produkt
                              select new
                              {
                                  ID_Zamównienia = zk.ID_Zamowienia_Klienci,
                                  Produkt = p.Nazwa,
                                  Ilość = sz.Ilosc,
                                  Klient = k.Imie + " " + k.Nazwisko,
                              }).ToList();
  
            dgvLista.DataSource = queryLista.ToList();
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            var queryZamowienie = (from zk in db.Zamowienia_Klienci
                                   join k in db.Klients on zk.ID_Klient equals k.ID_Klient
                                   join sz in db.Sklad_Zamowienia on zk.ID_Zamowienia_Klienci equals sz.ID_Zamowienia_Klienci
                                   join p in db.Produkts on sz.ID_Produkt equals p.ID_Produkt
                                   //orderby zk.ID_Zamowienia_Klienci ascending
                                   select new
                                   {
                                       ID_Sklad = sz.ID_Sklad_Zamowienia,
                                       ID_Produkt = sz.ID_Produkt,
                                       Produkt = "[" + zk.ID_Zamowienia_Klienci + "] " + p.Nazwa,
                                   }).ToArray();

            cbZamowienie.DataSource = queryZamowienie.ToArray();
            cbZamowienie.DisplayMember = "Produkt";

            cbZamowienie.ValueMember = "ID_Sklad";
            IDzk = Int32.Parse(cbZamowienie.SelectedValue.ToString());
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

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            int ilosc;

            if (int.TryParse(tbIlosc.Text, out ilosc) && string.IsNullOrEmpty(cbPojazd.Text) == false)
            {
                var newWysylka = new Wysylka
                {
                    ID_Pracownik = Int32.Parse(cbMagazynier.SelectedValue.ToString()),
                    ID_ZamowieniaKlienci = IDzk,
                    ID_Magazyn = Int32.Parse(cbMagazyn.SelectedValue.ToString()),
                    Odleglosc = Int32.Parse(tbOdleglosc.Text),
                    Adres = tbAdres.Text,
                    Data = System.DateTime.Parse(dtData.Text),
                };

                if (!dodane)
                {
                    MessageBox.Show(IDzk.ToString());
                    db.Wysylkas.Add(newWysylka);
                    db.SaveChanges();
                    wysylkaID = newWysylka.ID_Wysylka;
                }
                dodane = true;

                var newSkladWysylka = new SkladWysylka_Produkt
                {
                    ID_Wysylka = wysylkaID,
                    ID_Pojazd = Int32.Parse(cbPojazd.SelectedValue.ToString()),
                    ID_Pracownik = Int32.Parse(cbKierowca.SelectedValue.ToString()),
                    ID_Produkt = Int32.Parse(cbZamowienie.SelectedValue.ToString()),
                    Ilosc = ilosc,
                };
                MessageBox.Show(wysylkaID.ToString());

                var queryLista = (from zk in db.Zamowienia_Klienci
                                  join k in db.Klients on zk.ID_Klient equals k.ID_Klient
                                  join sz in db.Sklad_Zamowienia on zk.ID_Zamowienia_Klienci equals sz.ID_Zamowienia_Klienci
                                  join p in db.Produkts on sz.ID_Produkt equals p.ID_Produkt
                                  where sz.ID_Sklad_Zamowienia == IDzk
                                  select new
                                  {
                                      ID_Zamównienia = zk.ID_Zamowienia_Klienci,
                                      Produkt = p.Nazwa,
                                      Ilość = sz.Ilosc,
                                      Klient = k.Imie + " " + k.Nazwisko,
                                  }).ToList();


                foreach (var item in queryLista)
                {
                    Sklad myClass = new Sklad
                    {
                        Zam = Int32.Parse(item.ID_Zamównienia.ToString()),
                        Pro = item.Produkt.ToString(),
                        Kli = item.Klient.ToString(),
                        Ilo = Int32.Parse(tbIlosc.Text)
                    };
                    lista.Add(myClass);
                }

                dgvSkladWysylki.DataSource = lista.ToList();
                db.SkladWysylka_Produkt.Add(newSkladWysylka);

                dgvLista.DataSource = queryLista.ToList();
                dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                //MessageBox.Show(IDzk.ToString());

                //db.Zamowienia_Klienci.Add()
                using (var context = new IDEAEntities())
                {
                    var substract = context.Sklad_Zamowienia.SingleOrDefault(d => d.ID_Sklad_Zamowienia == IDzk);
                    MessageBox.Show(substract.ToString());

                    substract.Ilosc = substract.Ilosc - Int32.Parse(tbIlosc.Text);
                    context.SaveChanges();
                }
                initDgvLista();
            }
        }

        private void cbZamowienie_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbZamowienie.ValueMember = "ID_Sklad";
            IDzk = Int32.Parse(cbZamowienie.SelectedValue.ToString());
            cbZamowienie.ValueMember = "ID_Produkt";
            IDpro = Int32.Parse(cbZamowienie.SelectedValue.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            MessageBox.Show("Uratowan");
        }
    }
}
