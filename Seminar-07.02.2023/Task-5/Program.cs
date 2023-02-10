// Задача 62: Заполните спирально массив 4 на 4.

int[,] arr =  new int[4, 4];
int value = 1;

Print2DArray(arr);
System.Console.WriteLine();
Print2DArray(CreatingSpiral(0, 0));

int[,] CreatingSpiral(int i, int j)
{
    if(arr[i, j] == 0)
    {
        arr[i, j] = value;
        value++;

        if(arr[i, j] == 11)
        {
            CreatingSpiral(i - 1, j);
        }   
                         
        if(j < arr.GetLength(1) - 1)
        {
            CreatingSpiral(i, j + 1);                       
        }
                
        if(i < arr.GetLength(0) - 1)
        {
            CreatingSpiral(i + 1, j);
        }

        if(j >= 1)
        {
            CreatingSpiral(i, j - 1);
        }

        if(i >= 1)
        {
            CreatingSpiral(i - 1, j);
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
