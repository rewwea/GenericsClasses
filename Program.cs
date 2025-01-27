using System;

class Program
{
    static void Main()
    {
        Store store = new Store();
        store.AddProduct(new Product("Milk", 1.2, 100));
        store.AddProduct(new Product("Bread", 0.5, 200));

        store.PurchaseProduct("Milk", 2);
        store.PurchaseProduct("Bread", 5);


        MyArray<int> intArray = new MyArray<int>();
        intArray.AddElement(10);
        intArray.AddElement(20);
        intArray.AddElement(30);
        intArray.Print();

        intArray.RemoveElement(1);
        intArray.Print();

        Console.WriteLine("Element at index 1: " + intArray.GetElement(1));


        Matrix<int> matrix = new Matrix<int>(3);
        matrix.SetElement(0, 0, 1);
        matrix.SetElement(0, 1, 2);
        matrix.SetElement(0, 2, 3);
        matrix.SetElement(1, 0, 4);
        matrix.SetElement(1, 1, 5);
        matrix.SetElement(1, 2, 6);
        matrix.SetElement(2, 0, 7);
        matrix.SetElement(2, 1, 8);
        matrix.SetElement(2, 2, 9);

        matrix.Print();
    }
}