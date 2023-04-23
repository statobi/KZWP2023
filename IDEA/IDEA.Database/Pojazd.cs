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
            this.ObslugiPojazdows = new HashSet<ObslugiPojazdow>();
            this.PrzegladPojazdus = new HashSet<PrzegladPojazdu>();
            this.SkladWysylka_Produkt = new HashSet<SkladWysylka_Produkt>();
            this.StanLicznikas = new HashSet<StanLicznika>();
            this.Tankowanies = new HashSet<Tankowanie>();
            this.TransportWewnetrznies = new HashSet<TransportWewnetrzny>();
            this.Ubezpieczenies = new HashSet<Ubezpieczenie>();
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
        public virtual ICollection<ObslugiPojazdow> ObslugiPojazdows { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrzegladPojazdu> PrzegladPojazdus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkladWysylka_Produkt> SkladWysylka_Produkt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StanLicznika> StanLicznikas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tankowanie> Tankowanies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransportWewnetrzny> TransportWewnetrznies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ubezpieczenie> Ubezpieczenies { get; set; }
    }
}
