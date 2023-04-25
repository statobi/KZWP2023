using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace IDEA.App.MessageBoxes
{
    internal class CustomMessageBox
    {
        public static void ValidateMessageBox(string wynikWalidacji)
            => MessageBox.Show($"Niektóre z wprowadzonych danych są nieprawidłowe: \n{wynikWalidacji}", "Niepowodzenie", MessageBoxButton.OK, MessageBoxImage.Error);

        public static void ErrorBox(string wiadomosc)
            => MessageBox.Show(wiadomosc, "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
    }
}
