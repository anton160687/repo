Console.WriteLine("Введите координаты точки А x,y");
double AX = double.Parse(Console.ReadLine());
double AY = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B x,y");
double BX = double.Parse(Console.ReadLine());
double BY = double.Parse(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(AX-BX, 2)+Math.Pow(AY-BY, 2));
Console.WriteLine($"{distance:f2}");