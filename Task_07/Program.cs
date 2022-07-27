//Задача 46. Задайте 2х мерный массив размером MxN заполненнй случайными целыми числами
/* M = 3, N = 4
1 4 8 19
5 -2  33 -2
77 3 8 1 */
/* 
void Print(int[,] arr) //ф-я вывода 2х мерного массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = 3, n = 4;
int[,] mass = new int[m, n]; //объявление 2х мерного массива

for (int i = 0; i < mass.GetLength(0); i++) //цикл заполнения рандомными значениями 
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(-100, 100);
    }
}

Print(mass);

for (int i = 0; i < mass.GetLength(0); i++)  //для примера цикл в котором вычитается 100 из каждого эл-та массива
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = mass[i,j] - 100;
    }
}

Print(mass); */

// Задача48: задайте 2х мерный массив размера m на n, каждый элемен которого
//находится по формуле A[m,n] = m+n
//Выведите полученый массив на экраны
//m = 3, n = 4
//0123
//1234
//2345
/* void Print(int[,] arr) //ф-я вывода 2х мерного массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = 3, n = 4;
int[,] mass = new int[m, n]; //объявление 2х мерного массива

for (int i = 0; i < mass.GetLength(0); i++) //цикл заполнения рандомными значениями 
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = i + j;
    }
}

Print(mass); */

//Задача 49. Задайте 2х мерный массив. Найдите элементы, y которых 
//оба индекса четные и замените эти элементы на их квадраты.

/* void Print(int[,] arr) //ф-я вывода 2х мерного массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }
        Console.WriteLine();
    }
}
int m = 3, n = 4;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = i + j;
    }
}
Console.WriteLine("Изначальный массив");
Print(mass);

for (int i = 0; i < mass.GetLength(0); i+=2)
{
    for (int j = 0; j < mass.GetLength(1); j+=2)
    {
        mass[i,j] *= mass[i,j];
    }
}
Console.WriteLine("Измененный массив");
Print(mass); */


//Задача51. Задайте 2х мерный массив. Найдите сумму эл-в нах-ся на главной диагонали
//индексы (0,0) (1,1) и т.д. 

void Print(int[,] arr) //ф-я вывода 2х мерного массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }
        Console.WriteLine();
    }
}
int m = 3, n = 5;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = i + j;
    }
}

Print(mass);
int sum = 0;
//for (int i = 0; i < mass.GetLength(0) && i < mass.GetLength(1); i++)

for (int i = 0; i < Math.Min(mass.GetLength(0), mass.GetLength(1)); i++)
{
    // for (int j = 0; j < mass.GetLength(1); j++)
   // {
   //     if (i == j) sum += mass[i,j];  
   // } 
    sum += mass[i,i];
}
Console.WriteLine();
Console.WriteLine(sum);