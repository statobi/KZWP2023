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
    
    public partial class TypZasobu_RodzajMaterialu
    {
        public int ID_TypZasobu { get; set; }
        public int ID_Rodzaj_Materialu { get; set; }
        public Nullable<int> Ilosc { get; set; }
    
        public virtual Rodzaj_Materialu Rodzaj_Materialu { get; set; }
        public virtual TypZasobu TypZasobu { get; set; }
    }
}
