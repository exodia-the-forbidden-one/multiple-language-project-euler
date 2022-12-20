using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 20; true; i += 20)
            {
                bool x = true;
                for (int j = 1; j <= 20; j++)
                {
                    if (!(i % j == 0))
                    {
                        x = false;
                    }
                }

                if (x)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}