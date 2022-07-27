//Задача 47. Задайте 2х мерный массив заполненный 
//случайными вещественными числами


/* Console.WriteLine("Введите первый размер матрицы ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второй размер матрицы ");
int n = int.Parse(Console.ReadLine());

double[,] mass = new double[m,n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = Math.Round(new Random().Next(0,11) + new Random().NextDouble(), 3);
    }
}

for (int i = 0; i < mass.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i,j] + " | ");
        }
} */

//Задача 50. НПк на вход принимает позиции элемента в 2мерном массиве
// возвращает значение этого элемента или же указание, что такого элемента нет.

/* 
int m = 3, n = 5;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = i + j;
    }
}

for (int i = 0; i < mass.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i,j] + " | ");
        }
}
Console.WriteLine();

Console.WriteLine("Укажите вертикальную позицию искомого эл-та");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите горизонтальную позицию искомого эл-та");
int y = int.Parse(Console.ReadLine());

if (x >= m && y >= n)
{
    Console.WriteLine("Указана позиция вне массива!!!");
}
else Console.WriteLine(mass[x,y]);
 */
//Задача 52. Задайте 2мерный массив из целых чисел.
//Найдите среднее арифметическое эл-ов в каждом столбце.

void Print2(int[,] arr) //ф-я вывода 2х мерного массива
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