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
    
    public partial class Ewidencja_Materialow_Na_Polkach
    {
        public string Nazwa_magazynu { get; set; }
        public int Telefon_magazynu { get; set; }
        public int Powierzchnia_robocza_magazynu { get; set; }
        public int ID_sekcji { get; set; }
        public string Numer_sekcji { get; set; }
        public double Powierzchnia_robocza_sekcji { get; set; }
        public int ID_półki { get; set; }
        public string Numer_półki { get; set; }
        public double Szerokość_półki { get; set; }
        public double Głębokość_półki { get; set; }
        public double Wysokość_półki { get; set; }
        public double Udźwig_półki { get; set; }
        public Nullable<int> ID_rozłożenia_na_półce__materiały_ { get; set; }
        public string Nazwa_materiału { get; set; }
        public Nullable<int> Jednostka_materiału { get; set; }
        public Nullable<int> Ilość_materiału { get; set; }
        public Nullable<System.DateTime> Data_rozłożenia__materiały_ { get; set; }
        public Nullable<System.DateTime> Data_pobrania__materiały_ { get; set; }
    }
}
