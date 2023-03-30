int SumOfDivisors(int number)
{
    int sumOfDivisors = 0;
    for (int i = 1; i <= number / 2; i++)
    {
        if (number % i == 0)
        {
            sumOfDivisors += i;
        }
    }
    return sumOfDivisors;
}


bool IsAmicable(int number)
{
    if ((number == SumOfDivisors(SumOfDivisors(number))) && (number != SumOfDivisors(number)))
    {
        return true;
    }
    return false;
}

int sumOfAmicable = 0;
for (var i = 1; i < 10000; i++)
{
    if (IsAmicable(i))
    {
        sumOfAmicable += i;
    }
}

Console.WriteLine(sumOfAmicable);