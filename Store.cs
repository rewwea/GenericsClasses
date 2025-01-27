using System;

public class Store
{
    public MyArray<Product> Products { get; set; }

    public Store()
    {
        Products = new MyArray<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.AddElement(product);
    }

    public void ShowProducts()
    {
        Console.WriteLine("Available Products:");
        for (int i = 0; i < Products.GetElement(0).Quantity; i++) // Получаем первый элемент в MyArray
        {
            var product = Products.GetElement(i);
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}, Expiry Date: {product.ExpiryDate.ToShortDateString()}");
        }
    }

    public void BuyProduct(string productName, int quantityToBuy)
    {
        bool found = false;
        for (int i = 0; i < Products.GetElement(0).Quantity; i++)
        {
            var product = Products.GetElement(i);
            if (product.Name.ToLower() == productName.ToLower() && product.Quantity >= quantityToBuy)
            {
                product.Quantity -= quantityToBuy;
                decimal totalPrice = quantityToBuy * product.Price;
                Console.WriteLine($"Purchase successful! Total price: {totalPrice:C}");
                Console.WriteLine("Receipt:");
                Console.WriteLine($"Product: {product.Name}");
                Console.WriteLine($"Quantity: {quantityToBuy}");
                Console.WriteLine($"Price per unit: {product.Price:C}");
                Console.WriteLine($"Total: {totalPrice:C}");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Sorry, the product is either out of stock or doesn't exist.");
        }
    }
}