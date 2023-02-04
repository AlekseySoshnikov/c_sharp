// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int m = GetNumberRow();
int n = GetNumberColumns();

int[,] arr = Generate2DArray(3, 4);

Print2DArray(arr);
PrintResult(IsContaint(arr, m, n), arr, m, n);

void PrintResult(bool f, int[,] arr, int m, int n)
{
    if(f == false)
    {
        System.Console.WriteLine($"[{m}, {n}] -> такого числа в массиве нет");
    }
    else
    {
        System.Console.WriteLine($"[{m}, {n}] -> {arr[m, n]}");
    }
}

bool IsContaint (int[,] arr, int m, int n)
{
    return m < arr.GetLength(0) && n < arr.GetLength(1);  
}

int GetNumberRow()
{
    System.Console.Write("Введите, пожалуйста, номер позиции в столбце: ");
    int m = Convert.ToInt32(Console.ReadLine());

    return m;
}

int GetNumberColumns()
{
    System.Console.Write("Введите, пожалуйста, номер позиции в строке: ");
    int n = Convert.ToInt32(Console.ReadLine());

    return n;
}

int[,] Generate2DArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(-100, 100);
        }
    }
    return arr;
}

void Print2DArray(int[,] arr)
{
    System.Console.WriteLine("Задан массив:");
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
