/* 
// Написать программу, которая на вход прнимает два числа 
//и проверяет является ли первое число квадратом второго

Console.WriteLine("Введите первое число: ");
int a = int.Parse( Console.ReadLine() );
Console.WriteLine("Введите второе число: ");
int b = int.Parse( Console.ReadLine() );

if ( a == b * b )
    Console.WriteLine(" ДА ");
else
    Console.WriteLine(" НЕТ ");

// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.WriteLine("Введите число от 1 до 7: ");
int a = int.Parse( Console.ReadLine() );
if ( a == 1 )
    Console.WriteLine("Понедельник");
else if (a == 2)
    Console.WriteLine("Вторник");
else if (a == 3)
    Console.WriteLine("Среда");
else if (a == 4)
    Console.WriteLine("Четверг");
else if (a == 5)
    Console.WriteLine("Пятница");
else if (a == 6)
    Console.WriteLine("Суббота");
else if (a == 7)
    Console.WriteLine("Воскресенье");
else 
    Console.WriteLine("Некорректное число");


// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает 
//все целые числа в промежутке от -N до N
// 4 > -4 -3 -2 -1 0 1 2 3 4

Console.WriteLine("Введите число");
int N = int.Parse( Console.ReadLine());
int i = -N;
while ( i <= N )
{
    Console.Write(i + " " );
    i++;
}
*/
/// Напишит программу, которая принимает на вход трехзначное
/// число и на выходе показывает поледнюю цифру этого числа

Console.WriteLine("Введите 3х значное число");
int a = int.Parse(Console.ReadLine());
if ((99 < a ) & ( a < 1000))
{
    Console.WriteLine(a % 10);
}
else Console.WriteLine("Некорректное число");
