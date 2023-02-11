// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = 8;
int m = 1;

System.Console.WriteLine($"N = {n} -> \"{PrintNumbers(n, m)}\"");

string PrintNumbers(int n, int m)
{
    if(m == n)
    {
        return m.ToString();
    }
    return (n + ", " + PrintNumbers(n - 1, m));
}