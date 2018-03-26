using System;
using System.Windows.Forms;
using System.Security.Permissions;

namespace BGSnippet
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread,  PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
