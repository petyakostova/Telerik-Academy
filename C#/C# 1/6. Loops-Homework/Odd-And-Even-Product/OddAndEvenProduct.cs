/* 10. Odd and Even Product
   You are given N integers (given in a single line, separated by a space).
   Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
   Elements are counted from 1 to N, so the first element is odd, the second is even, etc.
   Input: 
        On the first line you will receive the number N
        On the second line you will receive N numbers separated by a whitespace
   Output
        If the two products are equal, output a string in the format "yes PRODUCT_VALUE", 
        otherwise write on the console "no ODD_PRODUCT_VALUE EVEN_PRODUCT_VALUE"
   Constraints
        N will always be a valid integer number in the range [4, 50]
        All input numbers from the second line will also be valid integers */

using System;
using System.Numerics; // must be added in References; needed for BigInteger

class OddAndEvenProduct
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] splitNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        BigInteger oddProduct = 1;
        BigInteger evenProduct = 1;

        for (int i = 0; i < n; i += 2)    // i < splitNumbers.Length
        {
            oddProduct *= int.Parse(splitNumbers[i]);
        }

        for (int i = 1; i < n; i += 2)    // i < splitNumbers.Length
        {
            evenProduct *= int.Parse(splitNumbers[i]);
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
        }

    }
}