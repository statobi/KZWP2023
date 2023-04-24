using IDEA.Database;
using System;
using System.Collections.Generic;
using System.Linq;
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

            //var nazwaproduktu = db.

            string nazwaproduktu = "nic";
            int ilosc;
            //ilosc = Int32.Parse(iloscstring);
            //var datazamowienia = DateTime.Parse(datazamowieniastring);
            //var datarealizacji = DateTime.Parse(datarealizacjistring);
            var datadzis = DateTime.Now;
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









            if (potrzebnamaszyna == "Piła Stołowa" && maxkolejnosc == 5 && czastrwaniaprocesu == 1)
            {
              potwierdzenie =  "działa";

            }
            else
            {
              potwierdzenie = "nie działa";
            }




            potwierdzenie = id.ToString();
            return potwierdzenie;
        }
    }
}
