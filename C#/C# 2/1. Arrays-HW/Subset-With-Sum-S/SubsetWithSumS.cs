/* Problem 16. Subset with sum S
   We are given an array of integers and a number S.
   Write a program to find if there exists a subset of the elements of the array that has a sum S. 
   Sample tests
   input array              	S 	    result
   2, 1, 2, 4, 3, 5, 2, 6 	    14 	    yes                             */

/* Algorithm: Generate all possible subsets of the numbers by a for-loop from 0 to (Math.Pow(2, n)-1). 
If we have a number p, take its binary representation (which consists of exactly N bits) 
and sum the numbers that correspond to 1 in the binary representation of p (with a nested loop from 0 to N-1). 
Thus all possible sums will be generated and if some of them is S, it can be printed. 
This algorithm is slow (needs exponential time and cannot run for 100 or 1000 elements). 
It also does not allow using the same array element twice in the sum.*/

using System;

class SubsetWithSumS
{
    static void Main()
    {
        // Input array
        Console.WriteLine("Enter an array of integer elements on a single line, separated by commas:");
        string input = Console.ReadLine();

        // Split the elements into an array
        string[] inputElements = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Fill an integer array from string array
        int[] array = new int[inputElements.Length];
        for (int i = 0; i < inputElements.Length; i++)
        {
            array[i] = int.Parse(inputElements[i]);
        }

        // Input S
        Console.Write("Enter the sum S = ");
        int s = int.Parse(Console.ReadLine());

        long curSum = 0;
        int count = 0;

        for (int i = 1; i <= (int)Math.Pow(2, array.Length) - 1; i++)
        {
            curSum = 0;
            string template = Convert.ToString(i, 2).PadLeft(array.Length, '0');

            for (int j = 0; j < template.Length; j++)
            {
                if (template[j].ToString() == "1")
                {
                    curSum += array[j];
                }
            }

            if (curSum == s)
            {
                count++;
            }
        }

        // Output
        if (count > 0)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

    }
}