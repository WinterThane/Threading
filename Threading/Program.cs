using System;
using System.Threading;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[{0}] Main start", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("[{0}] Core count [{1}]", Thread.CurrentThread.ManagedThreadId, Environment.ProcessorCount);

            var t = new Thread(Hello)
            {
                Name = "Hello thread",
                Priority = ThreadPriority.BelowNormal
            };
            t.Start();

            Console.WriteLine("[{0}] Main end", Thread.CurrentThread.ManagedThreadId);

            Console.ReadLine();
        }

        private static void Hello()
        {
            Console.WriteLine("[{0}] Hello thread", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
