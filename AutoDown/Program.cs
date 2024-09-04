using System;
using System.Windows.Forms;

namespace AutoDown
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Đảm bảo chỉ có 1 view xuất hiện trên màn hình
            if (!Utils.CheckSemaphoreAvailability()) { return; }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI.Forms.AutoDown());

            Utils.DisposeSemaphore();
        }
    }
}
