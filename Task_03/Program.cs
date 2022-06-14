/* //НПк считывает координаты X,Y и показывает номер четверти

Console.WriteLine("Введите X");
int X = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y");
int Y = int.Parse(Console.ReadLine());

Console.WriteLine($"Координаты X:{X}, Y:{Y}");

if ( X > 0 && Y > 0)
{
    Console.WriteLine(1);
}
else if ( X < 0 && Y > 0)
{
    Console.WriteLine(2);
}
else if ( X < 0 && Y < 0)
{
    Console.WriteLine(3);
}
else if ( X > 0 && Y < 0)
{
    Console.WriteLine(4);
}
else
{
    Console.WriteLine("Координаты не соответствуют четверти!");
} 

//НПк по заданному номеру четверти показывает диапазон 
//возможных координат точек в этой четверти

Console.WriteLine("Введите номер четверти");
int num = int.Parse(Console.ReadLine());

if ( num == 1 )
{
    Console.WriteLine(" X от 0 до +бесконечности. Y от 0 до +бесконечности");
}
else if ( num == 2 )
{
    Console.WriteLine(" X от 0 до -бесконечности. Y от 0 до +бесконечности");
}
else if ( num == 3 )
{
    Console.WriteLine(" X от 0 до -бесконечности. Y от 0 до -бесконечности");
}
else if ( num == 4 )
{
    Console.WriteLine(" X от 0 до +бесконечности. Y от 0 до -бесконечности");
}
else Console.WriteLine("Некорректное значение");


//НПк принимает на вход координаты двух точек и находит 
//расстояние между ними в 2D простарнстве

Console.WriteLine("Введите координату x1");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y1");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату x2");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y2");
int y2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt( Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

Console.WriteLine(Math.Round(result,2));


//НПк принимает на вход число N и выдает таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());

int i = 1;

while ( i <= N )
{
    Console.Write(Math.Pow(i,2)+ ",  ");
    i++;
}
*/

//НПк 