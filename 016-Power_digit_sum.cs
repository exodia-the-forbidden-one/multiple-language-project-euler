//https://projecteuler.net/problem=16
using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

namespace p16
{
    internal class Program
        {
            public static void Main(string[] args)
            {
                BigInteger bi = new BigInteger();
    
                bi = BigInteger.Pow(2, 1000);
                
                List<BigInteger> blist = new List<BigInteger>();
                
    
                foreach (var n in bi.ToString())
                {
                    blist.Add(int.Parse(n.ToString()));
                }
                
                Console.WriteLine(blist.Aggregate(BigInteger.Add)); //1366
            }
        }
}