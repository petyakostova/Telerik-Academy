/* Problem 16. Subset K with sum S
   Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
   Find in the array a subset of K elements that have sum S or indicate about its absence. 
   Example:
   Input array                  S       K       Output
   2, 1, 2, 4, 3, 5, 2, 6       14      3       yes     (1+4+9=14) */

using System;
using System.Linq;

class SubsetKWithSumS
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
        int n = array.Length;
        Console.Write("Enter the sum S = ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Enter Subset size K = ");
        int k = int.Parse(Console.ReadLine());

        int PowerSetSize = 1 << n;  // equiavalent to Math.Pow(2, n)

        var PowerSet =                                                       // each subset contains a set of array elements
            from PowerSetIndex in Enumerable.Range(0, PowerSetSize)          // for each new PowerSet Subset 
            select                                                           // Return Elements 
            from ArrayIndex in Enumerable.Range(0, array.Count())     // From the input Array toSearch
            where (PowerSetIndex & (1 << ArrayIndex)) != 0           // If PowerSet Index and ArrayIndex 
            select array[ArrayIndex];                                 // have a matching bit return that Element

        // Find Subsets with Matching Sum 
        PowerSet =
            from SubSet in PowerSet                         // for each existing subset in PowerSet
            where SubSet.Sum() == s && SubSet.Count() == k
            select SubSet;                                  // Return the matching subsets

        // output
        if (PowerSet.Count() > 0)       //if PowerSet has at least 1 matching subset
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

        // For each subset, separated by NewLine join it's sub elements in a string
        //Console.Write(string.Join("\n", PowerSet.Select(subset => string.Join(" ", subset))));
        //Console.WriteLine();
    }
}