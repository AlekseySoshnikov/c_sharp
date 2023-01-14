Console.WriteLine("Эта программа принимает на вход число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");

Console.Write("Введите, пожалуйста, число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) Console.WriteLine("Введённое Вами число является чётным.");
else Console.WriteLine("Введённое Вами число не является чётным.");
