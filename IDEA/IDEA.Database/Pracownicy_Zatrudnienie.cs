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
    
    public partial class Pracownicy_Zatrudnienie
    {
        public int ID_Pracownicy_Zatrudnienie { get; set; }
        public int ID_Pracownicy { get; set; }
        public decimal Pensja_Netto { get; set; }
        public decimal Pensja_Brutto { get; set; }
        public System.DateTime Data_od { get; set; }
        public Nullable<System.DateTime> Data_do { get; set; }
        public int Dotychczasowy_Staz { get; set; }
    
        public virtual Pracownicy Pracownicy { get; set; }
    }
}
