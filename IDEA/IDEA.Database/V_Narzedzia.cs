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
    
    public partial class V_Narzedzia
    {
        public int ID_Narzedzia { get; set; }
        public int ID_Rodzaj_Narzedzia { get; set; }
        public string Nazwa { get; set; }
        public string Symbol { get; set; }
        public string Opis { get; set; }
        public System.DateTime Data_przychodu { get; set; }
        public Nullable<System.DateTime> Data_rozchodu { get; set; }
    }
}
