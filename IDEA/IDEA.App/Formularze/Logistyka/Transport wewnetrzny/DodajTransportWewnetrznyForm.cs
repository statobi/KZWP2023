using IDEA.App.Models;
using IDEA.Database;
using IDEA.Logistyka.Observer;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Transport_wewnetrzny
{
    public partial class DodajTransportWewnetrznyForm : Form, IRequestSubscriber
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        int IDpojazd;
        double spr, wpr, gpr, mpr;
        double spo, wpo, gpo, mpo;
        double sma, wma, gma, mma;
        int ip, im;
        double masaZamowienia;
        double nosnoscPojazdu;
        double objetoscZamowienia;
        double objetoscPojazdu;
        int IDmagazynPoczatkowy;
        double masaProduktow, masaMaterialow;
        double objetoscProduktow, objetoscMaterialow;
        

        private int IDZlecenie;

        private readonly CommonPublisher _commonPublisher = CommonPublisher.GetInstance();

        public DodajTransportWewnetrznyForm()
        {
            InitializeComponent();
            initCombobox();
            lbl_sprawdz_stan.Visible = false;
            masaMaterialow = 0;
            objetoscMaterialow = 0;
            masaProduktow = 0;
            objetoscProduktow = 0;
            _commonPublisher.Subscribe(this);
            lbl_masa_materialow.Visible = false;
            lbl_masa_produktow.Visible = false;
            lbl_Masa_Zamowienia.Visible = false;
            lbl_nosnosc_pojazdu.Visible = false;
            lbl_objetosc_materialow.Visible = false;
            lbl_objetosc_pojazdu.Visible = false;
            lbl_objetosc_produktow.Visible = false;
            label10.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            lbl_Objetosc_Zamowienia.Visible = false;

        }

        public void GetData(object message)
        {
            if (message is DodajTransportWewnetrznyInput input)
            {
                IDZlecenie = input.IdZlecenieMagazynowe;
            }
        }

        private void cb_pojazd_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            masaMaterialow = 0;
            objetoscMaterialow = 0;
            masaProduktow = 0;
            objetoscProduktow = 0;
            if (!string.IsNullOrEmpty(cb_pojazd.Text))
            {
                int.TryParse(cb_pojazd.SelectedValue.ToString(), out IDpojazd);

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
                objetoscZaladunkowa = (x * y * z)*1000;
                lbl_objetosc_pojazdu.Text = objetoscZaladunkowa.ToString() + " " + "l";
                lbl_nosnosc_pojazdu.Text = nosnoscPojazdu.ToString() + " " + "kg";
            }
        }


        double objetoscZaladunkowa;
        double x, y, z, m; //zmienne wymiarow pojazdow

        private void initCombobox()
        {

            var query2 = from p in db.Magazyns
                         select new { p.ID_Magazyn, Data = p.Nazwa };
            cb_magazyn_poczatkowy.DataSource = query2.ToList();

            cb_magazyn_poczatkowy.DisplayMember = "Data";
            cb_magazyn_poczatkowy.ValueMember = "ID_Magazyn";
            cb_magazyn_poczatkowy.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_magazyn_poczatkowy.SelectedIndex = -1;

            var query3 = from p in db.Magazyns
                         select new { p.ID_Magazyn, Data = p.Nazwa };
            cb_magazyn_koncowy.DataSource = query3.ToList();
            cb_magazyn_koncowy.DisplayMember = "Data";
            cb_magazyn_koncowy.ValueMember = "ID_Magazyn";
            cb_magazyn_koncowy.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_magazyn_koncowy.SelectedIndex = -1;

            var query4 = from p in db.Pracownicies
                         join d in db.Pracownicy_Stanowisko on p.ID_Pracownicy equals d.ID_Pracownicy
                         join s in db.Stanowiskoes on d.ID_Stanowisko equals s.ID_Stanowisko
                         where s.Nazwa == "Kierowca"
                         select new { p.ID_Pracownicy, ImieNazwisko = p.Imie + " " + p.Nazwisko };
            cb_pracownik.DataSource = query4.ToList();
            cb_pracownik.ValueMember = "ID_Pracownicy";
            cb_pracownik.DisplayMember = "ImieNazwisko";
            cb_pracownik.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_pracownik.SelectedIndex = -1;

            var query5 = from p in db.Dostepne_Pojazdy
                         select new { p.ID_Pojazd, Model = p.Marka + " " + p.Model + " " + p.Numer_rejestracyjny };
            cb_pojazd.DataSource = query5.ToList();
            cb_pojazd.DisplayMember = "Model";
            cb_pojazd.ValueMember = "ID_Pojazd";
            cb_pojazd.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_pojazd.SelectedIndex = -1;
        }
        private void panelMove_Paint(object sender, PaintEventArgs e)
        {

        }
        private void cb_magazyn_poczatkowy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_magazyn_poczatkowy.SelectedIndex >= 0 && !string.IsNullOrEmpty(cb_magazyn_poczatkowy.SelectedIndex.ToString()))
            {
                Int32.TryParse(cb_magazyn_poczatkowy.SelectedValue.ToString(), out IDmagazynPoczatkowy);

                var query = (from p in db.Magazyns
                             where p.ID_Magazyn != IDmagazynPoczatkowy
                             select new { p.ID_Magazyn, Data = p.Nazwa }).ToList();


                cb_magazyn_koncowy.DataSource = query.ToList();

                cb_magazyn_koncowy.DisplayMember = "Data";
                cb_magazyn_koncowy.ValueMember = "ID_Magazyn";
                cb_magazyn_koncowy.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }


        private void btn_anuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cb_Zlecenie_magazynowe_SelectedIndexChanged(object sender, EventArgs e)
        {
            masaMaterialow = 0;
            objetoscMaterialow = 0;
            masaProduktow = 0;
            objetoscProduktow = 0;
            //if (!string.IsNullOrEmpty(cb_Zlecenie_magazynowe.Text))
            //{
            //    int.TryParse(cb_Zlecenie_magazynowe.SelectedValue.ToString(), out IDzlecenie);
            //}
            masaProduktow = 0;
            SprawdzLadownosc();
        }

        private void cb_magazyn_koncowy_SelectedIndexChanged(object sender, EventArgs e)
        {
            masaMaterialow = 0;
            objetoscMaterialow = 0;
            masaProduktow = 0;
            objetoscProduktow = 0;
            SprawdzLadownosc();
        }

        private void cb_pracownik_SelectedIndexChanged(object sender, EventArgs e)
        {
            masaMaterialow = 0;
            objetoscMaterialow = 0;
            masaProduktow = 0;
            objetoscProduktow = 0;
            SprawdzLadownosc();
        }

        private void cb_pojazd_SelectedIndexChanged(object sender, EventArgs e)
        {
            masaMaterialow = 0;
            objetoscMaterialow = 0;
            masaProduktow = 0;
            objetoscProduktow = 0;
            SprawdzLadownosc();
        }
        void SprawdzLadownosc()
        {
            mpr = 0;

            var queryProdukt = (from p in db.Zlecenie_Magazynowe

                                join gg in db.Sklad_Zlecenie_Produkt on p.ID_Zlecenie_Magazynowe equals gg.ID_Zlecenie_Magazynowe

                                join hh in db.Produkts on gg.ID_Produkt equals hh.ID_Produkt


                                where p.ID_Zlecenie_Magazynowe == IDZlecenie
                                select new
                                {
                                    szerokoscProduktu = hh.Szerokosc,
                                    wysokoscProduktu = hh.Wysokosc,
                                    glebokoscProduktu = hh.Glebokosc,
                                    masaProduktu = hh.Masa,
                                    iloscProduktu= gg.IloscProduktow
                                }).ToList();

            var queryMaterial = (from p in db.Zlecenie_Magazynowe
                                 join dd in db.Sklad_Zlecenie_Magazynowe on p.ID_Zlecenie_Magazynowe equals dd.ID_Zlecenie_Magazynowe
                                 join jj in db.Materials on dd.ID_Material equals jj.ID_Material
                                 where p.ID_Zlecenie_Magazynowe == IDZlecenie
                                 select new
                                 {

                                     szerokoscMaterialu = jj.Szerokosc,
                                     wysokoscMaterialu = jj.Wysokosc,
                                     glebokoscMaterialu = jj.Glebokosc,
                                     masaMaterialu = jj.Masa,
                                     dd.IloscMaterialow

                                 }).ToList();
            spr = 0; wpr = 0; gpr = 0; ip = 0; masaMaterialow = 0; objetoscMaterialow = 0;
            masaProduktow = 0;
            foreach (var item in queryProdukt)
            {
                spr += item.szerokoscProduktu;
                wpr += item.wysokoscProduktu;
                gpr += item.glebokoscProduktu;
                mpr += item.masaProduktu;
                ip += item.iloscProduktu;
               
            }
            masaProduktow = (mpr * ip);
            //objetoscProduktow = (((spr * wpr * gpr) * ip) / (1000000));
            //masaProduktow = 0;
            //for (int i = queryProdukt.Count; i > 0; i--)
            //{
            //    masaProduktow +=  ((queryProdukt[i - 1].iloscProduktu * queryProdukt[i - 1].masaProduktu));
            //}

            objetoscProduktow = 0;
            for (int i = queryProdukt.Count; i > 0; i--)
            {
                objetoscProduktow = (queryProdukt[i - 1].iloscProduktu * queryProdukt[i - 1].szerokoscProduktu * queryProdukt[i - 1].wysokoscProduktu * queryProdukt[i - 1].glebokoscProduktu) *1000;
            }

            //materialy
            //foreach (var item in queryMaterial)
            //{
            //    x = item.szerokoscMaterialu.Value; y = item.wysokoscMaterialu.Value; z = item.glebokoscMaterialu.Value; m = item.masaMaterialu.Value;
            //}

            masaMaterialow = 0;
            for (int i = queryMaterial.Count; i > 0; i--)
            {
                masaMaterialow = masaMaterialow + (queryMaterial[i - 1].IloscMaterialow * queryMaterial[i - 1].masaMaterialu.Value);
            }

            objetoscMaterialow = 0;
            for (int i = queryMaterial.Count; i > 0; i--)
            {
                objetoscMaterialow = objetoscMaterialow + (queryMaterial[i - 1].IloscMaterialow * queryMaterial[i - 1].szerokoscMaterialu.Value * queryMaterial[i - 1].wysokoscMaterialu.Value * queryMaterial[i - 1].glebokoscMaterialu.Value) * 1000;
            }
            objetoscZamowienia = objetoscProduktow + objetoscMaterialow;
            masaZamowienia = masaProduktow + masaMaterialow;
            lbl_objetosc_materialow.Text = objetoscMaterialow.ToString() + " " + "l";
            lbl_masa_materialow.Text = masaMaterialow.ToString() + " " + "kg";

            lbl_objetosc_produktow.Text = objetoscProduktow.ToString() + " " + "l";
            lbl_masa_produktow.Text = masaProduktow.ToString() + " " + "kg";
            lbl_Objetosc_Zamowienia.Text = objetoscZamowienia.ToString() + " " + "l";
            lbl_Masa_Zamowienia.Text = masaZamowienia.ToString() + " " + "kg";


        }
        private void btn_dodaj_transport_Click(object sender, EventArgs e)
        {
            int idMagazynPocz, idMagazynKonc, idPracownik, idPojazd;
            DateTime data;


            if (!int.TryParse(cb_magazyn_poczatkowy.SelectedValue?.ToString(), out idMagazynPocz))
            {
                MessageBox.Show("Nie wybrano magazynu początkowego!");
                return;
            }

            if (!int.TryParse(cb_magazyn_koncowy.SelectedValue?.ToString(), out idMagazynKonc))
            {
                MessageBox.Show("Nie wybrano magazynu końcowego!");
                return;
            }

            if (!int.TryParse(cb_pracownik.SelectedValue?.ToString(), out idPracownik))
            {
                MessageBox.Show("Nie wybrano pracownika!");
                return;
            }

            if (!int.TryParse(cb_pojazd.SelectedValue?.ToString(), out idPojazd))
            {
                MessageBox.Show("Nie wybrano pojazdu!");
                return;
            }

            if (!DateTime.TryParse(dDataRealizacjiTransportu.Text, out data))
            {
                MessageBox.Show("Nieprawidłowy format daty!");
                return;
            }

            if (idMagazynPocz == idMagazynKonc)
            {
                MessageBox.Show("Magazyn początkowy i końcowy nie mogą być takie same!");
                return;
            }
            else if (masaZamowienia > nosnoscPojazdu)
            {
                MessageBox.Show("Masa zamówienia jest za duża, zmień pojazd!");
                return;
            }
            if (objetoscZamowienia > objetoscZaladunkowa)
            {
                MessageBox.Show("Objętość zamówienia jest za duża, zmień pojazd!");
                return;
            }
            var newTW = new TransportWewnetrzny
            {
                ID_Zlecenie_Magazynowe = IDZlecenie,
                ID_Magazyn_pocz = idMagazynPocz,
                ID_Magazyn_konc = idMagazynKonc,
                ID_Pracownik = idPracownik,
                ID_Pojazd = idPojazd,
                Data = data,
            };
            SprawdzLadownosc();
            db.TransportWewnetrznies.Add(newTW);
            db.SaveChanges();
            MessageBox.Show("Pomyślnie dodano Transport wewnętrzny");
            this.Close();
        }
    }
}
