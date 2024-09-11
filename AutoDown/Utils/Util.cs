using System;
using System.IO;
using System.Threading;

namespace AutoDown.Utils
{
    public static class Util
    {
        //  RUNNNING PATH
        private static string runningPath;


        // SEMAPPHORE
        private static Semaphore semaphore;

        public static void StartNewThread(ThreadStart start)
        {
            var thread = new Thread(start);
            thread.IsBackground = true;
            thread.Start();
        }

        public static string GetRunningPath()
        {
            if (runningPath == null)
            {
                runningPath = AppDomain.CurrentDomain.BaseDirectory + @"..\AutoDown\";
                runningPath = Path.GetFullPath(runningPath);
            }

            return runningPath;
        }

        public static bool CheckSemaphoreAvailability()
        {
            const string semaphoreName = "AutoDown";
            const int semaphoreCount = 1;

            // Tạo Semaphore với đếm ban đầu là 1
            semaphore = new Semaphore(semaphoreCount, semaphoreCount, semaphoreName);

            // Kiểm tra xem Semaphore có sẵn sàng để sử dụng hay không
            var isSemaphoreAvailable = semaphore.WaitOne(TimeSpan.Zero);

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