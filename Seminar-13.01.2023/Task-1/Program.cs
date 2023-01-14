Console.WriteLine("Эта программа принимает на вход два числа и выдаёт, какое число большее (max), а какое меньшее (min).");

Console.Write("Введите, пожалуйста, первое число: ");
double number1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите, пожалуйста, второе число: ");
double number2 = Convert.ToDouble(Console.ReadLine());

if (number1 > number2) Console.WriteLine("Первое число больше второго числа: max=" + number1 + ", min =" + number2 + ".");
