//Напишите программу, которая выводит случайное число из отрезка [10.99]
//и показывает наибольшую цифру числа.

/* int num = new Random().Next(10, 100);

Console.WriteLine(num);

int c1 = num / 10;
int c2 = num % 10;

if ( c1 > c2)
{
    Console.WriteLine(c1);
}
else
{
    Console.WriteLine(c2);
} 

//НПк выводит случайное 3х значное число и удаляет вторую цифру этого числа

int num = new Random().Next(100, 1000);
Console.WriteLine(num);

int c1 = num % 10;
int c2 = num / 100;
Console.WriteLine($"{c2}{c1}");

//НПк принимает на вход два числа и выводит, является ли второк число кратным первому.
//если 2е не кратно 1му, то выводит остаток от деления

Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine());

int ost = num2 % num1;
if (ost == 0)
{
    Console.WriteLine("Кратно");
}
else Console.WriteLine("Не кратно, остаток от деления " + ost);

//НПк принимает на вход число и проверяет кратно оно одновременно 7 и 23.

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

if (( num % 7 == 0 ) & ( num % 23 == 0 ))
{
    Console.WriteLine("Кратно");
}
else Console.WriteLine("Не Кратно");

//НПк выводит третью цифру заданого числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if ( a < 100 )
{
    Console.WriteLine("Нет третьей цифры");
}
else
{
    while ( a > 999 )

    {
        a = a / 10;
    }
    int remain10 = a % 10;
    Console.WriteLine(remain10);
}
*/