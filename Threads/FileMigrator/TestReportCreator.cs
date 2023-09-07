using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMigrator
{
    internal class TestReportCreator
    {
        public static void Create(int fileCount, int lineCount)
        {
            Random random = new();
            Directory.CreateDirectory("db");
            string fileName = Path.Combine("db", "product");
            for (int j = 0; j < fileCount; j++)
            {
                var currentFleName = $"{fileName}_{j}.txt";
                List<string> reports = new List<string>();
                for (int i = 0; i < lineCount; i++)
                {
                    var productSale = new ProductSale
                    {
                        Name = $"ProductName{i}{j}",
                        Price = random.Next(1, 50),
                        Quantity = random.Next(1, 50),
                        UserId = random.Next(1, 50),
                    };
                    reports.Add($"{productSale.Name} {productSale.UserId} {productSale.Quantity} {productSale.Price}");
                }
                File.WriteAllLines(currentFleName, reports);
            }

        }
    }
}
