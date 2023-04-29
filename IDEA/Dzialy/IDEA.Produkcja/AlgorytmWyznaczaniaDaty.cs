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
            string potwierdzenie;
            int IDSkladuZamowienia = id;


            var nazwaproduktu = db.V_Sklad_Zamowienia
                .Where(x => x.Numer_Skladu_Zamowienia ==IDSkladuZamowienia)
                .Select(x => x.Nazwa_Produktu)
                .FirstOrDefault();

            //var dataprzyjeciazamowienia = db.V_Sklad_Zamowienia
            //    .Where(x => x.Numer_Skladu_Zamowienia == IDSkladuZamowienia)
            //    .Select(x => x.Data_Zamowienia )
            //    .FirstOrDefault();

            //var dataplanowanejrealizacji = db.V_Sklad_Zamowienia
            //    .Where(x => x.Numer_Skladu_Zamowienia == IDSkladuZamowienia)
            //    .Select(x => x.Data_Realizacji)
            //    .FirstOrDefault();

            var datadzis = DateTime.Now;
            var datarozpoczecia = datadzis.Date;
            var planowanadatazakonczenia = DateTime.Now;
            planowanadatazakonczenia = planowanadatazakonczenia.Date;

            //Logistyka
            var dataDostepnosciMaterialu = new DateTime(2023, 04, 28);

            var dataDostepnosciPracownika = DateTime.Now;
            dataDostepnosciPracownika = dataDostepnosciPracownika.Date;

            var dataDostepnosciMaszyny = DateTime.Now;
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

            


            //var IDNazwyProcesu = db.Nazwa_Procesu
            //  .Where(x => x.Nazwa == Nazwaprocesu)
            // .Select(x => x.ID_Nazwa_Procesu)
            // .FirstOrDefault();






            int k = 1;

            var maxkolejnosc = db.Proces_Technologiczny_Produktu
                .Where(nzwp => nzwp.Nazwa_produktu == nazwaproduktu)
                .Max(ko => ko.Kolejnosc);

            var czastrwaniaprocesu = db.Proces_Technologiczny_Produktu
                .Where(x => x.Nazwa_produktu == nazwaproduktu && x.Kolejnosc == k)
                .Select(x => x.Ilosc_Godzin)
                .FirstOrDefault();

            var potrzebnamaszyna = db.Proces_Technologiczny_Produktu
                .Where(x => x.Nazwa_produktu == nazwaproduktu && x.Kolejnosc == k)
                .Select(x => x.Potrzebny_rodzaj_maszyny)
                .FirstOrDefault();

            var iloscpotrzebnychpracownikow = db.Proces_Technologiczny_Produktu
                .Where(x => x.Nazwa_produktu == nazwaproduktu && x.Kolejnosc == k)
                .Select(x => x.Ilosc_Godzin)
                .FirstOrDefault();

            var iloscproduktow = db.V_Sklad_Zamowienia
                .Where(x => x.Numer_Skladu_Zamowienia == IDSkladuZamowienia)
                .Select(x => x.Ilosc)
                .FirstOrDefault();


            









            if (potrzebnamaszyna == "Piła Stołowa" && maxkolejnosc == 4 && czastrwaniaprocesu == 1 && iloscproduktow ==15 )
            {
              potwierdzenie =  "działa " + planowanadatazakonczenia.Date.ToString();

            }
            else
            {
              potwierdzenie = "nie działa";
            }




            
            return potwierdzenie;
        }
    }
}
