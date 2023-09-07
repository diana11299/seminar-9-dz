//Задача 64: Задайте значение N. Напишите программу,
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
string PrintNumb( int str, int end)
{
    if(str == end) return str.ToString();
    return( PrintNumb(1 + str , end) + str +" " );
}
Console.WriteLine(PrintNumb (1,8));
*/


//Задача 66: Задайте значения M и N. Напишите программу,
//которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
Console.Write("Imput the number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput the number N: ");
int n = Convert.ToInt32(Console.ReadLine());
int SumNumb(int m, int n)
{
    if (m==n)return n;
    else return m + SumNumb(m + 1, n);
}
Console.Write($"The sum of natural elements in the interval from M to N is equal to {SumNumb(m,n)}");
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
/*
Console.Write("Imput the number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput the number N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Ackerman(int m, int n)
{
    if ( m ==0 ) return n + 1;
    if ( n ==0) return Ackerman( m -1 , 1);
    return Ackerman( m -1, Ackerman( m, n -1));
}
Console.Write($"Result of the Ackerman function : {Ackerman(m,n)}");
*/