using System;

class Rounding
{
    static void Main()
    {
        double num = double.Parse(Console.ReadLine());
        Console.WriteLine(num);

        //Round a double-precision floating-point value to the nearest integral value.
        Console.WriteLine("Math.Round(double num) => {0}", Math.Round(num));

        //Return the largest integer less than or equal to the specified double-precision floating-point number
        Console.WriteLine("Math.Floor(double num) => {0}", Math.Floor(num));

        //Return the smallest integral value that is greater than or equal to the specified double-precision floating-point number.
        Console.WriteLine("Math.Ceiling(double num) => {0}", Math.Ceiling(num));
    }
}