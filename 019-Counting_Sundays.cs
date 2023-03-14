int nDay = 1; // day counter etc. 1 = Monday, 7 = Sunday
int n = 0;

for (int year = 1901; year < 2001; year++)
{
    for (int month = 1; month <= 12; month++)
    {
        int monthLenght = 0;
        switch (month)
        {
            case 4:
            case 6:
            case 9:
                monthLenght = 30;
                break;
            case 2:
                if (year % 4 != 0)
                    monthLenght = 28;

                else
                {
                    if (year % 100 == 0)
                    {
                        if (year % 400 != 0)
                            monthLenght = 28;
                    }
                    else
                        monthLenght = 29;
                }
                break;
            default:
                monthLenght = 31;
                break;
        }
        for (int day = 1; day <= monthLenght; day++)
        {
            if (day == 1 && nDay == 7)
            {
                n++;
                Console.WriteLine(year + " " + month + " " + day + "\n" + nDay);
            }
            if (nDay == 7)
                nDay = 1;

            else
                nDay++;
        }
    }
}

Console.WriteLine(n); //171