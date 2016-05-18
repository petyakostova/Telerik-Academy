using System;

class VariableNumberOfParameters
{
    static long CalcSum(params int[] elements)
    {
        long sum = 0;

        foreach (int element in elements)
        {
            sum += element;
        }

        return sum;
    }

    static void Main()
    {
        Console.WriteLine(CalcSum(2, 5)); //7

        Console.WriteLine(CalcSum(4, 0, -2, 12)); //14

        Console.WriteLine(CalcSum()); //0
    }     
        
}