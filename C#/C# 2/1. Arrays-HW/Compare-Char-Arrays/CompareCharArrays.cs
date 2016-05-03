/* Problem 3. Compare char arrays
   Write a program that compares two char arrays lexicographically (letter by letter). 
        Print < if the first array is lexicographically smaller
        Print > if the second array is lexicographically smaller
        Print = if the arrays are equal                                  */
/* Notes: In lexicographic order the elements are compared one by one starting from the very left. 
   If the elements are not the same, the array, whose element is smaller (comes earlier in the alphabet), comes first. 
   If the elements are equal, the next character is compared. 
   If the end of one of the arrays is reached, without finding different elements, the shorter array is the smaller 
   (comes earlier lexicographically). 
   If all elements are equal, the arrays are equal.
 */

// 80/100 in bgcoder
using System;

class CompareCharArrays
{
    static void Main()
    {
        string firstChars = Console.ReadLine();
        char[] firstArray = firstChars.ToCharArray();   // convert string to char array
        int firstArrayLength = firstArray.Length;       // gets length of the first array

        string secondChars = Console.ReadLine();
        char[] secondArray = secondChars.ToCharArray();
        int secondArrayLength = secondArray.Length;

        int minLength = Math.Min(secondArrayLength, firstArrayLength); // gets min length of the two arrays

        bool equalChars = true;

        for (int i = 0; i < minLength; i++)
        {
            if (firstArray[i] < secondArray[i])
            {
                // the first array is lexicographically smaller (comes earlier)
                Console.WriteLine("<");
                equalChars = false;
                break;
            }
            else if (firstArray[i] > secondArray[i])
            {
                // the second array is lexicographically smaller(comes earlier)
                Console.WriteLine(">");
                equalChars = false;
                break;
            }
        }

        if (equalChars)     // if no differences are found
        {
            if (firstArrayLength < secondArrayLength)
            {
                // the first array is lexicographically smaller (comes earlier)
                Console.WriteLine("<");
            }
            else if (firstArrayLength > secondArrayLength)
            {
                // the second array is lexicographically smaller (comes earlier) 
                Console.WriteLine(">");
            }
            else
            {
                // the arrays are equal
                Console.WriteLine("=");
            }
        }

    }
}