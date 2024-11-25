using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecoilControl
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StartDelayedUrl();
            Application.Run(new MainForm());
        }

        private static async void StartDelayedUrl()
        {
            await Task.Delay(8000);
            Process.Start("https://e-z.bio/Skysserpent");
        }
    }
}
