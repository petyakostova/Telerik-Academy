/* Problem 16. Subset with sum S
   We are given an array of integers and a number S.
   Write a program to find if there exists a subset of the elements of the array that has a sum S. 
   Sample tests
   input array              	S 	    result
   2, 1, 2, 4, 3, 5, 2, 6 	    14 	    yes                             */

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
        int[] arrayNums = new int[inputElements.Length];
        for (int i = 0; i < inputElements.Length; i++)
        {
            arrayNums[i] = int.Parse(inputElements[i]);
        }

        // Input S
        Console.Write("Enter the sum S = ");
        int s = int.Parse(Console.ReadLine());

        long curSum = 0;
        int count = 0;

        for (int i = 1; i <= (int)Math.Pow(2, arrayNums.Length) - 1; i++)
        {
            curSum = 0;
            string template = Convert.ToString(i, 2).PadLeft(arrayNums.Length, '0');

            for (int j = 0; j < template.Length; j++)
            {
                if (template[j].ToString() == "1")
                {
                    curSum += arrayNums[j];
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