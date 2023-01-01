using System;

namespace test
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int a = 1; a < 1000; a++)
            {
                for (int b = 1; b < 1000 - a; b++)
                {
                    int c = 1000 - a - b;
                    if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                    {
                        Console.WriteLine("{0}", a * b * c); //31875000
                    }
                }
            }
        }
    }
}