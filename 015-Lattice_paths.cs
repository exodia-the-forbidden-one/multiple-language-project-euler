using System;
using System.Numerics;

namespace p15
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Total number of paths from (0,0) to (20,20) = (20!20!)/(20!+20!).

        Console.WriteLine(fact(20+20)/(fact(20)*fact(20))); // 137846528820

        }
        public static BigInteger fact(int n)
        {
            BigInteger factorial = new BigInteger(1);

            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}