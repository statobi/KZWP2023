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
    
    public partial class Maszyny
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Maszyny()
        {
            this.Badanie_Maszyny = new HashSet<Badanie_Maszyny>();
            this.Obslugis = new HashSet<Obslugi>();
            this.Proces = new HashSet<Proce>();
        }
    
        public int ID_Maszyny { get; set; }
        public int ID_Model_Maszyny { get; set; }
        public string Symbol { get; set; }
        public System.DateTime Data_przychodu { get; set; }
        public Nullable<System.DateTime> Data_rozchodu { get; set; }
        public double Przebieg_poczatkowy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Badanie_Maszyny> Badanie_Maszyny { get; set; }
        public virtual Model_Maszyny Model_Maszyny { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Obslugi> Obslugis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proce> Proces { get; set; }
    }
}
