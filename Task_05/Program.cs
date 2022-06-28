// Задача31. Задайте массив из 12 элементов, заполненый случайными числами из промежутка -9, 9. 
//найти сумму отрицательных и положительных элементов массива
/* 

void Print(int[] arr)
{
    for (int i = 0; i < arr.Lenght; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] mass = new int[12];

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-9, 10);
}

Print(mass);

int sumPos = 0;
int sumNeg = 0;

Console.WriteLine();

for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > 0)
    {
        sumPos += mass[i];
    }
    else
    {
        sumNeg += mass[i];
    }
}

Console.WriteLine("Положительные " + sumPos);
Console.WriteLine("Отрицательные " + sumNeg); */


// Задача 32: Напишите программу замена элементов
//массива: положительные элементы замените на
//соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

/* void Print(int[] arr) //ф-я печати массива
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
Print(Preobraz(mass)); // применяем ф-ю печати к функции преобразования с указанием массива

 */


// Задача 29:???
//сначала без функции
/* int Func(int c)
{
    c = new Random().Next(-100, 100);
    return c;
}

int[] n = new int[8];
for (int i = 0; i < n.Length; i++)
{
    n[i] = Func(n[i]);
    Console.Write($"{n[i]} ");
}
Console.WriteLine();
for (int i = 0; i < n.Length; i++)
{
    n[i]*=-1;
    Console.Write($"{n[i]} ");
}
Console.WriteLine();
Pov();

//с ф-ей
int Func(int c)
{
    c = new Random().Next(-100, 100);
    return c;
}
void Pov(int[] c)
{
    for (int i = 0; i < c.Length; i++)
    {
        c[i] *= -1;
        Console.Write($"{c[i]} ");
    }
}
int[] n = new int[8];
for (int i = 0; i < n.Length; i++)
{
    n[i] = Func(n[i]);
    Console.Write($"{n[i]} ");
}
Console.WriteLine();
Pov(n); */

//Задача33: задайте массив. Напишите программу которая определяет 
//присутствует ли заданное число в массиве
/* решение_1 
int Func(int c)
{
    c = new Random().Next(-100, 100);
    return c;
}
void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void Find(int[] arr, int a)
{
    bool flag = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((a == arr[i]) | (-a == arr[i]))
        {
            Console.WriteLine("Данное число в массиве присутствует");
            flag = true;
            break;
        }
    }
    if (flag == false)
        Console.WriteLine("Данного числа в массиве нет");
}

int[] n = new int[8];
for (int i = 0; i < n.Length; i++)
{
    n[i] = Func(n[i]);
}
Print(n);
Console.WriteLine();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
Find(n, a); */

// решение_2
// Присутствует ли заданное число в массиве
/* 
Console.WriteLine("Введите число для поиска");
int user = int.Parse(Console.ReadLine());

int [] array = new int [30];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
}
void PrintArray(int [] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
}

void Scan()
{
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == user)
    {
        Console.WriteLine("Присутствует");
        break;
    }
    else if (i == array.Length -1) 
    {
        Console.WriteLine("Отсутствует");
    }
}
}

PrintArray(array);
Console.WriteLine();
Scan();

//решение 3.

void Print(int[] arr) //ф-я печати массива
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

//решение1
/* int Func(int c)
{
    c = new Random().Next(-100, 1000);
    return c;
}
void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int Sum(int[] a)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if ((a[i]>=10) & (a[i]<=99))
        count++;
    }
    return count;
}

int[] n = new int[123];
for (int i = 0; i < n.Length; i++)
{
    n[i] = Func(n[i]);
}
Print(n);
Console.WriteLine();
Console.WriteLine(Sum(n));

//решение2

int [] array = new int [123];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-99, 100);
}
void PrintArray(int [] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
}

void Check()
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    
     if (array[i] > 9 & array[i] < 100)
     {
         count++;
     }
    }
Console.WriteLine(count);
}

PrintArray(array);
Console.WriteLine();
Check(); */

// Задача 37
//Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

/* int [] array = new int [6];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
}

int [] result = new int [(array.Length + 1)/2];

void PrintArray(int [] collection)

{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
}

void Multiplication()
{
for (int i = 0; i < (array.Length-1)/ 2; i++)
{
    //if (i <= (array.Length -1) / 2)
    {
    //Console.WriteLine(array[i] * array[array.Length - 1 - i]);//произведение пар с выодом в консоль
    result[i] = array [i] * array[array.Length];
    }
}
}

PrintArray(array);
Console.WriteLine();
Multiplication(); */