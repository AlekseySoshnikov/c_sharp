// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Матрицу A можно умножить на матрицу B только в том случае, если число столбцов матрицы A 
// равняется числу строк матрицы B. Матрицы, для которых данное условие не выполняется, умножать нельзя.

int m = 2;
int[,] arrA = Generate2DArray(4, m);
int[,] arrB = Generate2DArray(m, 3);

System.Console.WriteLine("Матрица А:");
Print2DArray(arrA);
System.Console.WriteLine("Матрица B:");
Print2DArray(arrB);
System.Console.WriteLine("Произведение матриц А * В = С:");

Print2DArray(MatrixMultiplication(arrA, arrB));

int[,] MatrixMultiplication(int[,] arrA, int[,] arrB)
{
    int[,] arrC = new int[arrA.GetLength(0), arrB.GetLength(1)];
    for(int i = 0; i < arrA.GetLength(0); i++)
    {
        for(int j = 0; j < arrB.GetLength(1); j++)
        {
            for(int z = 0; z < arrA.GetLength(1); z++)
            {
                arrC[i, j] += arrA[i, z] * arrB[z, j];
            }            
        }
    }
    return arrC;
}

int[,] Generate2DArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(1, 10);
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
