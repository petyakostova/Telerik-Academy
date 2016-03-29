/* Problem 5. Third Digit is 7?
Write a program that reads an integer N from the console and prints true if the third digit of the N is 7, or "false THIRD_DIGIT", where you should print the third digits of N. The counting is done from right to left, meaning 123456's third digit is 4. */

using System;

class WhetherThirdDigitIs7
{
    static void Main()
    {
        int intNumber = int.Parse(Console.ReadLine());      

        if (intNumber < 700)
        {
            Console.WriteLine("false 0");
        }
        else
        {
            int dividedBy100 = intNumber / 100;
            int remainderBy10 = dividedBy100 % 10;
            Console.WriteLine((remainderBy10 == 7) 
                ? "true" 
                : "false {0}", remainderBy10);
        }
    }
}