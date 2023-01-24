// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int A = GetRandomNumber();
int B = GetRandomNumber();

PrintResult(A,B,GetPow(A,B));

int GetRandomNumber ()
{
    int number = new Random().Next(1,6);
    return number;
}

int GetPow (int A, int B)
{
    int result = A;
    for (int i = 2; i <= B; i++)
    {
        result *= A;
    }

    return result;
}

void PrintResult (int A, int B, int PowResult)
{
    System.Console.WriteLine($"{A}, {B} -> {PowResult}");
}
