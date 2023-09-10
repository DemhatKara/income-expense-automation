using Otomasyon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Otomasyon
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            glb.sql.Baglanti();

           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login login = new Login();  
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run( new Form1());
            }
        }
    }
}