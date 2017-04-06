using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ProjProgThreads
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
            synch start = new synch();
            Thread uphold = new Thread(new ThreadStart(start.uphold));
            Thread handler = new Thread(new ThreadStart(start.handler));
            uphold.Start();
            handler.Start();
            uphold.Join();
            handler.Join();
        }
    }
}
