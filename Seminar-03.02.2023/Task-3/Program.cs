// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = GetCountRow();
int n = GetCountColumns();
int[,] arr = Generate2DArray(m, n);

Print2DArray(arr);
PrintResult(arr);

void PrintResult(int[,] arr)
{
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    for(int j = 0; j < arr.GetLength(1) - 1; j++)
    {
        System.Console.Write($"{Math.Round(CalculationArithmeticMean(arr, j), 1)}; ");
    }
    System.Console.Write($"{Math.Round(CalculationArithmeticMean(arr, arr.GetLength(1) - 1), 1)}.");
}

double CalculationArithmeticMean(int[,] arr, int j)
{
    double sum = arr[0, j];
    for(int i = 1; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }

    return sum / arr.GetLength(0);  
}

int GetCountRow()
{
    System.Console.Write("Введите, пожалуйста, количество строк: ");
    int m = Convert.ToInt32(Console.ReadLine());

    return m;
}

int GetCountColumns()
{
    System.Console.Write("Введите, пожалуйста, количество столбцов: ");
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
            arr[i, j] = new Random().Next(0, 11);
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