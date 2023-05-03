﻿using IDEA.App.Formularze.Logistyka.Magazyn;
using IDEA.App.Formularze.Logistyka.Magazyn.Nieprzypisane;
using IDEA.App.Formularze.Logistyka.Magazyn.Oczekujace;
using IDEA.App.Formularze.Logistyka.Magazyn.Sekcja;
using System;
using System.Windows.Forms;

namespace IDEA.App.Factories
{
    internal class NewPanelFactory
    { 
        public static Form CreateNewPanel<T>()
        {
            if (typeof(MagazynForm) == typeof(T))
                return new MagazynForm();
            if (typeof(SekcjaForm) == typeof(T))
                return new SekcjaForm();
            if (typeof(TypMaterialuChartForm) == typeof(T))
                return new TypMaterialuChartForm();
            if (typeof(AsortymentForm) == typeof(T))
                return new AsortymentForm();
            if (typeof(OczekujaceForm) == typeof(T))
                return new OczekujaceForm();
            if (typeof(PrzypiszTypZasobuForm) == typeof(T))
                return new PrzypiszTypZasobuForm();

            throw new InvalidOperationException("Nie można wykreować niezdefiniowanego typu");
        }
    }
}
