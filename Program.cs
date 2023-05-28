using proiect.Forms;
using System;
using System.Windows.Forms;

namespace proiect
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StateManagement.Start();
        }
    }
}
