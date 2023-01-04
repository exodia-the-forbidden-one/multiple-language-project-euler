//https://projecteuler.net/problem=14

using System;
using System.IO;
using System.Numerics;
using System.Text;

namespace p14
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ulong longestChain = 0;
            int n = 0;
            for (ulong i = 999_999; i > 1; i--)
            {
                if (Collatz(i) > n)
                {
                    longestChain = i;
                    n = Collatz(i);
                }
            }

            Console.WriteLine(longestChain); //837799
        }

        public static int Collatz(ulong number)
        {
            int n = 0;

            while (number >= 1)
            {
                n++;
                if (number == 1)
                {
                    break;
                }

                number = number % 2 == 0 ? number /= 2 : number = (number *= 3) + 1;
            }
            return n;
        }
    }
}