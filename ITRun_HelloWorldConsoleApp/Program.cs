using System.Text;
using System;

Console.OutputEncoding = Encoding.UTF8;
decimal money = decimal.Parse(Console.ReadLine());
decimal firstMoney = money;
int month = int.Parse(Console.ReadLine());
for (int i = 1; i <= month; i++)
{
    var percentValue = money * 0.07M;
    money += percentValue;
    Console.WriteLine($"Моҳи {i} - {money}");
}
Console.WriteLine($"Фоидаи шумо {money - firstMoney} аст");
Console.ReadLine();