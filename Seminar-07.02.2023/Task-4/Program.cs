// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int x = 3;
int y = 4;
int z = 5;

PrintResult(Generate3DArray(GenerateArrayDistinctCount(x, y, z), x, y, z));

void PrintResult(int[,,] cube)
{
    for(int i = 0; i < cube.GetLength(0); i++)
    {
        for(int j = 0; j < cube.GetLength(1); j++)
        {
            for(int z = 0; z < cube.GetLength(2); z++)
            {
                System.Console.Write($"{cube[i, j, z]}[{i}, {j}, {z}] ");                
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

int[,,] Generate3DArray(int[] arr, int x, int y, int z)
{
    int[,,] cube = new int[x, y, z];
    int count = 0;
    for(int i = 0; i < cube.GetLength(0); i++)
    {
        for(int j = 0; j < cube.GetLength(1); j++)
        {
            for(int k = 0; k < cube.GetLength(2); k++)
            {
                cube[i, j, k] = arr[count];                
                count++;
            }
        }
    }
    return cube; 
}

int[] GenerateArrayDistinctCount(int x, int y, int z)
{
    int[] distinctCountArray = new int[x * y * z];
    int count = 0;    
    while(count < distinctCountArray.Length)
    {
        int f = 0;
        int number = new Random().Next(-99, 100);
        for(int i = 0; i < distinctCountArray.Length; i++)
        {
            if(number == distinctCountArray[i])
            {              
                f = 1;
            }
        }
        if(f != 1)
        {            
            distinctCountArray[count] = number;            
            count++;
        }        
    }
    return distinctCountArray;  
}
