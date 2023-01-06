Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int b = 10;
while (N > 1000)
{
    N = N / 10;
}
if (N >= 100)
{
    b = N % 10;

System.Console.WriteLine($"Третья цифра {b}");
}
else System.Console.WriteLine("Третьей цифры нет");