using System;
using System.Windows.Forms;

namespace SOLID_StudentPerformanceApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin main = new FormLogin();
            main.FormClosed += FormLogin_Closed;
            main.Show();
            Application.Run();
        }

        private static void FormLogin_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormLogin_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += FormLogin_Closed;
            }
        }
    }
}