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
    
    public partial class Klient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Klient()
        {
            this.Zamowienia_Klienci = new HashSet<Zamowienia_Klienci>();
        }
    
        public int ID_Klient { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Nazwa_Podmiotu { get; set; }
        public string NIP { get; set; }
        public string Adres_Ulica { get; set; }
        public string Adres_Kod_Pocztowy { get; set; }
        public string Adres_Miasto { get; set; }
        public string Telefon { get; set; }
        public string E_mail { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zamowienia_Klienci> Zamowienia_Klienci { get; set; }
    }
}
