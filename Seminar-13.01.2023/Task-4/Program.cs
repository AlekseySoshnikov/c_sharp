Console.WriteLine("Эта программа принимает на вход число (N), а на выходе показывает все чётные числа от 1 до N.");

Console.Write("Введите, пожалуйста, N = ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write(N + " -> ");

if (N != 1)
{
    int count = 3;
    Console.Write(" 2");
    while (count <= N)
    {    
        if (count % 2 == 0) 
        {
            Console.Write(", ");
            Console.Write(count);
        }
        count++;
    }
}    
