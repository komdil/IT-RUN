// See https://aka.ms/new-console-template for more information
using GenericExamples;

int maxSize = 10;

Queue queue = new Queue(maxSize);
queue.AddToQueue(1122);
queue.AddToQueue(1123);
queue.AddToQueue(1124);
queue.ShowQueue();
queue.MakeService();
queue.ShowQueue();
queue.MakeService();
queue.ShowQueue();
Console.Read();