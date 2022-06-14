/* // Напишите программу, которая на вход прнимает два числа и выдает
// какое число большее, а какое меньшее
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

if( a > b )
{
    Console.WriteLine("min = " + b);
    Console.WriteLine("max = " + a);
}
else if ( a == b )
{
    Console.WriteLine(a + " равно " + b );
}

else
{
    Console.WriteLine("min = " + a);
    Console.WriteLine("max = " + b);
}
 

//Напишите программу, которая принимает на вход 3 числа
//и выдает максимальное из этих чисел
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());

int max = 0;

if ( a > b ) max = a;
if ( b > a ) max = b;
if ( c > max) max = c;

Console.WriteLine("max = " + max);

//Напишите программу, которая на вход принимает число и выдает является ли оно четным

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

if ( a % 2 == 0 )
{
    Console.WriteLine( a + " - ЧЕТНОЕ");
}
else Console.WriteLine(a + " - НЕЧЕТНОЕ");
*/
//Напишите программу, которая на вход принимает число (N), а на выходе
//показывает все четные числа от 1 до N
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());

int i = 2;

while (i <= N)
{
    Console.Write(i + ", ");
    i+=2;
}