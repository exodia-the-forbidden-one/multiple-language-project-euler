//https://projecteuler.net/problem=17
using System;
using System.Collections.Generic;

namespace p17
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string result = "";
            for (int i = 1; i <= 1000; i++)
            {
                result += numberToWord(i);
            }
            Console.WriteLine(result.Length); // 21124

        }

        public static string numberToWord(int number)
        {

            switch (number.ToString().Length)
            {
                case 1:
                    return numberToWordDict[number].FirstDigit;
                case 2 when number % 10 == 0:
                    return numberToWordDict[(int)number / 10].SecondDigit;
                case 2 when number < 20:
                    return numberToWordDict[number % 10].TenSeries;
                case 2:
                    return numberToWordDict[(int)number / 10].SecondDigit + numberToWordDict[number % 10].FirstDigit;
                case 3 when number % 100 == 0:
                    return numberToWordDict[(int)number / 100].FirstDigit + "Hundred";
                case 3 when number % 10 == 0:
                    return numberToWordDict[(int)number / 100].FirstDigit + "HundredAnd" + numberToWordDict[(int)(number % 100) / 10].SecondDigit;
                case 3 when number % 100 < 20 && number % 100 > 10:
                    return numberToWordDict[(int)number / 100].FirstDigit + "HundredAnd" + numberToWordDict[(int)(number % 10)].TenSeries;
                case 3:
                    return numberToWordDict[(int)number / 100].FirstDigit + "HundredAnd" + numberToWordDict[(int)(number % 100) / 10].SecondDigit + numberToWordDict[number % 10].FirstDigit;
                default:
                    return "OneThousand";
            }

        }

        static Dictionary<int, Position> numberToWordDict = new Dictionary<int, Position>(){
            {0,new Position{FirstDigit="Zero",SecondDigit=string.Empty,TenSeries="Ten"}},
            {1,new Position{FirstDigit="One",SecondDigit="Ten",TenSeries="Eleven"}},
            {2,new Position{FirstDigit="Two",SecondDigit="Twenty",TenSeries="Twelve"}},
            {3,new Position{FirstDigit="Three",SecondDigit="Thirty",TenSeries="Thirteen"}},
            {4,new Position{FirstDigit="Four",SecondDigit="Forty",TenSeries="Fourteen"}},
            {5,new Position{FirstDigit="Five",SecondDigit="Fifty",TenSeries="Fifteen"}},
            {6,new Position{FirstDigit="Six",SecondDigit="Sixty",TenSeries="Sixteen"}},
            {7,new Position{FirstDigit="Seven",SecondDigit="Seventy",TenSeries="Seventeen"}},
            {8,new Position{FirstDigit="Eight",SecondDigit="Eighty",TenSeries="Eighteen"}},
            {9,new Position{FirstDigit="Nine",SecondDigit="Ninety",TenSeries="Nineteen"}}
        };

    }

    class Position
    {
        public string FirstDigit { get; set; }
        public string SecondDigit { get; set; }
        public string TenSeries { get; set; }
    }

}