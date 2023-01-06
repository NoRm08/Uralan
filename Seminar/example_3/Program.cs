// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

Console.Write("Введите координату x для точки A: ");
int xA= int.Parse(Console.ReadLine()); 
Console.Write("Введите координату y для точки A: ");
int yA= int.Parse(Console.ReadLine()); 
Console.Write("Введите координату x для точки B: ");
int xB= int.Parse(Console.ReadLine()); 
Console.Write("Введите координату y для точки B: ");
int yB= int.Parse(Console.ReadLine());

// √((xb - xa)2 + (yb - ya)2)

double distance = 0;
distance = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
Console.WriteLine(Math.Round(distance, 3));
