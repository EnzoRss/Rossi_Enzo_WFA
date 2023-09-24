using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_invader
{
    internal static class Program  
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Player player = new Player();
            //Show first form and start the message loop
            (new Form1(player)).Show();
            Application.Run(); // needed, otherwise app closes immediately
        }
    }
}
