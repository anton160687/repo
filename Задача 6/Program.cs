Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int b = a % 2;
if (b == 0) {
    Console.Write("Да");
}
else {
    Console.Write("Нет");
}