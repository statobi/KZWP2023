using IDEA.App.Formularze.Logistyka.Magazyn.Sekcja;
using System.Windows.Forms;

namespace IDEA.App.Factories
{
    internal class NewPanelFactory
    { 
        public static Form CreateNewPanel<T>()
        {
            if(typeof(SekcjaForm) == typeof(T))
                return new SekcjaForm();

            return null;
        }
    }
}
