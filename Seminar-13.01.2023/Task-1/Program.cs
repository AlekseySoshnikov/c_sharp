Console.WriteLine("Эта программа принимает на вход два числа (a и b) и выдаёт, какое число большее (max), а какое меньшее (min).");

Console.WriteLine("Введите, пожалуйста, числа, используя разделитель ',' для дробных:");
Console.Write("a = ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("b = ");
double b = Convert.ToDouble(Console.ReadLine());

if (a > b) Console.WriteLine("Первое число больше второго числа: max = " + a + "; min = " + b + ".");
if (b > a) Console.WriteLine("Второе число больше первого числа: max = " + b + "; min = " + a + ".");
if (a == b) Console.WriteLine("Введённые числа равны, определить какое из них больше (max), а какое меньше (min) не представляется возможным.");
