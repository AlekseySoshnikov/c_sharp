// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 --> (-0,5; -0,5)

System.Console.WriteLine("Введите, пожалуйста, b1, k1, b2 и k2, заканчивая ввод каждого числа нажатием клавиши <Enter>:");

System.Console.Write("b1 = ");
double b1 = Convert.ToDouble(System.Console.ReadLine());

System.Console.Write("k1 = ");
double k1 = Convert.ToDouble(System.Console.ReadLine());

System.Console.Write("b2 = ");
double b2 = Convert.ToDouble(System.Console.ReadLine());

System.Console.Write("k2 = ");
double k2 = Convert.ToDouble(System.Console.ReadLine());

Console.Clear();

PrintResult(b1, k1, b2, k2, CalculationX(b1, k1, b2, k2), CalculationY(b1, k1, CalculationX(b1, k1, b2, k2)));

double CalculationX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);

    return x;
}

double CalculationY(double b1, double k1, double x)
{
    double y = k1 * x + b1;

    return y;
}

void PrintResult(double b1, double k1, double b2, double k2, double x, double y)
{
    System.Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} --> ({x}; {y})");
}
