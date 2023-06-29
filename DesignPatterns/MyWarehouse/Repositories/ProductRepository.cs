using MyWarehouse.Repositories.Abstractions;
using System.IO;
using System.Text;

namespace MyWarehouse.Repositories
{
    public class ProductRepository : IProductRepository
    {
        const string filePath = "store.txt";

        public void Add(string name, int quantity)
        {
            var producs = GetAll().ToList();
            producs.Add(new Product(name, quantity));
            SaveAllProducts(producs);
        }

        public void Delete(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            string[] products = File.ReadAllLines(filePath, Encoding.UTF8);
            Product[] AllProducts = new Product[products.Length];

            for (int i = 0; i < products.Length; i++)
            {
                string[] splitted = products[i].Split(' ');
                string productName = splitted[0];
                int productQuantity = int.Parse(splitted[1]);
                AllProducts[i] = new Product(productName, productQuantity);
            }

            return AllProducts;
        }

        public Product ProductGetByName(string name)
        {
            var products = GetAll();
            return products.SingleOrDefault(s => s.Name == name);
        }

        public void UpdateQuantity(string productName, int quantity)
        {
            var products = GetAll();
            var product = products.Single(s => s.Name == productName);
            product.Quantity = quantity;
            SaveAllProducts(products);
        }

        private void SaveAllProducts(IEnumerable<Product> products)
        {
            File.WriteAllLines(filePath, products.Select(s => $"{s.Name} {s.Quantity}"));
        }
    }
}
