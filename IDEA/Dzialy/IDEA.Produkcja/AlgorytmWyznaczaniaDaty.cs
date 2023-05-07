using IDEA.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IDEA.Produkcja
{
    public class AlgorytmWyznaczaniaDaty
    {
       IDEAEntities db = IDEADatabase.GetInstance();
        
        public string algorytmsprawdzaniadaty(int id)
        {
            string potwierdzenie ="";
            int IDZlecenia = id;

            var dataprzyjecia = db.Zamowienia_Klienci
                .Where(x => x.ID_Zamowienia_Klienci ==IDZlecenia)
                .Select(x =>x.Data_Zamowienia)
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
                .Where(x => x.ID_Sklad_Zamowienia == IDSkladuZamowienia && x.ID_Produkt== IDProduktu)
                .Select(x => x.Ilosc)
                .FirstOrDefault();



                var MaxKolejnosc = db.Proces_Technologiczny
                    .Where(x => x.ID_Produkt == IDProduktu)
                    .Max(x => x.Kolejnosc);

                for (int k = 1; k <= MaxKolejnosc; k++)
                {

                    var CzasTrwaniaProcesu = db.Proces_Technologiczny
                        .Where(x => x.ID_Produkt == IDProduktu && x.Kolejnosc==k)
                        .Select(x =>x.Ilosc_Godzin) 
                        .FirstOrDefault();




                    //Logistyka
                    var dataDostepnosciMaterialu = new DateTime(2023, 04, 28);

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


                    double dmi = Math.Ceiling(SumarycznyCzasTrwania / 8);

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
            }
            if (planowanadatazakonczenia > datazakonczenia)
            {
                potwierdzenie = "Niestety data realizacji nie jest wykonalna proponowana data realizacji to: " + planowanadatazakonczenia.Date.ToString();


            }
            else
            {
                potwierdzenie = "Zamówienie jest realne";
            }
            return potwierdzenie;
        }
    }
}
