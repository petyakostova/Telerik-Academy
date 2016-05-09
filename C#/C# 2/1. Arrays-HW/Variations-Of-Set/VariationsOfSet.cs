/* Porblem 20. Variations of set
   Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
   Sample tests:
    N 	    K 	    result
    3 	    2 	    {1, 1}
                    {1, 2}
                    {1, 3}
                    {2, 1}
                    {2, 2}
                    {2, 3}
                    {3, 1}
                    {3, 2}
                    {3, 3}          */

using System;

class VariationsOfSet
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int[] vars = new int[k];

        Variations(n, k, vars, 0);
    }

    static void Variations(int nRange, int kCount, int[] arrInput, int position)
    {
        if (position == kCount)
        {
            Console.Write(arrInput[0]);

            for (int i = 1; i < kCount; i++)
            {
                Console.Write(", " + arrInput[i]);
            }

            Console.WriteLine();
        }
        else
        {
            for (int i = 1; i <= nRange; i++)
            {
                arrInput[position] = i;
                Variations(nRange, kCount, arrInput, position + 1);
            }
        }
    }

}