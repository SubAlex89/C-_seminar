// НПк принимает на вход число А и выдает сумму чисел от 1 до А.

/* int Func(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
    
}
Console.WriteLine(" Введите число: "); 
int A = int.Parse(Console.ReadLine()); 
Console.WriteLine(Func(A));
 */
//Console.WriteLine(Func(7));
//Console.WriteLine(Func(4));
//Console.WriteLine(Func(8));


// НПк принимает на вход число и выдает количество цифр в числе.
/* int Count(int input)
{
    

    if (input < 0) input = -input;
    int i = 0;
    while (input > 0)
    {
        input = input / 10;
        i++;
    }
    
    return i;
}
Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Count(num)); */
//Console.WriteLine("Количество цифр в числе - " + Count(1));
//Console.WriteLine("Количество цифр в числе - " + Count(23));
//Console.WriteLine("Количество цифр в числе - " + Count(12345));
//Console.WriteLine("Количество цифр в числе - " + Count(12345678));


// НПК принмает на вход число N и выдает произведение чисел  от 1 до N
/* int Factor(int num)
{
    if (num < 0) num = -num;
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result = result * i;
    }
        return result;
}

Console.WriteLine("Введите число ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Факториал числа = " + Factor(N)); */

//НПк выводит массив из 8 элементов заполненный нулями и единицами в случайном порядке.

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,2);
}

void PrintArray (int [] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
    Console.Write(collection[i] + " ");
    }
}

PrintArray(array);