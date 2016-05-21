using System;
using System.Linq; // needed for Select()

class FastParseInputInSingleLine
{
    static void Main()
    {
        // 0 1 2 3 4 5 - input => put the numbers direct to array, fast parsing

        int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //we need using System.Linq for Select()
            .Select(int.Parse)  // for each string you get => parse                             
            .ToArray(); // make it to array

        //other way
        int[] otherNumbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

    }
}