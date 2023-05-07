
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace IDEA.App.Models
{
    internal class Normy_PP
    {
        public int ID_Czynnosci_Eksploatacyjne { get; set; }

        public int ID_Normy_Eksploatacja { get; set; }

        public string Nazwa { get; set; }

        public string Nr_Normy { get; set; }

        public double Godziny { get; set; }


    }
}