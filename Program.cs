using System;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string userName = "Admin";

            Application.Run(new Home());
        }
    }
}