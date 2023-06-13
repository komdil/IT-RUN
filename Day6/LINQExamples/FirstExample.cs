using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    public class FirstExample
    {
        public static void RunExample()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){Count=10,Id=Guid.NewGuid(),Name="Apple" },
                new Product(){Count=20,Id=Guid.NewGuid(),Name="Banana" }
            };

            var first = products.First();//Apple
            var firstWithQuery = products.First(s => s.Name == "Banana");//Banana

            Product firstWithAnotherQuery = products.First(s => s.Count > 30);//Exception

            Product firstWithAnotherQueryDefault = products.FirstOrDefault(s => s.Count > 30);//null

            var last = products.Last();//Apple
            var lastWithQuery = products.Last(s => s.Name == "Banana");//Banana

            Product lastWithAnotherQuery = products.Last(s => s.Count > 30);//Exception

            Product lastWithAnotherQueryDefault = products.LastOrDefault(s => s.Count > 30);//null


            Product single = products.Single();//Exception

            var id = Guid.NewGuid();
            Product singleWithQuery = products.Single(s => s.Id == id);//Apple


            Product singleOrDefault = products.SingleOrDefault();//Exception

            var id2 = Guid.NewGuid();
            Product singleWithQuery2 = products.SingleOrDefault(s => s.Id == id2);//null


            var result = products.Any(s => s.Name == "Apple");//true
            var result2 = products.All(s => s.Name == "Apple");//false

            var containsItem = products.Contains(singleWithQuery);

            var exists = products.Any(s => s.Name == "Product1");//true

            products.Add(new Product() { Name = "Product1" });

            Console.WriteLine(exists);

            var res = products.OrderBy(s => s.Name);

            var groupedByName = products.GroupBy(s => s.Name);

            foreach (var grouped in groupedByName)
            {
                var key = grouped.Key;
                foreach (var item in grouped)
                {

                }
            }

            var onlyNames = products.Select(s => s.Name.Contains("apple"));
        }
    }

    public class Product
    {
        public int Count { get; set; }

        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
