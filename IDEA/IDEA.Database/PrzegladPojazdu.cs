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
    
    public partial class PrzegladPojazdu
    {
        public int ID_PrzegladPojazdu { get; set; }
        public int ID_Pojazd { get; set; }
        public System.DateTime Data { get; set; }
        public System.DateTime DataDoP { get; set; }
        public decimal KosztNetto { get; set; }
        public decimal KosztBrutto { get; set; }
        public Nullable<int> ID_Faktury { get; set; }
    
        public virtual Faktury Faktury { get; set; }
        public virtual Pojazd Pojazd { get; set; }
    }
}
