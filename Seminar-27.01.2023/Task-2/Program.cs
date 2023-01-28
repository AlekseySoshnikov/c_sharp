// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = GetRandomArray(4);
PrintArray(arr);
System.Console.WriteLine($" -> {СountingSumElementsOfOddPositions(arr)}");

int СountingSumElementsOfOddPositions(int[] arr)
{
    int sum = arr[1];
    for(int i = 3; i < arr.Length; i+=2)
    {
        sum+=arr[i];
    }
    return sum;
}

int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++) 
    {
        result[i] = new Random().Next(-20, 21);
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
