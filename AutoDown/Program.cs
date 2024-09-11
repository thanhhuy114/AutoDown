using System;
using System.Windows.Forms;
using AutoDown.GUI.Forms;
using AutoDown.Utils;

namespace AutoDown
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            // Đảm bảo chỉ có 1 view xuất hiện trên màn hình
            if (!Util.CheckSemaphoreAvailability()) return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmMain());
            Util.DisposeSemaphore();
        }
    }
}