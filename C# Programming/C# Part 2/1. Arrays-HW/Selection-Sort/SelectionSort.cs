/*  Problem 7. Selection sort
    Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
    Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
    find the smallest from the rest, move it at the second position, etc.
 */

using System;

class SelectionSort
{
    static void Main()
    {
        Console.WriteLine("Enter a number for N:");
        int n = int.Parse(Console.ReadLine());

        int[] arrayNums = new int[n];
        Console.WriteLine("Enter {0} numbers to array:", n);
        for (int i = 0; i < n; i++)
        {
            arrayNums[i] = int.Parse(Console.ReadLine());
        }

        // Classical implementation of Selection Sort Algorithm
        for (int i = 0; i < arrayNums.Length - 1; i++)
        {
            // find the min element in the unsorted a[i..n-1]

            // assume the min is the first element           
            int indexMin = i;

            // test against elements after i to find the smallest
            int j;
            for (j = i + 1; j < arrayNums.Length; j++)
            {
                // if this element is less, then it is the new minimum
                if (arrayNums[j] < arrayNums[indexMin])
                {
                    // found new minimum; remember its index
                    indexMin = j;
                }
            }
            // swaping
            if (indexMin != j)
            {
                int swap = arrayNums[i];
                arrayNums[i] = arrayNums[indexMin];
                arrayNums[indexMin] = swap;
            }
        }

        Console.WriteLine("After sorting using Selection Sort Algorithm: ");
        Console.WriteLine(string.Join(" ", arrayNums) + "\n");

    }
}