using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    public class DeadlockExample
    {
        static object Object1 = new object();
        static object Object2 = new object();


        public static void Start()
        {
            Thread thread1 = new Thread(Thread1);
            Thread thread2 = new Thread(Thread2);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();
            Console.WriteLine("Finished!");

        }

        static void Thread1()
        {
            var threadId = Thread.CurrentThread.ManagedThreadId;

            lock (Object1)
            {
                Console.WriteLine($"Thread {threadId} acquired lock 1.");
                Thread.Sleep(1000);
                Console.WriteLine($"Thread {threadId} attempted to acquire lock 2.");
                lock (Object2)
                {
                    Console.WriteLine($"Thread {threadId} acquired lock 2.");
                }
            }
        }

        static void Thread2()
        {
            var threadId = Thread.CurrentThread.ManagedThreadId;

            lock (Object2)
            {
                Console.WriteLine($"Thread {threadId} acquired lock 2.");
                Thread.Sleep(1000);
                Console.WriteLine($"Thread {threadId} attempted to acquire lock 1.");
                lock (Object1)
                {
                    Console.WriteLine($"Thread {threadId} acquired lock 1.");
                }
            }
        }
    }
}
