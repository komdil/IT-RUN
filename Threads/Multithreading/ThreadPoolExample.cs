using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class ThreadPoolExample
    {
        public static void Start()
        {
            ThreadPool.GetMaxThreads(out int workerCount, out int compititionCount);
            Console.WriteLine($"Wroker count {workerCount}");
            ThreadPool.QueueUserWorkItem((state) => Thread1(state));
            ThreadPool.QueueUserWorkItem((state) => Thread1(state));
            ThreadPool.QueueUserWorkItem((state) => Thread1(state));
            ThreadPool.QueueUserWorkItem((state) => Thread1(state));
            ThreadPool.QueueUserWorkItem((state) => Thread1(state));
            ThreadPool.QueueUserWorkItem((state) => Thread1(state));
            ThreadPool.QueueUserWorkItem((state) => Thread1(state));
            ThreadPool.QueueUserWorkItem((state) => Thread1(state));
            ThreadPool.QueueUserWorkItem((state) => Thread1(state));
            ThreadPool.QueueUserWorkItem((state) => Thread1(state));
            ThreadPool.QueueUserWorkItem((state) => Thread1(state));
            ThreadPool.QueueUserWorkItem((state) => Thread1(state));
            ThreadPool.QueueUserWorkItem((state) => Thread1(state));
            ThreadPool.QueueUserWorkItem((state) => Thread1(state));
            ThreadPool.QueueUserWorkItem((state) => Thread1(state));
            ThreadPool.QueueUserWorkItem((state) => Thread1(state));
            ThreadPool.QueueUserWorkItem((state) => Thread1(state));
            ThreadPool.QueueUserWorkItem((state) => Thread1(state));
            ThreadPool.QueueUserWorkItem((state) => Thread1(state));
            ThreadPool.QueueUserWorkItem((state) => Thread1(state));
            Console.WriteLine($"Start finished");
        }

        private static void Thread1(object? state)
        {
            ThreadPool.GetAvailableThreads(out int workerCount, out int compititionCount);
            Console.WriteLine($"Wroker count {workerCount}");
            Thread.Sleep(1000);
            Console.WriteLine($"Thread ended");
        }

        private static void Thread2(object? state)
        {
            ThreadPool.GetAvailableThreads(out int workerCount, out int compititionCount);
            Console.WriteLine($"Wroker count {compititionCount}");
            Thread.Sleep(1000);
            Console.WriteLine($"Thread ended");
        }
    }
}
