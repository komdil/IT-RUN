// See https://aka.ms/new-console-template for more information

while (true)
{
    Product pr = new Product();
    Console.WriteLine("a - list of products\nb - add new product\nc - sell product\n");
    string userInput = Console.ReadLine();

    if (userInput == "a")
    {
        foreach (var item in Product.GetPorducts("store.txt"))
        {
            Console.WriteLine(item);
        }
    }
    else if (userInput == "b")
    {
        Console.Write("Input new product name: ");
        string newProductName = Console.ReadLine();
        Console.Write("Input new product quantity: ");
        int newProductQuantity = int.Parse(Console.ReadLine());

        if (Product.ProductExists(newProductName, "store.txt"))
        {
            pr.ChangeNumber(newProductName, newProductQuantity);
        }
        else
        {
            pr.SaveToFile(newProductName, newProductQuantity);
        }
    }
    else if (userInput == "c")
    {
        Console.Write("Input the product name you want to sell: ");
        string productName = Console.ReadLine();
        Console.Write("Input the quantity: ");
        int productQuantity = int.Parse(Console.ReadLine());

        pr.ChangeNumber(productName, -1 * productQuantity);
    }
}