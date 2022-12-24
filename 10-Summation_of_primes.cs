using System;
using System.Numerics;

namespace test
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BigInteger bigInt = new BigInteger(2);


            for (int i = 3; i < 2000000; i += 2)
            {
                if (isPrime(i))
                {
                    bigInt += i;
                }
            }

            Console.WriteLine(bigInt); //142913828922

            bool isPrime(int n)
            {
                for (int i = 2;
                     i < Convert.ToInt32(Math.Sqrt(n))+1;
                     i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}