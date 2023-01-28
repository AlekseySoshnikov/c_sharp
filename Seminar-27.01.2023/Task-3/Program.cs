// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] arr = GetRandomArray(10);
PrintArray(arr);
System.Console.WriteLine($" -> {FindingDifference(arr, MaxIndexNumber(arr), MinIndexNumber(arr))}");

int FindingDifference(int[] arr, int maxIndex, int minIndex)
{
    int dif = arr[maxIndex] - arr[minIndex];
    return dif;
}

int MaxIndexNumber(int[] arr)
{
    int maxIndex = 0;
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > arr[maxIndex])
        maxIndex = i;
    }
    return maxIndex;
}

int MinIndexNumber(int[] arr)
{
    int minIndex = 0;
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < arr[minIndex])
        minIndex = i;
    }
    return minIndex;
}

int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++) 
    {
        result[i] = new Random().Next(0, 100);
    }
    return result;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}
