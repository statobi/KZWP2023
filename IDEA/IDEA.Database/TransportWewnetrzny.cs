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
    
    public partial class TransportWewnetrzny
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransportWewnetrzny()
        {
            this.Sklad_TransportWewnetrzny_Material = new HashSet<Sklad_TransportWewnetrzny_Material>();
        }
    
        public int ID_TransportWewnetrzny { get; set; }
        public int ID_Zlecenie_Magazynowe { get; set; }
        public int ID_Magazyn_pocz { get; set; }
        public int ID_Magazyn_konc { get; set; }
        public int ID_Pojazd { get; set; }
        public int ID_Pracownik { get; set; }
        public System.DateTime Data { get; set; }
    
        public virtual Magazyn Magazyn { get; set; }
        public virtual Magazyn Magazyn1 { get; set; }
        public virtual Pojazd Pojazd { get; set; }
        public virtual Pracownicy Pracownicy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sklad_TransportWewnetrzny_Material> Sklad_TransportWewnetrzny_Material { get; set; }
        public virtual Zlecenie_Magazynowe Zlecenie_Magazynowe { get; set; }
    }
}
