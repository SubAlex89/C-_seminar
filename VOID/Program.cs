/* // Задача 32: Напишите программу замена элементов
//массива: положительные элементы замените на
//соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


void Print(int[] arr) //ф-я печати массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] CreateMass (int n) //ф-я создания и заполнения массива. n - размер массива задающийся пользователем
{
    int[] mass = new int[n];
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(-9, 10);
    }
    return mass;
}


int[] Preobraz(int[] mass) //ф-я умножения кадого эл-та массива на -1
{
    for (int i = 0; i < mass.Length; i++)
    {
     mass[i] *= -1;
    }
return mass;
}
Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());

int [] mass = CreateMass(n); //обьявляем массив и заполняем его ф-ей создания и заполнения масссива
Print(mass); // применем функцию печати к созданному массиву
Print(Preobraz(mass)); // применяем ф-ю печати к функции преобразования с указанием массива */

//Задача33: задайте массив. Напишите программу которая определяет 
//присутствует ли заданное число в массиве

/* void Print(int[] arr) //ф-я печати массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
        //Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}


int[] CreateMass (int n) //ф-я создания и заполнения массива. n - размер массива задающийся пользователем
{
    int[] mass = new int[n];
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(-9, 10);
    }
    return mass;
}


Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());

int[] mass = CreateMass(n); //объявляем массив и заполняем ф-ей

Console.Write("Введите число для проверки: ");
int p = int.Parse(Console.ReadLine());

Print(mass);

bool Exist = false; //вводим булево значение для фиксирования нахождения
//или не нахождения числа в массиве

for (int i = 0; i < mass.Length; i++) 
{
    if ( mass[i] == p ) //сверяем каждый элемент массива с искомым числом
    {
        Exist = true; //при нахождении фиксируем 
        break; //и прерываем цикл
    }
    
}
if (Exist == true) Console.WriteLine("Элемент найден");
else Console.WriteLine("Элемент НЕ найден"); */

/* Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

/* int[] mass = new int[123];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(0,200);
    Console.Write($"{mass[i]} ");
}
int Summa(int[] mass)
{
    int count = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > 9 && mass[i] < 100)
        count++;
    }
    return count;
}

Console.WriteLine();
Console.WriteLine("Количество элементов в заданном отрезке " + Summa(mass)); */

// Задача 37
//Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

/* void Print(int[] arr) //ф-я печати массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
        //Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] mass = new int[5];
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(1, 10);
    }

int[] mass2 = new int[(mass.Length +1)/2];

for (int i = 0; i < mass2.Length; i++)
{
    mass2[i] = mass[i] * mass[mass.Length -1 -i];
}

if (mass.Length % 2 == 1) mass2[mass2.Length -1] = mass[mass.Length / 2];

Print(mass);
Console.WriteLine();
Print(mass2); */

//Задача42. НПк преобразовывает десятичное число в двоичное

/* void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите число: ");
int num10 = int.Parse(Console.ReadLine());
int count = num10;

int index = 0;
while (count > 0) //счетчик для понимая размера массива 
{
    count = count / 2;
    index++;
}
//Console.WriteLine(index);
int[] num2 = new int[index]; 

for (int i = 0; num10 > 0; i++)
{
    num2[num2.Length - 1 - i] = num10 % 2; //переводим десятичное в двоичное и сразу записываем в обратном порядке
    num10 = num10 / 2;
}
Print(num2); */

//Задача 52. Задайте 2мерный массив из целых чисел.
//Найдите среднее арифметическое эл-ов в каждом столбце.

/* void Print2(int[,] arr) //ф-я вывода 2х мерного массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }
    Console.WriteLine();
    }
Console.WriteLine();
}

void Print1(double[] arr) //ф-я вывода 1х мерного массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "  ");
    }
Console.WriteLine();
}

int n = 6;
int m = 5;
int[,] mass = new int[n,m];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = i + j;
    }
}

Print2(mass);

double[] average = new double[m];

for (int j = 0; j < mass.GetLength(1); j++)
{

    for (int i = 0; i < mass.GetLength(0); i++)
    {
        average[j] += mass[i,j];
    }
average[j] = average[j] / n;
}

Print1(average);
 */

static int A(int n, int m)
    {
        if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
        if (n == 0) return m + 1;
        if (m == 0) return A(n - 1, m);
        return A(n - 1, A(n, m - 1));
    }
    //static void Main(string[] args)

Console.WriteLine(A(2, 5));
Console.WriteLine(A(1, 2));
