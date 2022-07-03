//Задача 39. НПк перевернет одномерный массив
//последний элемент будет на первом месте, а первый на последнем и тд

/* void Print(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
}

int [] mass = new int[10];

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(1, 10);
}

Print(mass);

int save;

for (int i = 0; i < mass.Length / 2; i++)
{
    save = mass[i];
    mass[i] = mass[mass.Length - 1 - i];
    mass[mass.Length - 1 - i] = save;
}

Print(mass); */

//Задача 40. НПк принимает на вход три числа и проверяет 
//может ли существовать треугольник со сторонами такой длины

/* 
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

if ( a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine("Треугольник существует");
}
else Console.WriteLine("Треугольник не существует"); */

//Задача42. НПк преобразовывает десятичное число в двоичное
// решение 1 через массив
/* Console.WriteLine("Введите число: ");
int num10 = int.Parse(Console.ReadLine());
int count = num10;

int index = 0;
while (count > 0) //счетчик для понимая размера массива 
{
    count = count / 2;
    index++;
}

void Func10to2 (int index, int num10)
{
int[] num2 = new int[index];
for (int i = 0; num10 > 0; i++)
{
    num2[num2.Length - 1 - i] = num10 % 2; //переводим десятичное в двоичное и сразу записываем в обратном порядке
    num10 = num10 / 2;
}
for (int i = 0; i < num2.Length; i++)
    {
        Console.Write(num2[i] + " ");
    }
    Console.WriteLine();
}
Func10to2(index,num10); */


//решение 2 через строку
/* 
Console.WriteLine("Введите десятичное число: ");
int numb10 = int.Parse(Console.ReadLine());
int numb2;
string res = string.Empty;
string BinaryConverter(int numb10)
{
for (; numb10 > 0; numb10 = numb10 / 2)
{
numb2 = numb10 % 2;
res = numb2 + res;
}
return res;
}
Console.WriteLine(BinaryConverter(numb10)); */


//Задача44. Не используя рекурсию выведите N чисел фибоначчи
//Первые два числа Фибоначччи 0 и 1. 0 1 1 2 3 5 8 12 20...
/* void Print(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
}


void F (int n)
{
    int[] Fib = new int[n];
    Fib[0] = 0;
    Fib[1] = 1;
    for (int i = 2; i < Fib.Length; i++)
    {
        Fib[i] = Fib[i - 1] + Fib[i - 2];
    }
    Print(Fib);
}
Console.WriteLine("Введите число ");
int N = int.Parse(Console.ReadLine());

F(N);
 */

//Задача45 НПк будет создавать копию массива поэлементно

/* void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
Console.WriteLine();
}

int[] CreateMass(int n, int[] arr)
{
    //int[] mass = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    Print(arr);
    return arr;
}

int[] CopyMass(int[] arr)
{
    int[] copy_mass = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copy_mass[i] = arr[i];
    }
    Print(copy_mass);
    return copy_mass;
}

Console.WriteLine("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());

int[] mass = new int[n];

CopyMass(CreateMass(n, mass)); */

// инструмент "Split" делит стоку


Console.WriteLine("Ввдите числа через запятую");
string s = Console.ReadLine(); //объявляем строку и считываем даные с консоли
string[] nums = s.Split(',');  //делим элементы строки разделенные запятыми и помещаем в массив nums

Console.WriteLine(s);

int[] mass = new int[nums.Length]; //объявляем массив длинной как массив nums
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine("Подстрока: " + nums[i]); //выводим поочередно элементы массива nums
    mass[i] = int.Parse(nums[i]);               //переводим строки в числа
    Console.WriteLine("Число в квадрате: " + mass[i] * mass[i]); //возводим в квадрат числа
}
