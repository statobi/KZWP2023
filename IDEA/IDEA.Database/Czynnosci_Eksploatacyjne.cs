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
    
    public partial class Czynnosci_Eksploatacyjne
    {
        public int ID_Czynnosci_Eksploatacyjne { get; set; }
        public int ID_Normy_Eksploatacyjne { get; set; }
        public int ID_Rodzaj_Obslug_Maszyny { get; set; }
        public Nullable<double> Godziny { get; set; }
    
        public virtual Normy_Eksploatacyjne Normy_Eksploatacyjne { get; set; }
        public virtual Rodzaj_Obslugi_Maszyny Rodzaj_Obslugi_Maszyny { get; set; }
    }
}