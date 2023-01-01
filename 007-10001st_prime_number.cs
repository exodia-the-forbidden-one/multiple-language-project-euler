internal class Program
{
    public static void Main(string[] args)
    {
        int result = 0;
        int n = 0;
        for (int x = 2;n<10001;x++)
        {
            if (IsPrime(x))
            {
                
                n++;
                result = x;
            }
        }
        Console.WriteLine(result);


        bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
