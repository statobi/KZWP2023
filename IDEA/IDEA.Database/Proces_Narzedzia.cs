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
    
    public partial class Proces_Narzedzia
    {
        public int ID_Proces_Narzedzia { get; set; }
        public int ID_Narzedzia { get; set; }
        public int ID_Proces { get; set; }
    
        public virtual Narzedzia Narzedzia { get; set; }
        public virtual Proces Proces { get; set; }
    }
}
