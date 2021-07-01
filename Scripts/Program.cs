/* https://twitter.com/HoodStrats || https://github.com/Hoodstrats */

using System;
using System.Windows.Forms;

namespace Hood.Core
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Companion());
        }
    }
}
