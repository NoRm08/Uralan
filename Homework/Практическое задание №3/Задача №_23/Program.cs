// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.Console.WriteLine("Введите число: ");

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int count = 1;
while (count <= N)
{
    Console.Write($" {Math.Pow(count, 3)},  ");
    count++;
}