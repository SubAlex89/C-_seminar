//Задача 53. Задайте двумерный массив. НПк поменяет 
// местами первую и последнюю строчку массива.


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

int m = 3, n = 4;
int [,] mass = new int [m,n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = i + j;
    }
}

Print2(mass);
int help = 0;

for (int i = 0; i < mass.GetLength(1); i++)
{
    help = mass[0,i];
    mass[0,i] = mass[mass.GetLength(0)-1,i];
    mass[mass.GetLength(0)-1,i] = help;
}

Print2(mass); */

//Задача 55. Задайте двумерный массив.
//НПк заменяет строки на столбцы.
//Если это невозможно вывести сообщение.

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

int m = 4, n = 4;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1,10);
    }
}
Print2(mass);



if (m != n) 
{
    Console.WriteLine("Невозможно произвести замену");
}

int help = 0;

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = i + 1; j < mass.GetLength(1); j++)
    {
        help = mass[i, j];
        mass[i, j] = mass[j, i];
        mass[j, i] = help;
    }
}

Print2(mass); */


// Задача57. Составить частотный словарь эл-в 2х мерного массива.
// Частотный словарь содержит инф-ю о том, сколько раз встречатся 
//элемент входных данных.

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

int m = 4, n = 4;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = i + j; //new Random().Next(1,10);
    }
}
Print2(mass);


int[] array = new int[mass.Length];
int k = 0;
bool finded = false;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        finded = false;
        for (int l = 0; l < k; l++)
        {
            if (array[l] == mass[i,j]) 
            {
                finded = true;
                break;
            }
            }
            if (!finded)
            {
                array[k] = mass[i,j];
                k++;
            }
    }
}

for (int i = 0; i < k; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for (int p = 0; p < k; p++)
{
    int num = array[p];
    int count = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (mass[i,j] == num) count++;
        }
    }

    Console.WriteLine($"{num} встречается {count} раз(а)");
}
 */

// Задача 59: Задайде 2мерный массив из целых чисел. НПК удалит строку и столбец
// на пересечении которых расположен наименьший элемент массива

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

int m = 4, n = 4;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = i + j; //new Random().Next(1,10);
    }
}
Print2(mass);

int min = mass[0,0];
int index1 = 0;
int index2 = 0;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (mass[i,j] < min) 
        {
            min = mass[i,j];
            index1 = i;
            index2 = j;
        }
    }
}
Console.WriteLine(min);

int [,] mass2 = new int [mass.GetLength(0) - 1, mass.GetLength(1) - 1];
int k = 0;
int l = 0;

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (i != index1 && j != index2)
        {
            //Console.Write(mass[i,j] + " ");
            k = i;
            if (i > index1) k = i - 1;
            l = j;
            if (l > index2) l = j - 1;
            mass2[k,l] = mass[i,j];
        }
    }
    
}
Print2(mass2);