using IDEA.Database;
using System;
using System.Linq;

namespace IDEA.Produkcja
{
    public class AlgorytmWyznaczaniaDaty
    {
        IDEAEntities db = IDEADatabase.GetInstance();

        public string algorytmsprawdzaniadaty(int id)
        {
            string potwierdzenie = "";
            int IDZlecenia = id;


            double reszta = 0;

            int czescCalkowita = 0;
            int czescCalkowitaReszty = 0;

            var dataprzyjecia = db.Zamowienia_Klienci
                    .Where(x => x.ID_Zamowienia_Klienci == IDZlecenia)
                    .Select(x => x.Data_Zamowienia)
                    .FirstOrDefault();
            var datazakonczenia = db.Zamowienia_Klienci
                .Where(x => x.ID_Zamowienia_Klienci == IDZlecenia)
                .Select(x => x.Data_Realizacji)
                .FirstOrDefault();

            var listaCalegoSkladuZamowienia = db.Sklad_Zamowienia
                .Where(x => x.ID_Zamowienia_Klienci == IDZlecenia)
                .Select(x => x.ID_Sklad_Zamowienia).ToList();

            // var datadzis = DateTime.Now;
            // var datarozpoczecia = datadzis.Date;
            // var planowanadatazakonczenia = DateTime.Now;
            var planowanadatazakonczenia = dataprzyjecia;

            for (int i = 0; i < listaCalegoSkladuZamowienia.Count; i++)
            {


                int IDSkladuZamowienia = listaCalegoSkladuZamowienia[i];
                var IDProduktu = db.Sklad_Zamowienia
                .Where(x => x.ID_Sklad_Zamowienia == IDSkladuZamowienia)
                .Select(x => x.ID_Produkt)
                .FirstOrDefault();

                var IloscProduktuw = db.Sklad_Zamowienia
                .Where(x => x.ID_Sklad_Zamowienia == IDSkladuZamowienia && x.ID_Produkt == IDProduktu)
                .Select(x => x.Ilosc)
                .FirstOrDefault();



                var MaxKolejnosc = db.Proces_Technologiczny
                    .Where(x => x.ID_Produkt == IDProduktu)
                    .Max(x => x.Kolejnosc);

                for (int k = 1; k <= MaxKolejnosc; k++)
                {

                    var CzasTrwaniaProcesu = db.Proces_Technologiczny
                        .Where(x => x.ID_Produkt == IDProduktu && x.Kolejnosc == k)
                        .Select(x => x.Ilosc_Godzin)
                        .FirstOrDefault();

                    var wybranyproces = db.Proces_Technologiczny
                        .Where(x => x.ID_Produkt == IDProduktu && x.Kolejnosc == k)
                        .Select(x => x.ID_Proces_Technologiczny)
                        .FirstOrDefault();


                    //Logistyka
                    var dataDostepnosciMaterialu = planowanadatazakonczenia;

                    var potrzebneMaterialy = db.Proces_Technologiczny
                        .Where(x => x.ID_Proces_Technologiczny == wybranyproces && x.Kolejnosc == k)
                        .Select(x => x.Nazwa_Procesu)
                        .SelectMany(x => x.Proces_Technologiczny)
                        .SelectMany(x => x.Proces_Technologiczny_Material)
                         .Select(x => new
                         {
                             ID_Material = x.ID_Material,
                             Ilosc = x.Ilosc * IloscProduktuw,
                             Nazwa_Materialu = x.Material.Nazwa
                         })
                         .ToList();

                    var materialynaMagazynie = db.Sekcjas
                        .Where(x => x.ID_Magazyn == 1)
                        .SelectMany(x => x.Polkas)
                        .SelectMany(x => x.RozlozeniePolki_Materialy)
                        .Select(x => new
                        {
                            ID_Material = x.ID_Material,
                            Ilosc = x.Ilosc,
                            Nazwa_Materialu = x.Material.Nazwa,
                            Opis = x.Material.Opis
                        })
                        .GroupBy(x => x.ID_Material)
                        .Select(g => new
                        {
                            ID_Material = g.Key,
                            Ilosc = g.Sum(x => x.Ilosc),
                            Nazwa_Materialu = g.FirstOrDefault().Nazwa_Materialu,
                            Opis = g.FirstOrDefault().Opis
                        })
                        .ToList();

                    var zapotrzebowanie = from p in potrzebneMaterialy
                                          join m in materialynaMagazynie on p.ID_Material equals m.ID_Material into joinResult
                                          from m in joinResult.DefaultIfEmpty()
                                          where m == null || p.Ilosc > m.Ilosc
                                          select new { p.ID_Material, NazwaMaterialu = p.Nazwa_Materialu, IloscWMagazynie = m == null ? 0 : m.Ilosc, IloscPotrzebna = p.Ilosc };

                    double iloscbrakowmaterialow = zapotrzebowanie.Count();



                    dataDostepnosciMaterialu = dataDostepnosciMaterialu.Date.AddDays(iloscbrakowmaterialow);




                    var dataDostepnosciPracownika = new DateTime(2023, 04, 26);




                    dataDostepnosciPracownika = dataDostepnosciPracownika.Date;

                    var dataDostepnosciMaszyny = new DateTime(2023, 04, 25);
                    dataDostepnosciMaszyny = dataDostepnosciMaszyny.Date;


                    if (planowanadatazakonczenia < dataDostepnosciMaterialu || planowanadatazakonczenia < dataDostepnosciPracownika || planowanadatazakonczenia < dataDostepnosciMaszyny)
                    {
                        if (dataDostepnosciMaterialu > dataDostepnosciPracownika)
                        {
                            if (dataDostepnosciMaterialu > dataDostepnosciMaszyny)
                            {
                                planowanadatazakonczenia = planowanadatazakonczenia + (dataDostepnosciMaterialu - planowanadatazakonczenia);
                            }
                            else
                            {
                                planowanadatazakonczenia = planowanadatazakonczenia + (dataDostepnosciMaszyny - planowanadatazakonczenia);
                            }
                        }
                        else
                        {
                            if (dataDostepnosciPracownika > dataDostepnosciMaszyny)
                            {
                                planowanadatazakonczenia = planowanadatazakonczenia + (dataDostepnosciPracownika - planowanadatazakonczenia);
                            }
                            else
                            {
                                planowanadatazakonczenia = planowanadatazakonczenia + (dataDostepnosciMaszyny - planowanadatazakonczenia);
                            }
                        }

                    }


                    double SumarycznyCzasTrwania = IloscProduktuw * CzasTrwaniaProcesu;


                    if (SumarycznyCzasTrwania >= 8)
                    {
                         czescCalkowita = (int)(SumarycznyCzasTrwania / 8);
                        reszta = reszta +  SumarycznyCzasTrwania % 8;
                    }
                    else
                    {
                        reszta = reszta + SumarycznyCzasTrwania;
                    }
                     if(reszta >= 8)
                    {
                        czescCalkowitaReszty = (int)(SumarycznyCzasTrwania / 8);
                        reszta = SumarycznyCzasTrwania % 8;
                    }



                    double dmi = czescCalkowita + czescCalkowitaReszty;
                    planowanadatazakonczenia = planowanadatazakonczenia.Date.AddDays(dmi);









                    //if (potrzebnamaszyna == "Piła Stołowa" && maxkolejnosc == 4 && czastrwaniaprocesu == 1 && iloscproduktow == 15)
                    //{
                    //    potwierdzenie = "działa " + planowanadatazakonczenia.Date.ToString();

                    //}
                    //else
                    //{
                    //    potwierdzenie = "nie działa";
                    //}

                }

                double ZaokrReszty = Math.Ceiling(reszta/8);
                planowanadatazakonczenia = planowanadatazakonczenia.Date.AddDays(ZaokrReszty);
            }
            if (planowanadatazakonczenia > datazakonczenia)
            {
                potwierdzenie = "Niestety data realizacji nie jest możliwa, proponowana data realizacji to: " + planowanadatazakonczenia.Date.ToString("dd.MM.yyyy");


            }
            else
            {
                potwierdzenie = "Zamówienie jest realne " +"Planowana data zakończenia wynosi" + planowanadatazakonczenia.Date.ToString("dd.MM.yyyy");
            }
            return potwierdzenie;
        }
    }
}
