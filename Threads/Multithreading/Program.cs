// See https://aka.ms/new-console-template for more information
using System.Collections.Concurrent;
using System.Diagnostics.Metrics;
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


BlockingCollection<int> values = new BlockingCollection<int>();
StartCreatePayloads();
void StartCreatePayloads()
{
    Task.Run(() =>
    {
        for (int i = 0; i < 10; i++)
        {
            Task.Delay(1000).Wait();
            Console.WriteLine($"Item {i} added");
            values.Add(i);
        }
        values.CompleteAdding();
    });
}

foreach (var item in values.GetConsumingEnumerable())
{
    //Send request to web site async
    Console.WriteLine("Sending request to " + item);
}

Console.ReadLine();