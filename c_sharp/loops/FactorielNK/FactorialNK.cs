using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//04. Write a program that calculates N!/K! for given N and K (1<K<N).
class Program
{
    static void Main()
    {
        uint N = uint.Parse(Console.ReadLine());
        uint K = uint.Parse(Console.ReadLine());

        uint factorialN = 1;
        uint factorialK = 1;

        for (uint i = N; i > 0; i--)
        {
            factorialN *= i;
        }
        //Console.WriteLine(factorialN);       //Test 
        for (uint j = K; j > 0; j--)
        {
            factorialK *= j;
        }
        Console.WriteLine("N!/K! = {0}",factorialN/factorialK);
    }
}

