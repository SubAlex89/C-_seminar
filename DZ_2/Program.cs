// НПк принимает на вход 3х значное число и на выходе 
// показывает вторую цифру этого числа

/* Console.WriteLine("Введите 3х значное число");
int num = int.Parse(Console.ReadLine());

if ( num < 100 | num > 999 )
{
    Console.WriteLine("Некорректное число");
}
else 
{
    int a1 = num / 10;
    int a2 = a1 % 10;
    Console.WriteLine(a2);
}
 */


// НПк принимает на вход цифру, обозначающую день недели  
// и проверяет является ли этот день выходным

Console.WriteLine("Введите число от 1 до 7");
int num = int.Parse(Console.ReadLine());

if ( num < 1 | num > 7 )
{
    Console.WriteLine("Некорректное число");
} 
    else 
        if ( num > 0 & num < 6 )
        {
        Console.WriteLine("Не выходной! Иди работай!");
        }
        else
        {
            Console.WriteLine("Выходной! Отдохни хорошенько!");
        }