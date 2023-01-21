// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите, пожалуйста, число: ");
string number = Console.ReadLine();

Console.Write($"{number} -> ");

for (int i = 0; i < number.Length / 2; i++)
{
    if (number[i] != number[number.Length - 1 + i])
    {
        System.Console.WriteLine("нет");
        break;
    }
    else
    {
        System.Console.WriteLine("да");
    }
}
