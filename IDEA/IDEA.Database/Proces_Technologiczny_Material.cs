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
    
    public partial class Proces_Technologiczny_Material
    {
        public int ID_Proces_Technologiczny_Material { get; set; }
        public int ID_Proces_Technologiczny { get; set; }
        public int ID_Material { get; set; }
        public int Ilosc { get; set; }
    
        public virtual Material Material { get; set; }
        public virtual Proces_Technologiczny Proces_Technologiczny { get; set; }
    }
}
