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
    
    public partial class Funkcja_w_Dokumentacji
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Funkcja_w_Dokumentacji()
        {
            this.Dokumentacja_Pracownicy = new HashSet<Dokumentacja_Pracownicy>();
        }
    
        public int ID_Funkcja_w_Dokumentacji { get; set; }
        public string Nazwa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dokumentacja_Pracownicy> Dokumentacja_Pracownicy { get; set; }
    }
}
