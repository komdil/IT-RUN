using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int maxSize = int.Parse(Console.ReadLine());
        string result = Generate(number, maxSize);
        Console.Write(result);
        Console.ReadLine();
    }

    static string Generate(int number, int maxSize)
    {
        string result = "";

        for (int i = 1; i <= number; i++)
        {
            for (int j = 1; j <= maxSize; j++)
            {
                result += $"{i}x{j}={i * j}";
                result += "\n";
            }
        }
        return result;
    }
}