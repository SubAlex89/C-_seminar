//Задача 41. Пользователь вводит с клавиатуры М чисел.
//Посчитайте сколько чисел больше 0 ввел пользователь.

/* Console.WriteLine("Ввдите числа через запятую");
string s = Console.ReadLine(); 
string[] nums = s.Split(',');

Console.WriteLine(s);

int[] mass = new int[nums.Length];
int count = 0;
for (int i = 0; i < nums.Length; i++)
{
    mass[i] = int.Parse(nums[i]); 
    if (mass[i] > 0)
    {
        count++;
    } 
}
Console.WriteLine("Введено чисел больше нуля: " + count); */

//Задача 43. НПк найдет точку пересечения двух прямых, заданных уравнениями 
// y=k1*+b1, y = k2*x+b2
// значения b1,b2,k1,k2 задаются пользователем  

Console.WriteLine("Введите коэффициент b1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент k1");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент k1");
double k2 = double.Parse(Console.ReadLine());



double x = (b2 - b1) / (k1 -k2);
double y1 = k1 * x + b1;
double y2 = k2 * x + b2;

if (k2 == k1 && b1 != b2)
{
    Console.WriteLine("Прямые параллельны");
}
else if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают");
}
else 
{
    Console.WriteLine("Координаты пересечения " + x + " " + y1);
}
