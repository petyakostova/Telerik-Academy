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

using System;

class CompareCharArrays
{
    static void Main()
    {
        string firstChars = Console.ReadLine();
        char[] firstArray = firstChars.ToCharArray();   // convert string to char array
        int firstLength = firstArray.Length;            // gets length of the first array

        string secondChars = Console.ReadLine();
        char[] secondArray = secondChars.ToCharArray();
        int secondLength = secondArray.Length;

        bool equal = true;

        if (firstLength < secondLength)
        {
            equal = false;
            // the first array is lexicographically smaller (comes earlier)
            Console.WriteLine("<");
        }
        else if (firstLength > secondLength)
        {
            equal = false;
            // the second array is lexicographically smaller (comes earlier) 
            Console.WriteLine(">");
        }
        else  // firstLength == secondLength
        {
            for (int i = 0; i < firstLength; i++)
            {
                if (firstArray[i] < secondArray[i])
                {
                    // the first array is lexicographically smaller (comes earlier)
                    Console.WriteLine("<");
                    equal = false;
                    break;
                }
                else if (firstArray[i] > secondArray[i])
                {
                    // the second array is lexicographically smaller(comes earlier)
                    Console.WriteLine(">");
                    equal = false;
                    break;
                }
            }
        }

        if (equal)
        {
            // the arrays are equal
            Console.WriteLine("=");
        }

    }
}