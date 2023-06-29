namespace MyWarehouse.Repositories.Abstractions
{
    public interface IProductRepository
    {
        void Add(string productName, int quantity);

        void UpdateQuantity(string productName, int quantity);

        void Delete(string name);

        IEnumerable<Product> GetAll();

        Product ProductGetByName(string name);
    }
}
