using Generic1._3;
using GenericExamples;

int maxSize = 10;
GenericExamples.Queue<HospitalClient> queue = new GenericExamples.Queue<HospitalClient>(maxSize);
queue.AddToQueue(new HospitalClient(1122, 100));
queue.AddToQueue(new HospitalClient(1123, 200));
queue.AddToQueue(new HospitalClient(1124, 300));
queue.ShowQueue();
queue.MakeService();
queue.ShowQueue();
queue.MakeService();
queue.ShowQueue();
Console.Read();