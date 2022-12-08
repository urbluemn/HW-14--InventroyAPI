namespace HW_14__InventoryAPI.Models
{
    public class ProductModel
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public int Amount { get; private set; }
        public decimal Price { get; private set; }

        public ProductModel(string name, string type, int amount, decimal price)
        {
            Name = name;
            Type = type;
            Amount = amount;
            Price = price;
        }
    }
}
