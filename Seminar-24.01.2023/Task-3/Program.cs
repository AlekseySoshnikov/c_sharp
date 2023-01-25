// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int len = new Random().Next(0, 11);

PrintResult(GetRandomArray(len));

int[] GetRandomArray (int len)
{
    int[] res = new int[len];

    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next(0, 100);
    }

    return res;
}

void PrintResult (int[] arr)
{
    for (int i = 0; i < arr.Length - 2; i++)
    {
        System.Console.Write(arr[i] + ", ");
    }
    System.Console.Write(arr[arr.Length - 1] + " -> [");

    for (int i = 0; i < arr.Length - 2; i++)
    {
        System.Console.Write(arr[i] + ", ");
    }
    System.Console.Write(arr[arr.Length - 1] + "]");

}
