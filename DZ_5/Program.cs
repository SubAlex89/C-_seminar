//Задаа34. Задайте массив заполненный случайными положительными
//трехзначными числами. НПк покажет количествр четных чисел в массиве
/* 
void Print(int[] arr) //ф-я печати массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
        //Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] mass = new int[10];
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(100, 1000);
    }

Print(mass);


void CountEven( int[] mass)
{
    int count = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество четных чисел в массиве " + count);
}
CountEven(mass); */

//Задача36. Задайте одномерный массив заполненный случайными числами
//Найдите сумму эл-в стоящих на нечетных позициях

/* void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] mass = new int[10];
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(0, 10);
    }

Print(mass);

void Summa(int[] mass) //ф-я подсчета суммы и вывода результата
{
    int sum = 0;
    for (int i = 1; i < mass.Length; i += 2)
    {
        sum += mass[i];
    }
Console.WriteLine($"Сумма эл-в нечетных позиций: " + sum);
}
Summa(mass); */

//Задача 38. Задайте массив вещественных чисел.
//найдите разницу между макс и мин элементом массива

void Print(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

double[] mass = new double[5];
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = Math.Round(new Random().NextDouble(),5);
    }

Print(mass);

void Diff(double[] mass) //ф-я поиска мин и макс, нахождения разницы и печати результата
{ 
double max = 0;
double min = mass[0];

for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > max) max = mass[i];

    if (mass[i] < min) min = mass[i];
}
double res = max - min;

//Console.WriteLine(min);
//Console.WriteLine(max);
Console.WriteLine($"Разница между MAX и MIN: " + res);
}
Diff(mass);