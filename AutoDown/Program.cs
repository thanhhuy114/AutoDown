using AutoDown.GUI.Forms;
using AutoDown.Utils;
using System;
using System.Threading;
using System.Windows.Forms;

namespace AutoDown
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Đảm bảo chỉ có 1 view xuất hiện trên màn hình
            if (!Util.CheckSemaphoreAvailability()) { return; }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmMain());
            Util.DisposeSemaphore();
        }
    }
}
