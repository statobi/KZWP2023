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
    
    public partial class Przekroczenie_parametru
    {
        public string Symbol_maszyny { get; set; }
        public string Badany_parametr { get; set; }
        public double Minimalna_wartość_parametru { get; set; }
        public double Maksymalna_wartość_parametru { get; set; }
        public double Zbadana_wartość_parametru { get; set; }
        public System.DateTime Data_badania { get; set; }
    }
}