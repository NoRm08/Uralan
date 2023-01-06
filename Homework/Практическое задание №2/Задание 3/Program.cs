Console.WriteLine("Ввдите трехзначное число: ");
int N = int.Parse(Console.ReadLine());
int b = 0;
if (N >= 100 && N < 1000)
{
    b = (N / 10) % 10;
    System.Console.WriteLine($"Вторая цифра вашего числа: {b}");
}
else System.Console.WriteLine("неверное число");
