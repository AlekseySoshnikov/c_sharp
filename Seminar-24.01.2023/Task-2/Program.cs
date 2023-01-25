// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = GetRandomNumber();

PrintResult(number, SummingNumber(number));

int SummingNumber (int number)
{
    int result = 0;

    while (number > 0)
    {
        result = result + number % 10;
        number /= 10;
    }

    return result;
}

int GetRandomNumber ()
{
    int number = new Random().Next(1, 10000);

    return number;
}

void PrintResult (int number, int result)
{
    System.Console.Write($"{number} -> {result}");
}
