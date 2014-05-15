using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//05. Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
class Program
{
    static void Main()
    {
        uint N = uint.Parse(Console.ReadLine());
        uint K = uint.Parse(Console.ReadLine());

        uint factorialN = 1;
        uint factorialK = 1;
        uint factorialDifferanceNK = 1;
        uint differanceNK = K - N;

        for (uint i = N; i > 0; i--)
        {
            factorialN *= i;
        }
        for (uint j = K; j > 0; j--)
        {
            factorialK *= j;
        }
        for (uint l = K; l > differanceNK; l--)
        {
            factorialDifferanceNK *= l;
        }

        Console.WriteLine("N!*K!/(K-N)! = {0}", (factorialN * factorialK) / factorialDifferanceNK);
    }
}

