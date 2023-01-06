// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int  ReadInt (string argumentname)
{
    Console.Write( $" Input { argumentname }: " );
    return  int.Parse( Console.ReadLine ( ) ! ) ;
}

double  pow ( int  numA , int  numB )
{
    double result  =  Math.Pow( numA , numB );
    return  result ;
}

Console.WriteLine( " Введите число А " );
int  A  =  ReadInt ( " Число A " );
Console.WriteLine( " Введите число B " );
int  B  =  ReadInt ( " Число B " );
Console.WriteLine( pow ( A , B ));
