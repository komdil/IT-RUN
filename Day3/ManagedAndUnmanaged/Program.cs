using ManagedAndUnmanaged;

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

        using (Application application = new Application())
        {
            application.WriteProduct(name, count);
        }
    }
}

class test
{

}