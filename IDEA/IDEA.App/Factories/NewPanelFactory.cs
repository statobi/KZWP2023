using IDEA.App.Formularze.Logistyka.Magazyn;
using IDEA.App.Formularze.Logistyka.Magazyn.Sekcja;
using System;
using System.Windows.Forms;

namespace IDEA.App.Factories
{
    internal class NewPanelFactory
    { 
        public static Form CreateNewPanel<T>()
        {
            if(typeof(MagazynForm) == typeof(T))
                return new MagazynForm();
            if(typeof(SekcjaForm) == typeof(T))
                return new SekcjaForm();
            if(typeof(TypMaterialuChartForm) == typeof(T))
                return new TypMaterialuChartForm();

            throw new InvalidOperationException("Nie można wykreować niezdefiniowanego typu");
        }
    }
}
