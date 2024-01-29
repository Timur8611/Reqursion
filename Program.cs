// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, 
// не использовать циклы.


Random random = new Random();
int m = random.Next(1, 21);
int n = random.Next(1, 21);
System.Console.WriteLine("m=" + m);
System.Console.WriteLine("n=" + n);
PrintNaturalFromMtoN (m,n);
void PrintNaturalFromMtoN(int M, int N)
{
    if (M == N)
    {
        System.Console.WriteLine(M);
    }
    if (M > N)
    {
        PrintNaturalFromMtoN(M, N + 1);
    }

    if (N > M)
    {
        System.Console.WriteLine(M + "\t");

        PrintNaturalFromMtoN(M + 1, N);
    }
}