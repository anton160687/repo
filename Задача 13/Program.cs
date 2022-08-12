Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int num1 = num % 100;
int num2 = num % 1000;
int result = (num2 - num1) / 100;
int num3 = num / 100;
if (num3 != 0) {
Console.WriteLine($"{result}");
}
else {
   Console.WriteLine("третьей цифры нет");
}
