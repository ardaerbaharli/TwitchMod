using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twitchMod
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

            Start start = new Start();
            Application.Run(start);

            if (start.DidUserEnterChannelName)
            {               
                Application.Run(new Form1(Start.channelName));
            }
        }
    }
}
