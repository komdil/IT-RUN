using System;
using System.Text;

public class Product
{
    public List<string> prods { get; set; }
    public Product()
	{
        prods = File.ReadAllLines("store.txt", Encoding.UTF8).ToList();
    }

    public Product(string name, int count)
    {
        SaveToFile(name, count);
    }

    public void SaveToFile(string name, int count)
    {
        prods.Add(name + " " + count);  
        File.WriteAllLines("store.txt", prods);
    }

    public static string[] GetPorducts(string filePath)
    {
        return File.ReadAllLines(filePath, Encoding.UTF8);
    }

    public static bool ProductExists(string name, string filePath)
    {
        var prods = File.ReadAllLines(filePath, Encoding.UTF8);
        foreach (var item in prods)
        {
            if (item.StartsWith(name))
            {
                return true;
            }
        }
        return false;
    }

    public void ChangeNumber(string name, int n)
    {
        for (int i = 0; i < prods.Count; i++)
        {
            if (prods[i].StartsWith(name))
            {
                var temp = int.Parse(prods[i].Split()[1]);
                if (n + temp >= 0)
                {
                    prods[i] = name + " " + (temp + n);
                    File.WriteAllLines("store.txt", prods);
                    break;
                }
                else
                {
                    Console.WriteLine("Not enough products");
                }
            }
        }
    }


}
