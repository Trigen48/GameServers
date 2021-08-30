using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Item_Helper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] arg)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

                Form n;
            if (arg != null && arg.Length == 1)
            {

                switch (arg[0])
                {
                    case "-i":
                        n = new Main();
                        break;

                    case "-s":
                        n = new Shop_Manager();
                        break;

                    case "-e":
                        n = new Explorer();
                        break;

                    case "-p":
                        n = new Explorer(2);
                        break;

                    default:
                        n = new Main();
                        break;


                }
                //Application.Run(new Main());
    
            }
            else
            {
                n = new Main();
            } 
            
            Application.Run(n);
              
            n = null;
        }
    }
}
