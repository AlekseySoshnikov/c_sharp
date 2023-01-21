// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите, пожалуйста, число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"{number} -> ");

int num = number;
int count = 0;

while (num > 0)
{
    num = num / 10;
    count++;     
}

int revers = 0;

for (int i = 1; i <= count; i++)
{
    revers = revers + number / (int) Math.Pow(10, count - i) % 10 * (int) Math.Pow(10, i - 1);
}

if (number == revers)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}
