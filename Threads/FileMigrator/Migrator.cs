using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMigrator
{
    internal class Migrator
    {
        public static void Migrate()
        {
            string directory = "db";
            var files = Directory.GetFiles(directory);

            List<Task> tasks = new List<Task>();
            foreach (var file in files)
            {
                var task = Task.Run(() => GetFilesFromTheFile(file));
                tasks.Add(task);
            }
            Task.WaitAll(tasks.ToArray());
        }
        static Semaphore Semaphore = new Semaphore(3, 3);
        private static void GetFilesFromTheFile(string file)
        {
            try
            {
                Semaphore.WaitOne();
                using var context = new ProductSaleDbContext();
                var lines = File.ReadAllLines(file);
                foreach (var line in lines)
                {
                    CreateProductSaleFromTheLine(line, context);
                }
                context.SaveChanges();
            }
            finally
            {
                Semaphore.Release();
            }
        }

        private static void CreateProductSaleFromTheLine(string line, ProductSaleDbContext context)
        {
            ProductSale productSale = ParseProductSaleFromTheLine(line);
            context.Add(productSale);
        }

        private static ProductSale ParseProductSaleFromTheLine(string line)
        {
            var splittedProductSale = line.Split(' ');

            string name = splittedProductSale[0];
            int userId = int.Parse(splittedProductSale[1]);
            int quantity = int.Parse(splittedProductSale[2]);
            decimal price = decimal.Parse(splittedProductSale[3]);

            return new ProductSale
            {
                Id = Guid.NewGuid(),
                Name = name,
                UserId = userId,
                Quantity = quantity,
                Price = price,
            };
        }
    }
}
