// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int[,] arr = Generate2DArray(GetCountRow(), GetCountColumns());

Print2DArray(arr);
System.Console.WriteLine();
PrintResult(CalculatingTheSumOfLineElements(arr));

int[] CalculatingTheSumOfLineElements(int [,] arr)
{
    int[] sum = new int[arr.GetLength(0)];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            sum[i] += arr[i, j];            
        }                
    }
    return sum;
}

void PrintResult(int[] sum)
{
    int minIndex = 0;    
    for(int i = 1; i < sum.Length; i++)
    {
        if(sum[minIndex] > sum[i])
        {
            minIndex = i;                
        }                       
    }
    System.Console.WriteLine($"Строка № {minIndex + 1} имеет наименьшую сумму элементов: {sum[minIndex]}.");
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
            arr[i, j] = new Random().Next(1, 11);
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
