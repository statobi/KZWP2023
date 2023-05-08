using IDEA.Logistyka.Models;
using System;
using System.Collections.Generic;

namespace IDEA.App.Models
{
    internal class TransportDGV
    {
        public int Id { get; set; }
        public int IdMagazynPoczatkowy { get; set; }
        public int IdMagazynKoncowy { get; set; }
        public int IdKierowca { get; set; }
        public int IdPojazd { get; set; }
        public string MagazynPoczatkowy { get; set; }
        public string MagazynKoncowy { get; set; }
        public DateTime Data { get; set; }
        public string Kierowca { get; set; }
        public string Pojazd { get; set; }
    }
}
