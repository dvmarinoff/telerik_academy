using System;
using System.Text;
using System.Numerics;
//09. & 10. Write a program to calculate the Nth Catalan number by given N.
class Program
{
    static void Main()
    {
        BigInteger fN = 1;
        BigInteger fN2 = 1;
        BigInteger fN1 = 1;
        BigInteger numberCatalan = 1;

        int N = int.Parse(Console.ReadLine());

        for (int i = N; i > 0; i--)
        {
            fN *= i;
        }
        for (int j = N * 2; j > 0; j--)
        {
            fN2 *= j;
        }
        fN1 = fN * (N + 1);

        numberCatalan = fN2 / (fN1 * fN);

        Console.WriteLine(numberCatalan);


       
    }
}

