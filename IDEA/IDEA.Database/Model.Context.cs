﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IDEA.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IDEAEntities : DbContext
    {
        public IDEAEntities()
            : base("name=IDEAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Badanie_Maszyny> Badanie_Maszyny { get; set; }
        public virtual DbSet<Badany_Parametr> Badany_Parametr { get; set; }
        public virtual DbSet<Czynnosci_Eksploatacyjne> Czynnosci_Eksploatacyjne { get; set; }
        public virtual DbSet<Dokumentacja> Dokumentacjas { get; set; }
        public virtual DbSet<Dostawa> Dostawas { get; set; }
        public virtual DbSet<Dostawcy> Dostawcies { get; set; }
        public virtual DbSet<Dzialy> Dzialies { get; set; }
        public virtual DbSet<Faktury> Fakturies { get; set; }
        public virtual DbSet<Funkcja_w_Dokumentacji> Funkcja_w_Dokumentacji { get; set; }
        public virtual DbSet<Jednostka_miary> Jednostka_miary { get; set; }
        public virtual DbSet<Jezyki> Jezykis { get; set; }
        public virtual DbSet<Klient> Klients { get; set; }
        public virtual DbSet<Kontrola_Jakosci_Zamowienia> Kontrola_Jakosci_Zamowienia { get; set; }
        public virtual DbSet<Koszty_Rozne> Koszty_Rozne { get; set; }
        public virtual DbSet<Magazyn> Magazyns { get; set; }
        public virtual DbSet<Maszyny> Maszynies { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Material_Wlasciwosc_Material> Material_Wlasciwosc_Material { get; set; }
        public virtual DbSet<Model_Maszyny> Model_Maszyny { get; set; }
        public virtual DbSet<ModelePojazdu> ModelePojazdus { get; set; }
        public virtual DbSet<Narzedzia> Narzedzias { get; set; }
        public virtual DbSet<Nazwa_Procesu> Nazwa_Procesu { get; set; }
        public virtual DbSet<Normy_Eksploatacyjne> Normy_Eksploatacyjne { get; set; }
        public virtual DbSet<NormyEksploatacyjne_Pojazd> NormyEksploatacyjne_Pojazd { get; set; }
        public virtual DbSet<Obslugi> Obslugis { get; set; }
        public virtual DbSet<ObslugiPojazdow> ObslugiPojazdows { get; set; }
        public virtual DbSet<Oplaty_Administracyjne> Oplaty_Administracyjne { get; set; }
        public virtual DbSet<Parametr_Maszyny> Parametr_Maszyny { get; set; }
        public virtual DbSet<Pojazd> Pojazds { get; set; }
        public virtual DbSet<Polka> Polkas { get; set; }
        public virtual DbSet<Poziom_Znajomosci> Poziom_Znajomosci { get; set; }
        public virtual DbSet<Pracownicy> Pracownicies { get; set; }
        public virtual DbSet<Pracownicy_Dzialy> Pracownicy_Dzialy { get; set; }
        public virtual DbSet<Pracownicy_Jezyki> Pracownicy_Jezyki { get; set; }
        public virtual DbSet<Pracownicy_RodzajUmowy> Pracownicy_RodzajUmowy { get; set; }
        public virtual DbSet<Pracownicy_Stanowisko> Pracownicy_Stanowisko { get; set; }
        public virtual DbSet<Pracownicy_Zatrudnienie> Pracownicy_Zatrudnienie { get; set; }
        public virtual DbSet<Proce> Proces { get; set; }
        public virtual DbSet<Proces_Narzedzia> Proces_Narzedzia { get; set; }
        public virtual DbSet<Proces_Pracownicy> Proces_Pracownicy { get; set; }
        public virtual DbSet<Proces_Technologiczny> Proces_Technologiczny { get; set; }
        public virtual DbSet<Proces_Technologiczny_Material> Proces_Technologiczny_Material { get; set; }
        public virtual DbSet<Produkt> Produkts { get; set; }
        public virtual DbSet<PrzegladPojazdu> PrzegladPojazdus { get; set; }
        public virtual DbSet<Rodzaj_Dokumentacja> Rodzaj_Dokumentacja { get; set; }
        public virtual DbSet<Rodzaj_Faktury> Rodzaj_Faktury { get; set; }
        public virtual DbSet<Rodzaj_Koszty_Rozne> Rodzaj_Koszty_Rozne { get; set; }
        public virtual DbSet<Rodzaj_Maszyny> Rodzaj_Maszyny { get; set; }
        public virtual DbSet<Rodzaj_Materialu> Rodzaj_Materialu { get; set; }
        public virtual DbSet<Rodzaj_Narzedzia> Rodzaj_Narzedzia { get; set; }
        public virtual DbSet<Rodzaj_Obslugi_Maszyny> Rodzaj_Obslugi_Maszyny { get; set; }
        public virtual DbSet<Rodzaj_Oplaty_Administracyjnej> Rodzaj_Oplaty_Administracyjnej { get; set; }
        public virtual DbSet<Rodzaj_Produktu> Rodzaj_Produktu { get; set; }
        public virtual DbSet<Rodzaj_Strategii_Eksp> Rodzaj_Strategii_Eksp { get; set; }
        public virtual DbSet<Rodzaj_Umowy> Rodzaj_Umowy { get; set; }
        public virtual DbSet<Rodzaj_Urlopu> Rodzaj_Urlopu { get; set; }
        public virtual DbSet<RodzajDostawcy> RodzajDostawcies { get; set; }
        public virtual DbSet<RodzajObslugi_Pojazdow> RodzajObslugi_Pojazdow { get; set; }
        public virtual DbSet<RodzajPaliwa> RodzajPaliwas { get; set; }
        public virtual DbSet<RodzajPojazdu> RodzajPojazdus { get; set; }
        public virtual DbSet<RodzajUbezpieczenia> RodzajUbezpieczenias { get; set; }
        public virtual DbSet<RodzajZdarzenia_Wysylka> RodzajZdarzenia_Wysylka { get; set; }
        public virtual DbSet<RozlozeniePolki_Materialy> RozlozeniePolki_Materialy { get; set; }
        public virtual DbSet<RozlozeniePolki_Produkty> RozlozeniePolki_Produkty { get; set; }
        public virtual DbSet<Sekcja> Sekcjas { get; set; }
        public virtual DbSet<Sklad_Zamowienia> Sklad_Zamowienia { get; set; }
        public virtual DbSet<Sklad_Zlecenie_Magazynowe> Sklad_Zlecenie_Magazynowe { get; set; }
        public virtual DbSet<Sklad_Zlecenie_Produkt> Sklad_Zlecenie_Produkt { get; set; }
        public virtual DbSet<SkladDostawa_Material> SkladDostawa_Material { get; set; }
        public virtual DbSet<SkladWysylka_Produkt> SkladWysylka_Produkt { get; set; }
        public virtual DbSet<Srodki_Majatkowe> Srodki_Majatkowe { get; set; }
        public virtual DbSet<Stan_Faktury> Stan_Faktury { get; set; }
        public virtual DbSet<StanLicznika> StanLicznikas { get; set; }
        public virtual DbSet<Stanowisko> Stanowiskoes { get; set; }
        public virtual DbSet<Status_Zamowienia> Status_Zamowienia { get; set; }
        public virtual DbSet<Tankowanie> Tankowanies { get; set; }
        public virtual DbSet<TransportWewnetrzny> TransportWewnetrznies { get; set; }
        public virtual DbSet<TypZasobu> TypZasobus { get; set; }
        public virtual DbSet<Ubezpieczenie> Ubezpieczenies { get; set; }
        public virtual DbSet<Ubezpieczyciel> Ubezpieczyciels { get; set; }
        public virtual DbSet<Urlopy> Urlopies { get; set; }
        public virtual DbSet<Wlasciwosc_Materialu> Wlasciwosc_Materialu { get; set; }
        public virtual DbSet<Wysylka> Wysylkas { get; set; }
        public virtual DbSet<Zamowienia_Klienci> Zamowienia_Klienci { get; set; }
        public virtual DbSet<ZamowieniaKlienci_StatusZamowienia> ZamowieniaKlienci_StatusZamowienia { get; set; }
        public virtual DbSet<ZdarzenieWysylka> ZdarzenieWysylkas { get; set; }
        public virtual DbSet<ZleceniaStale> ZleceniaStales { get; set; }
        public virtual DbSet<Zlecenie_Magazynowe> Zlecenie_Magazynowe { get; set; }
        public virtual DbSet<Dokumentacja_Pracownicy> Dokumentacja_Pracownicy { get; set; }
        public virtual DbSet<Sklad_TransportWewnetrzny_Material> Sklad_TransportWewnetrzny_Material { get; set; }
        public virtual DbSet<Brakujacy_material> Brakujacy_material { get; set; }
        public virtual DbSet<Czas_Pracy_Maszyny> Czas_Pracy_Maszyny { get; set; }
        public virtual DbSet<Dostepne_Pojazdy> Dostepne_Pojazdy { get; set; }
        public virtual DbSet<Dostepnosc_Maszyn> Dostepnosc_Maszyn { get; set; }
        public virtual DbSet<Dostepnosc_Operatorow_Maszyn> Dostepnosc_Operatorow_Maszyn { get; set; }
        public virtual DbSet<Dostepny_material> Dostepny_material { get; set; }
        public virtual DbSet<Ewidencja_Materialow_Na_Polkach> Ewidencja_Materialow_Na_Polkach { get; set; }
        public virtual DbSet<Kosztory> Kosztorys { get; set; }
        public virtual DbSet<Kosztorys_Materialy> Kosztorys_Materialy { get; set; }
        public virtual DbSet<Kosztorys_Roboczogodziny> Kosztorys_Roboczogodziny { get; set; }
        public virtual DbSet<Maszyny_Ewidencja> Maszyny_Ewidencja { get; set; }
        public virtual DbSet<Materialy_Srednia_Cena> Materialy_Srednia_Cena { get; set; }
        public virtual DbSet<Narzedzia_w_procesie> Narzedzia_w_procesie { get; set; }
        public virtual DbSet<Praca_Pracownikow_Produkcji> Praca_Pracownikow_Produkcji { get; set; }
        public virtual DbSet<Pracownicy_Ewidencja> Pracownicy_Ewidencja { get; set; }
        public virtual DbSet<Proces_Technologiczny_Produktu> Proces_Technologiczny_Produktu { get; set; }
        public virtual DbSet<Produkty_Materialy> Produkty_Materialy { get; set; }
        public virtual DbSet<Produkty_Procesy> Produkty_Procesy { get; set; }
        public virtual DbSet<Produkty_Procesy_Suma> Produkty_Procesy_Suma { get; set; }
        public virtual DbSet<Przekroczenie_parametru> Przekroczenie_parametru { get; set; }
        public virtual DbSet<Raport_z_pracy_Operatorow> Raport_z_pracy_Operatorow { get; set; }
        public virtual DbSet<RodzajObsl_Model> RodzajObsl_Model { get; set; }
        public virtual DbSet<SprawdzeniePowierzchniRoboczej> SprawdzeniePowierzchniRoboczejs { get; set; }
        public virtual DbSet<V_Sklad_Zamowienia> V_Sklad_Zamowienia { get; set; }
        public virtual DbSet<V_Zamowienia_Klienci> V_Zamowienia_Klienci { get; set; }
        public virtual DbSet<Widok_Model_Stategia_PP> Widok_Model_Stategia_PP { get; set; }
        public virtual DbSet<Widok_Model_Strategia_ST> Widok_Model_Strategia_ST { get; set; }
        public virtual DbSet<Wykorzystany_Urlop> Wykorzystany_Urlop { get; set; }
        public virtual DbSet<Wykorzystany_Urlop_Na_Zadanie> Wykorzystany_Urlop_Na_Zadanie { get; set; }
    }
}
