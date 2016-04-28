using System;

class NumberOfDigits
{
    static void Main()
    {
        int numberOfPages = int.Parse(Console.ReadLine());

        int digitsInPageNumbers = 0;

        for (int i = 1; i <= numberOfPages; i++)
        {
            digitsInPageNumbers += i.ToString().Length;
        }

        Console.WriteLine(digitsInPageNumbers);
    }
}