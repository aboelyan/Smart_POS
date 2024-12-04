using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Smart_POS.Classes;
using Smart_POS.Forms;

namespace Smart_POS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            adoClass.setConnection();
            Application.SetCompatibleTextRenderingDefault(false);
            FormStartUp startUp = new FormStartUp();
            if (startUp.ShowDialog() == DialogResult.OK)
            {
                FormLogIn formLogIn = new FormLogIn();
                if (formLogIn.ShowDialog() == DialogResult.OK)
                {
                    Application.EnableVisualStyles();
                    Application.Run(new frm_Main());
                }
            }
        }
    }
}
