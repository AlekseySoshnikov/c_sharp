// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 --> 2
// - 1, -7, 567, 89, 223 --> 3

string enter = InputString();
PrintArray(GetStringToInt(GetSplit(enter)));
System.Console.WriteLine($" --> {GetCheck(GetStringToInt(GetSplit(enter)))}");

int GetCheck(int[] arrInt)
{
    int count = 0;

    for(int i = 0; i < arrInt.Length; i++)
    {
        if(arrInt[i] > 0)
        {
            count++;
        }
    }

    return count;
}

int[] GetStringToInt(string[] arrSplit)
{
    int[] arrInt = Array.ConvertAll(arrSplit, int.Parse);

    return arrInt;
}

string[] GetSplit(string enter)
{
    string[] arrSplit = enter.Split(' ');

    return arrSplit;
}

string InputString()
{
    System.Console.WriteLine("Введите, пожалуйста, положительные и отрицательные числа разделяя их пробелом,");
    System.Console.Write("закончив ввод нажатием клавиши <Enter>: ");
    string enter = System.Console.ReadLine();

    return enter;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }

    Console.Write($"{arr[arr.Length - 1]}");
}
