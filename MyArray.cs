using System;
using System.Collections.Generic;

public class MyArray<T>
{
    List<T> elements = new List<T>();

    public void AddElement(T element)
    {
        elements.Add(element);
    }

    public void RemoveElement(int index)
    {
        if (index >= 0 && index < elements.Count)
        {
            elements.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Индекс выходит за рамки дозволенного!");
        }
    }

    public T GetElement(int index)
    {
        if (index >= 0 && index < elements.Count)
        {
            return elements[index];
        }
        else
        {
            Console.WriteLine("Индекс выходит за рамки дозволенного!");
            return default(T);
        }
    }

    public void Print()
    {
        foreach (var element in elements)
        {
            Console.WriteLine(element);
        }
    }
}