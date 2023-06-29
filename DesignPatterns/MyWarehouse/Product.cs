namespace MyWarehouse
{
    public class Product
    {
        public Product(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"{Name} {Quantity}";
        }
    }
}
