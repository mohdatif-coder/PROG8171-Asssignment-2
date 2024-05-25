using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Product ID: ");
        int productID = int.Parse(Console.ReadLine());

        Console.Write("Enter Product Name: ");
        string? productName = Console.ReadLine();

        Console.Write("Enter Price: ");
        decimal price = decimal.Parse(Console.ReadLine());

        Console.Write("Enter Initial Stock : ");
        int stock = int.Parse(Console.ReadLine());

        Product product = new Product(productID, productName, price, stock);


        //

        Console.WriteLine($"Product ID: {product.ProductID}");

        Console.WriteLine($"Product Name: {product.ProductName}");

        Console.WriteLine($"Price: {product.Price:C}");

        Console.WriteLine($"Stock: {product.Stock}");
     
        
        //


        Console.Write("Enter quantity to increase stock: ");
        int increaseQuantity = int.Parse(Console.ReadLine());
        product.IncreaseStock(increaseQuantity);
        Console.WriteLine($"Stock after increase: {product.Stock}");

        Console.Write("Enter quantity to decrease stock: ");
        int decreaseQuantity = int.Parse(Console.ReadLine());
        product.DecreaseStock(decreaseQuantity);
        Console.WriteLine($"Stock after decrease: {product.Stock}");
    }
}