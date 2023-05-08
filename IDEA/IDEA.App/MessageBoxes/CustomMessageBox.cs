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
        public static void ValidateMessageBox(string validationResult)
            => MessageBox.Show($"Niektóre z wprowadzonych danych są nieprawidłowe: \n{validationResult}", "Niepowodzenie", MessageBoxButton.OK, MessageBoxImage.Error);

        public static void ErrorBox(string message)
            => MessageBox.Show(message, "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);

        public static void WarnBox(string message, string caption)
            => MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Warning);
        
        public static bool WarnBoxBoolean(string message, string caption)
        {
            var dialogResult =  MessageBox.Show(message, caption, MessageBoxButton.YesNo, MessageBoxImage.Warning);
            return dialogResult == MessageBoxResult.Yes;
        }

        public static void InfoBox(string message, string caption)
             => MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Information);
    }
}
