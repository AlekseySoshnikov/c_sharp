// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Random rnd = new Random();
int x1 = rnd.Next(-10, 11);
int x2 = rnd.Next(-10, 11);
int y1 = rnd.Next(-10, 11);
int y2 = rnd.Next(-10, 11);
int z1 = rnd.Next(-10, 11);
int z2 = rnd.Next(-10, 11);

System.Console.WriteLine($"x1 = {x1}, x2 = {x2}, y1 = {y1}, y2 + {y2}, z1 = {z1}, z2 = {z2}");

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

System.Console.WriteLine(result);
