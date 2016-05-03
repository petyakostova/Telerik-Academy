/* Problem 3. Compare char arrays - With Strings
   Write a program that compares two char arrays lexicographically (letter by letter).    
        Print < if the first array is lexicographically smaller
        Print > if the second array is lexicographically smaller
        Print = if the arrays are equal                                  */

using System;

class CompareStrings
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        //public int CompareTo(String strB);
        int compare = first.CompareTo(second);

        if (compare == -1)
        {
            // the first is lexicographically smaller (comes earlier)
            Console.WriteLine("<");
        }        
        else if (compare == 0)
        {
            // first and second are equal
            Console.WriteLine("=");
        }
        else if (compare == 1)
        {
            // the second is lexicographically smaller(comes earlier)
            Console.WriteLine(">");
        }

    }
}