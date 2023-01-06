// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

SumInRangeMN(ReadInt("from"), ReadInt("to"), 0);

void SumInRangeMN(int m, int n, int sum)
{
    sum += n;
    if (n <= m)
    {
        System.Console.Write($"{sum}");
        return;
    }
    System.Console.WriteLine($"{m} + {n} = {sum}");
    SumInRangeMN(m, n - 1, sum);
}
int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine()!);
}

