using Sirema.antarmuka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//NAMA  : ILHAM MUNAWAR
//KELAS : TI 2B
//NIM   : 220102037

namespace Sirema
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splashscreen());
        }
    }
}
