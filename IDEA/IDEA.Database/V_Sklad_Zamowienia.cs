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
    
    public partial class V_Sklad_Zamowienia
    {
        public int Numer_Skladu_Zamowienia { get; set; }
        public string Nazwa_Produktu { get; set; }
        public int Ilosc { get; set; }
        public decimal Cena_Netto { get; set; }
        public decimal Cena_Brutto { get; set; }
        public System.DateTime Data_Zamowienia { get; set; }
        public System.DateTime Data_Realizacji { get; set; }
    }
}
