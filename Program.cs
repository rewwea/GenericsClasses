using System;

public class Program
{
    public static void Main(string[] args)
    {
        Store store = new Store();

        store.AddProduct(new Product("Яблоко", 0.99m, 100, DateTime.Now.AddMonths(1)));
        store.AddProduct(new Product("Банан", 0.59m, 200, DateTime.Now.AddMonths(2)));
        store.AddProduct(new Product("Апельсин", 1.29m, 150, DateTime.Now.AddMonths(3)));

        store.ShowProducts();

        Console.WriteLine("\nВведите название товара для покупки:");
        string productName = Console.ReadLine();
        Console.WriteLine("Введите количество:");
        int quantity = int.Parse(Console.ReadLine());

        store.BuyProduct(productName, quantity);

        Console.WriteLine("\nОставшиеся товары:");
        store.ShowProducts();

        MyArray<int> numbers = new MyArray<int>();
        numbers.AddElement(1);
        numbers.AddElement(2);
        numbers.AddElement(3);
        Console.WriteLine("\nЧисла в MyArray:");
        numbers.Print();

        Matrix<int> matrix = new Matrix<int>(2);
        matrix.SetElement(0, 0, 5);
        matrix.SetElement(0, 1, 10);
        matrix.SetElement(1, 0, 15);
        matrix.SetElement(1, 1, 20);
        Console.WriteLine("\nМатрица:");
        matrix.Print();
    }
}