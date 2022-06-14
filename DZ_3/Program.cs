/* 
//НПк принимает на вход 5-значное число и проверяет является ли оно палиндромом.
Console.WriteLine("Введите 5-значное число");
int num = int.Parse(Console.ReadLine());

if ( num < 10000 | num > 99999)
{
    Console.WriteLine("Некорректное число");
}

    else if ( num / 10000 == num % 10 && (num / 1000) % 10 == (num % 100) / 10 )
        {
            Console.WriteLine("Является палиндромом");
        }
    else Console.WriteLine("Не является палиндромом");

     
//НПк принимает на вход координаты двух точек и находит расстоянике
// между ними в 3D простанстве

Console.WriteLine("Введите координату x1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y1");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z1");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату x2");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y2");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z2");
int z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));
Console.WriteLine(Math.Round(result,2));
*/

// НПк принимает на вход число N и выдает таблицу кубов от 1 до N

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());

int i = 1;
while ( i <= N )
{
    Console.Write(Math.Pow(i,3) + " ");
    i++;
}