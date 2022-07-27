//Задача 70. НПк на вход принимает два числа и выдает первые N чисел 
//для которых каждое следующее равно сумме двух предыдущих.

/* int RecFib (int a, int b, int count)
{
    if (count < 1) return 0;
    if (count == 1) return a;
    if (count == 2) return b;
    return RecFib(a, b, count - 1) + RecFib(a, b, count - 2);

}

int N = 4;
for (int i = 1; i <= N; i++)
{
    Console.WriteLine(RecFib(6,10,i));
}

 */
 //Задача 71. В некотором машинном алфавите имеются четыре буквы "а, и, с, в".
 //Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.



/* for (int i = 0; i < alphabet.Length; i++)
{
    Console.WriteLine();
    for (int j = 0; j < alphabet.Length; j++)
    {
        Console.Write(count + "  " + alphabet[i] + alphabet[j] + "  ");
        count++;
    }
} */

string[] RecWords (string alpha, int length)
{
    string[] result;
    if (length <= 0)
    {
        result = new string[1];
        result[0] = String.Empty;
        return result;
    }
    
    string[] result_Old = RecWords(alpha, length - 1);

    result = new string[result_Old.Length * alpha.Length];
    int count = 0;
    for (int i = 0; i < result_Old.Length; i++)
    {
        for (int j = 0; j < alpha.Length; j++)
        {
            result[count] = result_Old[i] + alpha[j];
            count++;
        }
    }
    return result;

}

int n = 4;
string alphabet = "аисв";
string[] word;
word = RecWords(alphabet, n);

for (int i = 0; i < word.Length; i++)
{
    Console.Write(i+1 + "_" +word[i] + "  " );
}
