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
    
    public partial class V_Zwrot_Kontrola_Jakosci
    {
        public int ID_Kontrola_Jakosci_Zamowienia { get; set; }
        public string Numer_Zamowienia { get; set; }
        public int Numer_skladu_zamowienia { get; set; }
        public string Nazwa_Produktu { get; set; }
        public Nullable<int> Ilosc_w_Kontroli { get; set; }
        public Nullable<int> Zaakcpetowane { get; set; }
        public Nullable<int> Odrzucone { get; set; }
        public Nullable<System.DateTime> Data_kontroli { get; set; }
        public string Uwagi { get; set; }
    }
}
