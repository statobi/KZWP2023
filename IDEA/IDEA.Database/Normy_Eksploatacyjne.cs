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
    
    public partial class Normy_Eksploatacyjne
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Normy_Eksploatacyjne()
        {
            this.Czynnosci_Eksploatacyjne = new HashSet<Czynnosci_Eksploatacyjne>();
        }
    
        public int ID_Normy_Eksploatacyjne { get; set; }
        public int ID_Model_Maszyny { get; set; }
        public string Nr_Normy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Czynnosci_Eksploatacyjne> Czynnosci_Eksploatacyjne { get; set; }
        public virtual Model_Maszyny Model_Maszyny { get; set; }
    }
}
