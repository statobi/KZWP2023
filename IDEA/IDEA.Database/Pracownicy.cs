//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Pracownicy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pracownicy()
        {
            this.Badanie_Maszyny = new HashSet<Badanie_Maszyny>();
            this.Dostawas = new HashSet<Dostawa>();
            this.Fakturies = new HashSet<Faktury>();
            this.Koszty_Rozne = new HashSet<Koszty_Rozne>();
            this.Obslugis = new HashSet<Obslugi>();
            this.ObslugiPojazdows = new HashSet<ObslugiPojazdow>();
            this.Oplaty_Administracyjne = new HashSet<Oplaty_Administracyjne>();
            this.Dokumentacja_Pracownicy = new HashSet<Dokumentacja_Pracownicy>();
            this.Pracownicy_Zatrudnienie = new HashSet<Pracownicy_Zatrudnienie>();
            this.Pracownicy_RodzajUmowy = new HashSet<Pracownicy_RodzajUmowy>();
            this.Pracownicy_Dzialy = new HashSet<Pracownicy_Dzialy>();
            this.Pracownicy_Stanowisko = new HashSet<Pracownicy_Stanowisko>();
            this.Pracownicy_Jezyki = new HashSet<Pracownicy_Jezyki>();
            this.Proces_Pracownicy = new HashSet<Proces_Pracownicy>();
            this.RozlozeniePolki_Materialy = new HashSet<RozlozeniePolki_Materialy>();
            this.RozlozeniePolki_Produkty = new HashSet<RozlozeniePolki_Produkty>();
            this.SkladWysylka_Produkt = new HashSet<SkladWysylka_Produkt>();
            this.StanLicznikas = new HashSet<StanLicznika>();
            this.TransportWewnetrznies = new HashSet<TransportWewnetrzny>();
            this.Urlopies = new HashSet<Urlopy>();
            this.Wysylkas = new HashSet<Wysylka>();
            this.Zamowienia_Klienci = new HashSet<Zamowienia_Klienci>();
            this.Zlecenie_Magazynowe = new HashSet<Zlecenie_Magazynowe>();
        }
    
        public int ID_Pracownicy { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string PESEL { get; set; }
        public string Adres_Ulica { get; set; }
        public string Adres_Kod_Pocztowy { get; set; }
        public string Adres_Miasto { get; set; }
        public string Numer_Konta_Bankowego { get; set; }
        public string Telefon { get; set; }
        public string E_mail { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Badanie_Maszyny> Badanie_Maszyny { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dostawa> Dostawas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Faktury> Fakturies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Koszty_Rozne> Koszty_Rozne { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Obslugi> Obslugis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObslugiPojazdow> ObslugiPojazdows { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Oplaty_Administracyjne> Oplaty_Administracyjne { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dokumentacja_Pracownicy> Dokumentacja_Pracownicy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pracownicy_Zatrudnienie> Pracownicy_Zatrudnienie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pracownicy_RodzajUmowy> Pracownicy_RodzajUmowy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pracownicy_Dzialy> Pracownicy_Dzialy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pracownicy_Stanowisko> Pracownicy_Stanowisko { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pracownicy_Jezyki> Pracownicy_Jezyki { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proces_Pracownicy> Proces_Pracownicy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RozlozeniePolki_Materialy> RozlozeniePolki_Materialy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RozlozeniePolki_Produkty> RozlozeniePolki_Produkty { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkladWysylka_Produkt> SkladWysylka_Produkt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StanLicznika> StanLicznikas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportWewnetrzny> TransportWewnetrznies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Urlopy> Urlopies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wysylka> Wysylkas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zamowienia_Klienci> Zamowienia_Klienci { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zlecenie_Magazynowe> Zlecenie_Magazynowe { get; set; }
    }
}
