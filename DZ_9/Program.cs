// Задача 64. Задайте значения М и Н. НПк выведет все натуральные числа в промежутке от М до Н.

/*  int PrintNumbers(int M, int N)
{
    if (M < N)
    {
        Console.Write(M + " ");
        return PrintNumbers(M + 1, N);
    }
    if (M > N)
    {   
        Console.Write(M + " ");
        return PrintNumbers(M - 1, N);
    }
    Console.Write(N);
    return 0;
    
}
PrintNumbers(1,5); */

//Задача 66. Задайте значения М и Н. НПк найдет сумму натуральных элементов в промежутке от М до Н.

/* int result = 0;
int RecSum(int M, int N)
{
    
    if (M < N)
    {
        result += M;
        //Console.Write(result);
        return RecSum(M + 1, N);
    }
    if (M > N)
    {   
        result += M;
        //Console.Write(result);
        return RecSum(M - 1, N);
    }
    Console.Write(result + N);
    return 0;
    
}
RecSum(4,1);
 */

//Задача 68. НП вычисления ф-ии Аккермана с помощью рекурсии. Даны два положительных числа m и n.
//m = 3, n = 2 -> A(m,n) = 29

int A(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return A(m -1, 1);
    if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
    return 0;
}
Console.Write(A(3,2));