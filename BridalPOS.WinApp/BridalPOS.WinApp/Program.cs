using BridalPOS.Bootstrapper;
using BridalPOS.Business.Interfaces.Base;
using BridalPOS.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridalPOS.WinApp
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
            Initializer.Init();
            Application.Run(new Form1());
        }
    }
}
