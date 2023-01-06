System.Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    System.Console.WriteLine($"наибольшее число {num1}");
    System.Console.WriteLine($"наименьшее число {num2}");
}
else System.Console.WriteLine($"наибольшее число {num2}");
    System.Console.WriteLine($"наименьшее число {num1}");
   