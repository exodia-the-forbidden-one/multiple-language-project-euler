using System;

namespace p12
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(HightlyDivisible(500));
        }

        static int HightlyDivisible(int max)
        {
            int x = 1;
            for (int i = 1;; i += x)
            {
                if (NumOfDivisors(i) > max)
                {
                    return i;
                }
                
                x++;
            }
        }

        static int NumOfDivisors(int number)
        {
            int total = 1;
            for (int i = 1; i <= (number/2); i++)
            {
                if (number % i == 0)
                {
                    total++;
                }
            }

            return total;
        }
    }
}