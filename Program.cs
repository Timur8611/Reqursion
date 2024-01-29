// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, 
// не использовать циклы.


// Random random = new Random();
// int m = random.Next(1, 21);
// int n = random.Next(1, 21);
// System.Console.WriteLine("m=" + m);
// System.Console.WriteLine("n=" + n);
// PrintNaturalFromMtoN (m,n);
// void PrintNaturalFromMtoN(int M, int N)
// {
//     if (M == N)
//     {
//         System.Console.WriteLine(M);
//     }
//     if (M > N)
//     {
//         PrintNaturalFromMtoN(M, N + 1);
//     }

//     if (N > M)
//     {
//         System.Console.WriteLine(M + "\t");

//         PrintNaturalFromMtoN(M + 1, N);
//     }
// }


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Akkermann (int m,int n)

{   int result = 0;

    if(m == 0)
{
    result = n+1;
}

 if(m>0 && n==0)
 {
    result = Akkermann(m-1,1);
 }
  if(m>0 && n>0)
  {
    result = Akkermann(m-1,Akkermann(m,n-1));
  } 

  return result;
}
Random Chukcha = new Random();
int m = Chukcha.Next(1,3);
int n = Chukcha.Next(1,4);
System.Console.WriteLine(m+ " "+ n);
int resultAkkermannchik = Akkermann(m,n);
System.Console.WriteLine(resultAkkermannchik);
