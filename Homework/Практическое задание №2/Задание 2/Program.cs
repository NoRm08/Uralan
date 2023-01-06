 System.Console.WriteLine("Введите цифру которая обозначает день недели: ");
 int N = int.Parse(Console.ReadLine());
 string x = "неверная цифра";
 if (N >= 1 && N <=5)
 {
    x = "рабочий день";
 }
 if (N == 6)
 {
    x = "выходной";
 }
 if (N == 7)
 {
    x = "выходной";
 }
 System.Console.WriteLine(x);