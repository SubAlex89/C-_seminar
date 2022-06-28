﻿/* // Задача 32: Напишите программу замена элементов
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