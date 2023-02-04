// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Print2DArray(Generate2DArray(GetCountRow(), GetCountColumns()));

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

double[,] Generate2DArray(int m, int n)
{
    double[,] arr = new double[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            arr[i, j] = Convert.ToDouble(new Random().Next(-100, 100) / 10.0);
        }
    }
    return arr;
}

void Print2DArray(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
