// See https://aka.ms/new-console-template for more information
using System.Collections.Concurrent;
using System.Diagnostics.Metrics;
//TPL
Console.WriteLine("Hello, World!");
ConcurrentDictionary<string, string> metrics = new ConcurrentDictionary<string, string>();

Task[] tasks = new Task[1000];
for (int i = 0; i < 1000; i++)
{
    tasks[i] = Task.Run(() =>
    {
        metrics.TryAdd(Guid.NewGuid().ToString(), "Test");
    });
}
Task.WaitAll(tasks);
Console.WriteLine($"Number is {metrics.Count}");
Console.ReadLine();