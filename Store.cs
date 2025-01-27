using System;
using System.Collections.Generic;

public class Store
{
    List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void PurchaseProduct(string productName, int quantity)
    {
        foreach (var product in products)
        {
            if (product.Name == productName)
            {
                if (product.Quantity >= quantity)
                {
                    product.Quantity -= quantity;
                    Console.WriteLine($"Приобретенный {quantity} от {productName}. Итоговая цена: {quantity * product.Price}");
                }
                else
                {
                    Console.WriteLine("Недостаточно запасов!");
                }
                return;
            }
        }
        Console.WriteLine("Товар не найден!");
    }
}