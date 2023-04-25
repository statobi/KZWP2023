using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace IDEA.App.MessageBoxes
{
    internal class WalidatorMessageBox
    {
        public static void Waliduj(string wynikWalidacji)
            => MessageBox.Show($"Niektóre z wprowadzonych danych są nieprawidłowe: \n{wynikWalidacji}", "Niepowodzenie", MessageBoxButton.OK, MessageBoxImage.Error);
    }
}
