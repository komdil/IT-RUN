using GenericExamples;

int maxSize = 10;
Queue queue = new Queue(maxSize);
queue.AddToQueue(new BankClient(1122, 100));
queue.AddToQueue(new BankClient(1123, 200));
queue.AddToQueue(new BankClient(1124, 300));
queue.ShowQueue();
queue.MakeService();
queue.ShowQueue();
queue.MakeService();
queue.ShowQueue();
Console.Read();