/* 9. Int, Double, String
   Write a program that, depending on the first line of the input, reads an int, double or string variable.
          If the variable is int or double, the program increases it by one.
          If the variable is a string, the program appends * at the end.
   Print the result at the console. Use switch statement.
   On the first line you will receive the type of input as string in the following form: 
          integer for int, real for double, text for string.
   On the second line you will be given the value of the variable.
   Write a single line on the console - the value transformed according to the rules from the description.
          Print all double variables with exactly 2-digits precision after the floating point.
   The input will always be valid and in the described format. All input numbers will be between -1000 and 1000. */

using System;
using System.Globalization;
using System.Threading;

class IntDoubleString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "integer":
                {
                    int number = int.Parse(Console.ReadLine());                    
                    Console.WriteLine(number + 1);
                    break;
                }
            case "real":
                {
                    double number = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", number + 1);
                    break;
                }
            case "text":
                {
                    Console.WriteLine(Console.ReadLine() + "*");
                    break;
                }
        }

    }
}