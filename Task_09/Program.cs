//Рекурсия

/* int rec(int n)
{
    if (n == 0)
    {
        Console.WriteLine("Это конец рекурсии");
        return 0;
    }

    int result = 0;
    result = n + n + 8;
    Console.WriteLine("Это рекурсия");
    return result + rec(n -1);
}


Console.WriteLine("Результат рекурсии: " + rec(10)); */

// Задача 63. задайтейте значение N. НПК выыведет все натуральные числа в промежутке от 1 до N.



/* void PrintNumbers(int n)
{
    if (n == 0)
    {
        return;
    }
    PrintNumbers(n - 1);
    Console.Write(n + " ");   
}

Console.Write("Ввежите число N ");
int N = int.Parse(Console.ReadLine());
PrintNumbers(N); */

//Задача 65. Задайте значения M и N. НПК выведет все натуральные числа в промежутке от M до N.

/* void PrintNumbers(int M, int N)
{
    if (M > N)
    {   
        return;
    }

    Console.Write(M + " ");
    PrintNumbers(M + 1, N);


}
PrintNumbers(1,5);
 */

 //Задача 67 НПК будет принимать на вход число и возвращать сумму его цифр.

/* int SumRec (int n)
{
    if (n == 0)
    {
        return 0;
    }
    return n % 10 + SumRec(n / 10);
    
}

Console.Write(SumRec(123456789));
 */

 //Задача 69 НПК принимает на вход два числа А и В, и возводит число А в целую степень В с помошью рекурсии.

 double RecPow (int A, int B)
 {
    if (B == 0) 
    {
        return 1;
    }
    if (B < 0)
    {
        return (1.0 / A) * RecPow(A, B + 1);
    }
    return A * RecPow(A, B - 1);
 }
 Console.Write(RecPow(2, 4));