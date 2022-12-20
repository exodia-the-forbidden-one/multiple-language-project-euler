using System;
using System.Linq;

namespace ConsoleApplication1
{
    internal class Program
    {
        static bool IsPalindromic(int number)
        {
            char[] number1 = number.ToString().ToCharArray();
            char[] number2 = number1.Reverse().ToArray();
            return number1.SequenceEqual(number2);
        }

        public static void Main(string[] args)
        {
            int a = 0;

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    a = j * i > a && IsPalindromic(j * i) ? j * i : a = a;
                }
            }
            Console.WriteLine(a);
        }
    }
}