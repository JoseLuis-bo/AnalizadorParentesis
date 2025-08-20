using System;
using System.Windows.Forms;
using AnalizadorParentesisWinForms.UI;

namespace AnalizadorParentesisWinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}