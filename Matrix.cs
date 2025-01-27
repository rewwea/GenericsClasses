using System;

public class Matrix<T>
{
    private T[,] data;

    public Matrix(int size)
    {
        data = new T[size, size];
    }

    public void SetElement(int row, int col, T value)
    {
        if (row >= 0 && col >= 0 && row < data.GetLength(0) && col < data.GetLength(1))
        {
            data[row, col] = value;
        }
        else
        {
            Console.WriteLine("Индекс за пределами матрицы!");
        }
    }

    public T GetElement(int row, int col)
    {
        if (row >= 0 && col >= 0 && row < data.GetLength(0) && col < data.GetLength(1))
        {
            return data[row, col];
        }
        else
        {
            Console.WriteLine("Индекс за пределами матрицы!");
            return default(T); // Возвращаем значение по умолчанию
        }
    }

    public void Print()
    {
        int size = data.GetLength(0);
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(data[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}