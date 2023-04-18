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
    
    public partial class Pojazd
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pojazd()
        {
            this.ObslugiPojazdow = new HashSet<ObslugiPojazdow>();
            this.PrzegladPojazdu = new HashSet<PrzegladPojazdu>();
            this.SkladWysylka_Produkt = new HashSet<SkladWysylka_Produkt>();
            this.StanLicznika = new HashSet<StanLicznika>();
            this.Tankowanie = new HashSet<Tankowanie>();
            this.TransportWewnetrzny = new HashSet<TransportWewnetrzny>();
            this.Ubezpieczenie = new HashSet<Ubezpieczenie>();
        }
    
        public int ID_Pojazd { get; set; }
        public int ID_ModelPojazd { get; set; }
        public string NrRejestracyjny { get; set; }
        public System.DateTime RokProdukcji { get; set; }
        public System.DateTime DataPrzychodu { get; set; }
        public int StanLicznikaPoczatkowy { get; set; }
        public Nullable<System.DateTime> DataRozchodu { get; set; }
    
        public virtual ModelePojazdu ModelePojazdu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObslugiPojazdow> ObslugiPojazdow { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrzegladPojazdu> PrzegladPojazdu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkladWysylka_Produkt> SkladWysylka_Produkt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StanLicznika> StanLicznika { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tankowanie> Tankowanie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportWewnetrzny> TransportWewnetrzny { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ubezpieczenie> Ubezpieczenie { get; set; }
    }
}