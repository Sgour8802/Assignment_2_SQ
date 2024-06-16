namespace SoftwareQuality_Assignment_2
{
    public class Product
    {
        // Properties
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product() { }

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

            if (amount > 0 && addedValue <= 1000)
            {
                Stock += amount;
            }
            else
            {
                Stock = 1000;
                throw new InvalidOperationException($"Invalid value: Cannot increase stock by {amount}. Stock cannot exceed 1000.");

            }
        }

        // Method to decrease stock
        public void DecreaseStock(int amount)
        {
            if (amount > 0 && Stock - amount >= 0)
            {
                Stock -= amount;
            }
            else
            {
                Stock = 0;
                throw new InvalidOperationException($"Invalid value: Cannot decrease stock by {amount}. Stock cannot be decreased below 0.");
            }
        }

    }
}
