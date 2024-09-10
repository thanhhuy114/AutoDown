using System.IO;
using System;
using System.Threading;

namespace AutoDown.Utils
{
    public static class Util
    {
        public static void StartNewThread(ThreadStart start)
        {
            Thread thread = new Thread(start);
            thread.IsBackground = true;
            thread.Start();
        }

        //  RUNNNING PATH
        private static string runningPath = null;
        public static string GetRunningPath()
        {
            if (runningPath == null)
            {
                runningPath = AppDomain.CurrentDomain.BaseDirectory + @"..\AutoDown\";
                runningPath = Path.GetFullPath(runningPath);
            }

            return runningPath;
        }


        // SEMAPPHORE
        private static Semaphore semaphore = null;
        public static bool CheckSemaphoreAvailability()
        {
            const string semaphoreName = "AutoDown";
            const int semaphoreCount = 1;

            // Tạo Semaphore với đếm ban đầu là 1
            semaphore = new Semaphore(semaphoreCount, semaphoreCount, semaphoreName);

            // Kiểm tra xem Semaphore có sẵn sàng để sử dụng hay không
            bool isSemaphoreAvailable = semaphore.WaitOne(TimeSpan.Zero);

            return isSemaphoreAvailable;
        }

        public static void DisposeSemaphore()
        {
            // Giải phóng Semaphore
            if (semaphore != null)
            {
                semaphore.Release();
                semaphore.Dispose();
            }
        }
    }
}
