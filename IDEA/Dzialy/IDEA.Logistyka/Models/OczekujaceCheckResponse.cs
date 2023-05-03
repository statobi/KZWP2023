﻿using IDEA.Logistyka.Enums;

namespace IDEA.Logistyka.Models
{
    public class OczekujaceCheckResponse
    {
        public int MaterialId { get; set; }
        public string Nazwa { get; set; }
        public TypAsortymentu TypAsortymentu { get; set; }
        public string RodzajMaterialu { get; set; }

        public int IdRodzajMaterialu { get; set; }
    }
}
