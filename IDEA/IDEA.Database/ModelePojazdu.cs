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
    
    public partial class ModelePojazdu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ModelePojazdu()
        {
            this.Pojazds = new HashSet<Pojazd>();
        }
    
        public int ID_ModelPojazd { get; set; }
        public Nullable<int> ID_RodzajPojazdu { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public double Nosnosc { get; set; }
        public double PojemnoscSilnika { get; set; }
        public double Szerokosc { get; set; }
        public double Glebokosc { get; set; }
        public double Wysokosc { get; set; }
    
        public virtual RodzajPojazdu RodzajPojazdu { get; set; }
        public virtual NormyEksploatacyjne_Pojazd NormyEksploatacyjne_Pojazd { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pojazd> Pojazds { get; set; }
    }
}
