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
    
    public partial class Nierozlozone_Produkty
    {
        public int ID_NierozlozoneMaterialy { get; set; }
        public int ID_Produkt { get; set; }
        public int Ilosc { get; set; }
        public System.DateTime DataOd { get; set; }
        public Nullable<System.DateTime> DataDo { get; set; }
    
        public virtual Produkt Produkt { get; set; }
    }
}
