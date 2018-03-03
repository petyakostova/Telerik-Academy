using System;

class NumberOfPages
{
    static void Main()
    {
        int digits = int.Parse(Console.ReadLine());

        int counter = 1;
        int currentPage = 1;
        int digitPage;

        while (true)
        {
            if (counter == digits)
            {
                break;
            }
            else if (counter > digits)
            {
                currentPage--;
                break;
            }
            else
            {
                if (currentPage < 10)
                {
                    counter++;
                    currentPage++;
                }
                else
                {
                    digitPage = currentPage;
                    while (digitPage > 0)
                    {
                        digitPage /= 10;
                        counter++;
                    }
                    currentPage++;
                }
            }
        }

        if (currentPage < 10)
        {
            Console.WriteLine(currentPage);
        }
        else
        {
            Console.WriteLine(currentPage--);
        }

    }
}