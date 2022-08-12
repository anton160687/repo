Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
int num1 = num / 100;
int num2 = num / 10;
int result = num2 - num1 * 10;
Console.WriteLine($"Вторая цифра этого числа {num} = {result}");
