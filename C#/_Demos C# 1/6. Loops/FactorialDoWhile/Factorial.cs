using System;

using System.Numerics;
// don't forget to add a reference to System.Numerics.dll

class Factorial
{
    static void Main()
    {
        Console.Write("n = ");
        string consoleInput = Console.ReadLine();
        int n = Convert.ToInt32(consoleInput);

        Console.Write("{0}! = ", n);

        //decimal factorial = 1;
        BigInteger factorial = 1;

        do
        {
            if (n > 0)
            {
                factorial *= n;
            }
            n--;
        }
        while (n > 0);

        Console.WriteLine(factorial);
    }
}