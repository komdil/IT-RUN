// See https://aka.ms/new-console-template for more information

using System.Text;

string[] products = File.ReadAllLines("store.txt", Encoding.UTF8);

string newlyadded = "Себ";
int count = 10;

for (int i = 0; i < products.Length; i++)
{
    string product = products[i];
    var splitted = product.Split(' ');

    string productName = splitted[0];
    int countOfProduct = int.Parse(splitted[1]);
    if (productName == newlyadded)
    {
        countOfProduct += count;
    }
    products[i] = $"{productName} {countOfProduct}";
}


string[] added = new string[products.Length + 1];
for (int i = 0; i < products.Length; i++)
{
    added[i] = products[i];
}

added[products.Length] = "Нок 20";

File.WriteAllLines("store.txt", added, Encoding.UTF8);

Console.ReadLine();