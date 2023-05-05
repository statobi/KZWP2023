﻿using IDEA.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEA.App.Formularze.Logistyka.Transport_wewnetrzny
{
    public partial class DodajTransportWewnetrznyForm : Form
    {
        IDEAEntities db = IDEADatabase.GetInstance();
        int IDzlecenie, IDpojazd;
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
                label7.Text = objetoscZaladunkowa.ToString() + " " + "l";
                label8.Text = nosnoscPojazdu.ToString() + " " + "kg";
            }
        }

        double objetoscZaladunkowa;
        double x, y, z, m;
        public DodajTransportWewnetrznyForm()
        {
            InitializeComponent();
            initCombobox();
            lbl_sprawdz_stan.Visible = false;
            masaMaterialow = 0;
            objetoscMaterialow = 0;
            masaProduktow = 0;
            objetoscProduktow = 0;


        }
        private void initCombobox()
        {
            var query1 = from p in db.Zlecenie_Magazynowe
                         select new { p.ID_Zlecenie_Magazynowe, Data ="nr" + " "+p.ID_Zlecenie_Magazynowe + "   " + p.Data };
            cb_Zlecenie_magazynowe.DataSource = query1.ToList();
            cb_Zlecenie_magazynowe.ValueMember = "ID_Zlecenie_Magazynowe";
            cb_Zlecenie_magazynowe.DisplayMember = "Data";
            cb_Zlecenie_magazynowe.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Zlecenie_magazynowe.SelectedIndex = -1;

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
            if (!string.IsNullOrEmpty(cb_Zlecenie_magazynowe.Text))
            {
                int.TryParse(cb_Zlecenie_magazynowe.SelectedValue.ToString(), out IDzlecenie);
            }
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
            var queryProdukt = (from p in db.Zlecenie_Magazynowe

                                join gg in db.Sklad_Zlecenie_Produkt on p.ID_Zlecenie_Magazynowe equals gg.ID_Zlecenie_Magazynowe

                                join hh in db.Produkts on gg.ID_Produkt equals hh.ID_Produkt


                                where p.ID_Zlecenie_Magazynowe == IDzlecenie
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
                                 where p.ID_Zlecenie_Magazynowe == IDzlecenie
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
                objetoscProduktow = objetoscProduktow + (queryProdukt[i - 1].iloscProduktu * queryProdukt[i - 1].szerokoscProduktu * queryProdukt[i - 1].wysokoscProduktu * queryProdukt[i - 1].glebokoscProduktu) / 1000000;
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
            label9.Text = objetoscMaterialow.ToString() + " " + "l";
            label10.Text = masaMaterialow.ToString() + " " + "kg";

            label11.Text = objetoscProduktow.ToString() + " " + "l";
            label12.Text = masaProduktow.ToString() + " " + "kg";
            label13.Text = objetoscZamowienia.ToString();
            if (objetoscProduktow + objetoscMaterialow > objetoscZaladunkowa)
            {
                lbl_sprawdz_stan.Text = "Przekroczono maksymalną objętość załadunkową pojazdu!";
                lbl_sprawdz_stan.Visible = true;

            }
            else if (masaProduktow + masaMaterialow > nosnoscPojazdu)
            {
                lbl_sprawdz_stan.Text = "Przekroczono dopuszczalną ładowność pojazdu!";
                lbl_sprawdz_stan.Visible = true;

            }
            else
            {
                lbl_sprawdz_stan.Visible = false;
            }

        }
        private void btn_dodaj_transport_Click(object sender, EventArgs e)
        {
            int idZlecenie, idMagazynPocz, idMagazynKonc, idPracownik, idPojazd;
            DateTime data;

            if (!int.TryParse(cb_Zlecenie_magazynowe.SelectedValue?.ToString(), out idZlecenie))
            {
                MessageBox.Show("Nie wybrano zlecenia magazynowego!");
                return;
            }

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

            var newTW = new TransportWewnetrzny
            {
                ID_Zlecenie_Magazynowe = idZlecenie,
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
