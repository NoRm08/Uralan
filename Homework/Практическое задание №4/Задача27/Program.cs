// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int  ReadInt ( string argumentname)
{
    Console.Write( $" Input { argumentname}: " );
    return int.Parse( Console.ReadLine()!) ;
}

System.Console.WriteLine(" Введите число ");
int  n  =  ReadInt ( " Число " );
int sum  =  0 ;
while ( n  >  0 )
{
    sum  +=  n  %  10 ;
    n  =  n  /  10 ;
}
System.Console.WriteLine( sum );
