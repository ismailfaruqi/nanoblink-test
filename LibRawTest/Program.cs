using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibRawTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            //try
            //{
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LibRawTestGui());
            //}
            //catch (System.IO.FileLoadException ex)
            //{
            //    if (ex.InnerException != null)
            //        MessageBox.Show(ex.InnerException.Message, "Inner Exception set");
            //    else
            //        MessageBox.Show(ex.Message, "Inner Exception unset");
            //}
            
            
        }
    }
}