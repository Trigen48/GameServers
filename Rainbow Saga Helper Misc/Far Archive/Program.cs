using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Far_Archive
{
    static class Program
    {
        public static string file="";
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string [] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args != null && args.Length != 0)
            {
                file = args[0];
                if (args.Length > 1)
                {
                    //  FarLib.Far far;
                    string arg = args[1].ToLower();


                    if (arg == "-e" || arg == "-h" || arg == "-f" || arg == "-a")
                    {
                        //MessageBox.Show(arg);

                        FarLib.Far f = new FarLib.Far();

                        try
                        {
                            f.Load(file);

                            if (arg == "-e")
                            {
                                Extract(f, file);
                            }
                            else if (arg == "-h")
                            {
                                ExtractHere(f, file, false);
                            }
                            else if (arg == "-a")
                            {
                                if (args.Length > 2)
                                {

                                    string[] files = new string[args.Length - 2];

                                    args.CopyTo(files, 2);

                                    CreateNew(files);

                                }
                            }
                            else
                            {
                                ExtractHere(f, file, true);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Far Archive 1.0");
                        }
                        f.Clear();
                        f = null;
                        goto skip;
                    }
                }

            }
            Application.Run(new Main());
                skip:;
        }

        private static void CreateNew(string[] args)
        {

            FarLib.Far far = new FarLib.Far();
            string fn="";
            foreach (string f in args)
            {
                byte sate = State(f);

                switch (sate)
                {
                    case 0:
                        far.Add(f);
                        break;

                    case 1:
                        far.AddDir(f);
                        break;
                    default:
                        continue;
                }

                if (fn == "")
                    fn = f;
            }

            if (far.Count() == 0)
            {
                throw new Exception("Cannot create an empty far archive!");
            }

            far.Build(fn + ".far");

            far = null;
        }

        private static byte State(string file)
        {

            if(System.IO.File.Exists(file))
                return 0;

            if(System.IO.Directory.Exists(file))
                return 1;

            return 2;
        }

        private static void Extract(FarLib.Far far, string file)
        {
            if (far.dict.Count != 0)
            {
                FolderBrowserDialog f = new FolderBrowserDialog();
                f.Description="Extract far file!";
                
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string dir = f.SelectedPath;
                    if (!dir.EndsWith("\\"))
                        dir = dir + "\\";
      
                    foreach (string key in far.dict.Keys)
                    {
                        try
                        {
                            far.Extract(key, dir);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message,"Far Archive 1.0");
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("No files to extract!", "Far Archive 1.0");
            }
        }

        private static void ExtractHere(FarLib.Far far, string fileDoe,bool todir)
        {

            if (far.dict.Count != 0 )
            {

                string dir;
                
                if(todir)
                {
                    dir= fileDoe.Substring(0, fileDoe.LastIndexOf("."))+"\\";
                    
                }
                else
                {
                    dir= fileDoe.Substring(0, fileDoe.LastIndexOf("\\") + 1);
                }

               // MessageBox.Show(dir);
                foreach (string key in far.dict.Keys)
                {
                    try
                    {
                        far.Extract(key, dir);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,"Far Archive 1.0");
                    }
                }


            }
            else
            {
                MessageBox.Show("No files to extract!","Far Archive 1.0");
            }
        }

    }
}
