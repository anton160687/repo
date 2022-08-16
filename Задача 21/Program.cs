
/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
 A (7,-5, 0); B (1,-1,9) -> 11.53  */
Console.WriteLine("Введите координаты точки А x,y,z");
double AX = double.Parse(Console.ReadLine());
double AY = double.Parse(Console.ReadLine());
double AZ = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B x,y,z");
double BX = double.Parse(Console.ReadLine());
double BY = double.Parse(Console.ReadLine());
double BZ = double.Parse(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(AX-BX, 2)+Math.Pow(AY-BY, 2)+Math.Pow(AZ-BZ, 2));
Console.WriteLine($"{distance:f2}");

