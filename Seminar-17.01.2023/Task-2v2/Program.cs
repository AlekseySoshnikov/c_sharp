// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

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

if (count < 3)
{
    Console.WriteLine("третьей цифры нет");
}
else 
{
    Console.WriteLine(number / (int) Math.Pow(10, count - 3) % 10);
}
