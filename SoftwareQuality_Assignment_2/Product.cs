namespace SoftwareQuality_Assignment_2
{
    public class Product
    {
        // Properties
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        // Constructor
        public Product(int productID, string productName, double price, int stock)
        {
            ProductID = productID;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        // Method to increase stock
        public void IncreaseStock(int amount)
        {
            var addedValue = Stock + amount;

            if (amount >= 0 && addedValue <= 1000)
            {
                Stock += amount;
            }
        }

        // Method to decrease stock
        public void DecreaseStock(int amount)
        {
            var decreasedValue = Stock - amount;

            if (amount > 0 && decreasedValue >= 0)
            {
                Stock -= amount;
            }
        }
    }
}
