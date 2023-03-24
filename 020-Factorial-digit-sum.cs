using System.Numerics;

var strArr = Factorial(100).ToString();
int sum = 0;
foreach (var x  in strArr)
{
    sum += Convert.ToInt16(x.ToString());
}
Console.WriteLine(sum);


BigInteger Factorial(int number)
{
    BigInteger bigint = new BigInteger(1);
    for (int i = number; i > 1; i--)
    {
        bigint *= i;
    }
    
    return bigint;
}