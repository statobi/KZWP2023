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
    
    public partial class Magazyn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Magazyn()
        {
            this.Dostawas = new HashSet<Dostawa>();
            this.Sekcjas = new HashSet<Sekcja>();
            this.SkladWysylka_Produkt = new HashSet<SkladWysylka_Produkt>();
            this.TransportWewnetrznies = new HashSet<TransportWewnetrzny>();
            this.TransportWewnetrznies1 = new HashSet<TransportWewnetrzny>();
        }
    
        public int ID_Magazyn { get; set; }
        public string Nazwa { get; set; }
        public int Telefon { get; set; }
        public int PowierzchniaRobocza { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dostawa> Dostawas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sekcja> Sekcjas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkladWysylka_Produkt> SkladWysylka_Produkt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportWewnetrzny> TransportWewnetrznies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportWewnetrzny> TransportWewnetrznies1 { get; set; }
    }
}
