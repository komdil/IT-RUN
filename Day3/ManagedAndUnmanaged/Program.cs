using ManagedAndUnmanaged;
using System.Xml.Linq;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose operation:");

            var operation = Console.ReadLine();
            if (operation == "enter")
            {
                Console.WriteLine("Name:");
                var name = Console.ReadLine();

                Console.WriteLine("Count:");
                var count = int.Parse(Console.ReadLine());
                doDome(name, count);
                GC.Collect();
            }
        }
    }
    static void doDome(string name, int count)
    {
        Application application = new Application();
        application.WriteProduct(name, count);
    }
}