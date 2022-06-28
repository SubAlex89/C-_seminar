// Задача 25
// Напишите цикл, который принимает на вход два числа А и В
// и возводит число А в натуральную степень В

/* Console.WriteLine("Введите первое число");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = int.Parse(Console.ReadLine());  

int res = 1;
for (int i = 1; i <= B; i++)
{ 
    res = res * A;
}
Console.WriteLine(res);
 */

 //Задачаа 27
 //НПк принимает на вход число и выдает сумму цифр в числе

/* int Count(int input)
{
    int ost = 0;
    int sum = 0;
    while( input > 0 )
    {
        ost = input % 10;
        sum = sum + ost;
        input = input / 10;
    }
    
    return sum;
}
Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Count(num)); */

//Задача 29
//НПк задает массив из 8 эл-тов и выводит их на экран

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,100);
}

void PrintArray (int [] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
    Console.Write(collection[i] + " ");
    }
}

PrintArray(array);