public class Product
{
    public int ProductID { get; set; }
    public string? ProductName { get; set; } 
    public decimal Price { get; set; }
    public int Stock { get; set; }

    // Constructor 
    public Product(int productID, string productName, decimal price, int stock)
    {
        ProductID = productID;
        ProductName = productName;
        Price = price;
        Stock = stock;
    }

    // Method to  increase
    public void IncreaseStock(int quantity)
    {
        Stock += quantity;
    }

    // Method to decrease 
    public void DecreaseStock(int quantity)
    {
        Stock -= quantity;
    }
}