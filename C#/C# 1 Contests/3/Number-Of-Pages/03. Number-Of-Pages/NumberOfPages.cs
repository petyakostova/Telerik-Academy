using System;

class NumberOfPages
{
    static void Main()
    {
        long digits = long.Parse(Console.ReadLine());

        long counter = 1;
        long pageCurrent = 1;
        long digitPage;

        while (true)
        {
            if (counter == digits)
            {
                break;
            }
            else if (counter > digits)
            {
                pageCurrent--;
                break;
            }
            else
            {
                if (pageCurrent < 10)
                {
                    counter++;
                    pageCurrent++;
                }
                else
                {
                    digitPage = pageCurrent;
                    while (digitPage > 0)
                    {
                        digitPage /= 10;
                        counter++;
                    }
                    pageCurrent++;
                }
            }
        }

        if (pageCurrent < 10)
        {
            Console.WriteLine(pageCurrent);
        }
        else
        {
            Console.WriteLine(pageCurrent--);
        }

    }
}