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
    
    public partial class V_Dodawanie_Modelu
    {
        public int ID_Model_Maszyny { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public Nullable<int> ID_Rodzaj_Maszyny { get; set; }
        public string Rodzaj_Maszyny { get; set; }
        public string Rodzaj_strategii { get; set; }
    }
}
