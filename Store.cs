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
        Console.WriteLine("Доступные товары:");
        for (int i = 0; i < Products.GetElement(0).Quantity; i++) // Получаем первый элемент в MyArray
        {
            var product = Products.GetElement(i);
            Console.WriteLine($"Название: {product.Name}, Цена: {product.Price}, Количество: {product.Quantity}, Срок годности: {product.ExpiryDate.ToShortDateString()}");
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
                Console.WriteLine($"Покупка успешна! Общая стоимость: {totalPrice:C}");
                Console.WriteLine("Чек:");
                Console.WriteLine($"Товар: {product.Name}");
                Console.WriteLine($"Количество: {quantityToBuy}");
                Console.WriteLine($"Цена за единицу: {product.Price:C}");
                Console.WriteLine($"Общая стоимость: {totalPrice:C}");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Извините, товар либо отсутствует, либо его количество недостаточно.");
        }
    }
}