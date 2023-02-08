// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] arr = Generate2DArray(GetCountRow(), GetCountColumns());

Print2DArray(arr);
System.Console.WriteLine();
Print2DArray(SortArray(arr));

int[,] SortArray(int[,] arr)
{
    int[] temp = new int[arr.GetLength(1)];

    for(int i = 0; i < arr.GetLength(0); i++)
    {        
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            temp[j] = arr[i, j];            
        }

        Array.Sort(temp);
        Array.Reverse(temp);

        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = temp[j];            
        }
    }
    return arr;
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
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}