using IDEA.App.Formularze.Logistyka.Magazyn;
using IDEA.Database;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDEA.App
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            await IDEADatabase.GetInstance().Magazyns.ToListAsync().ConfigureAwait(true);
            Application.Run(new InitForm());
        }
    }
}
