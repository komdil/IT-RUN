using MyWarehouse.Repositories;
using MyWarehouse.Repositories.Abstractions;
using MyWarehouse.Strategies.Abstractions;

namespace MyWarehouse.Strategies
{
    internal class SellProductStrategy : ICommandLineStrategy
    {
        IProductRepository _productRepository;
        public SellProductStrategy(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public ConsoleKey StrategyKey => ConsoleKey.C;
        public void Execute()
        {
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
        }
    }
}
