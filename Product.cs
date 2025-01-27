using System;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public DateTime ExpiryDate { get; set; }

    public Product(string name, decimal price, int quantity, DateTime expiryDate)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
        ExpiryDate = expiryDate;
    }
}