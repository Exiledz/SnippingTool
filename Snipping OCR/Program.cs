using System;
using System.CommandLine.DragonFruit;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace Snipping_OCR
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// <param name="invoke">An executable that will be called with --img=PNGFILE --text=TEXTFILE</param>
        /// </summary>
        [STAThread]
        static void Main(string invoke="")
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(invoke));
        }

    }
}
