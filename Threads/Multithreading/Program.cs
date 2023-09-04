using Multithreading;

// See https://aka.ms/new-console-template for more information
using System.Collections.Concurrent;
using System.Diagnostics.Metrics;
class Program
{
    static async Task Main(string[] args)
    {
        //DeadlockExample.Start();
        //ThreadPoolExample.Start();
        //CancalationExample.Start();
        //await FileReadWriteAsync.Start();

        while (true)
        {
            string res = Console.ReadLine();
            if (res == "readname")
            {
                await DatabaseAsyncTest.Start();
            }
        }

        Console.ReadLine();
        ////TPL
        //Console.WriteLine("Hello, World!");
        //ConcurrentDictionary<string, string> metrics = new ConcurrentDictionary<string, string>();

        //var threadParam = new ParameterizedThreadStart(RunInNewThread);

        //Thread thread = new Thread(threadParam);
        //thread.IsBackground = true;
        //thread.UnsafeStart();

        //void RunInNewThread(object? obj)
        //{
        //    Thread.Sleep(5000);
        //    File.WriteAllText("1.txt", "Thread finished");
        //}


        //BlockingCollection<int> values = new BlockingCollection<int>();

        //Task.Run(() =>
        //{
        //    foreach (var item in values.GetConsumingEnumerable())
        //    {
        //        //Send request to web site async
        //        Console.WriteLine("Sending request to " + item);
        //    }
        //});


        //StartCreatePayloads();
        //void StartCreatePayloads()
        //{
        //    Task.Run(() =>
        //    {
        //        for (int i = 0; i < 15; i++)
        //        {
        //            values.Add(i);
        //            //Task.Delay(1000).Wait();
        //            Console.WriteLine($"Item {i} added");

        //        }
        //        values.CompleteAdding();
        //    });
        //}


        //Console.ReadLine();
    }
}