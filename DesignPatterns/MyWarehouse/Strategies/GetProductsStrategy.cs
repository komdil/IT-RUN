using MyWarehouse.Repositories;
using MyWarehouse.Repositories.Abstractions;
using MyWarehouse.Strategies.Abstractions;

namespace MyWarehouse.Strategies
{
    internal class GetProductsStrategy : ICommandLineStrategy
    {
        IProductRepository _productRepository;
        public GetProductsStrategy()
        {
            _productRepository = new ProductRepository();
        }

        public void Execute()
        {
            Console.WriteLine("Список продуктов:");
            var products = _productRepository.GetAll();
            foreach (var productForRead in products)
            {
                Console.WriteLine(productForRead);
            }
        }
    }
}
