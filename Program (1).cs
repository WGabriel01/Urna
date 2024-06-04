using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace urna
{
    static class Program
    {
        /// <summary>
        /// O ponto de entrada principal do aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
