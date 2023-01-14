Console.WriteLine("Эта программа принимает на вход три числа (a, b и c) и выдаёт максимальное (max) из этих чисел.");

Console.WriteLine("Введите, пожалуйста, числа, используя разделитель ',' для дробных:");
Console.Write("a = ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("b = ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("c = ");
double c = Convert.ToDouble(Console.ReadLine());

double max = a;

if ((a == b) && (b == c)) Console.WriteLine("Введённые числа равны, определить максимальное из них (max) не представляется возможным.");
else
{
    if (b > max) max = b;
    if (c > max) max = c;
    Console.WriteLine("Максимальное из введённых чисел max = " + max + ".");
} 
