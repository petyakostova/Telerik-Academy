//Problem 16. Print Long Sequence
//Description => Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
//Input => There is no input for this task.
//Output => Output the first 1000 members of the sequence, each on a separate line.
//2
//-3
//4
//-5
//6
//...
    
using System;

class PrintLongSequence
{
    static void Main()
    {
        Console.BufferHeight = 1001;
        for (int i = 2; i < 1002; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i + "  ");
            }
            else
            {
                Console.WriteLine(i * (-1) + "  ");
            }
        }
    }
}