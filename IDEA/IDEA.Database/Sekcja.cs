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
    
    public partial class Sekcja
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sekcja()
        {
            this.Polkas = new HashSet<Polka>();
        }
    
        public int ID_Sekcja { get; set; }
        public int ID_Magazyn { get; set; }
        public int ID_TypZasobu { get; set; }
        public string Numer { get; set; }
        public double PowierzchniaRobocza { get; set; }
    
        public virtual Magazyn Magazyn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Polka> Polkas { get; set; }
        public virtual TypZasobu TypZasobu { get; set; }
    }
}
