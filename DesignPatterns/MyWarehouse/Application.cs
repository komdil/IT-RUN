using MyWarehouse.Repositories;
using MyWarehouse.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWarehouse
{
    public class Application
    {
        IProductRepository _productRepository;
        public Application()
        {
            _productRepository = new ProductRepository();
        }


        public void Start()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            bool isContinue = true;

            while (isContinue)
            {
                Console.Clear();
                ShowMenu();

                ConsoleKeyInfo userInput = Console.ReadKey(true);

                switch (userInput.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("Список продуктов:");
                        var products = _productRepository.GetAll();
                        foreach (var productForRead in products)
                        {
                            Console.WriteLine(productForRead);
                        }
                        break;

                    case ConsoleKey.B:

                        Console.WriteLine("Добавить продукт:");
                        Console.Write("Введите название продукта: ");
                        string newProduct = Console.ReadLine();

                        Console.Write("Введите кол-во продукта:");
                        int newProductQuantity = int.Parse(Console.ReadLine());

                        var existingProduct = _productRepository.ProductGetByName(newProduct);

                        if (existingProduct == null)
                        {
                            _productRepository.Add(newProduct, newProductQuantity);
                        }
                        else
                        {
                            int newQuantity = existingProduct.Quantity + newProductQuantity;
                            _productRepository.UpdateQuantity(newProduct, newQuantity);
                        }
                        break;


                    case ConsoleKey.C:
                        Console.WriteLine("Продать продукт:");
                        Console.Write("Введите название продукта: ");
                        string productForSell = Console.ReadLine();

                        Console.Write("Введите кол-во продукта:");
                        int sellProductQuantity = int.Parse(Console.ReadLine());

                        var product = _productRepository.ProductGetByName(productForSell);
                        if (product == null)
                        {
                            Console.WriteLine("Product ne nayden!");
                        }
                        else
                        {
                            int newQuantity = product.Quantity - sellProductQuantity;
                            _productRepository.UpdateQuantity(productForSell, newQuantity);
                        }

                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine("Выход из программы...");
                        isContinue = false;
                        break;

                    default:
                        break;
                }

                Console.WriteLine("Нажмите для продолжения.");
                Console.ReadKey();
            }
        }

        private void ShowMenu()
        {
            Console.WriteLine("Выберите действие: \n" +
                "а) Показать список продуктов\n" +
                "b) Добавить новый продукт\n" +
                "c) Продать продукт\n" +
                "ESC) Выйти из программы\n");
        }
    }
}
