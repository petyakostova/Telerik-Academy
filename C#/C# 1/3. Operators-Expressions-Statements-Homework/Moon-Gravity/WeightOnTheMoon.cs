/*Problem 2. Moon Gravity
  The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight W(as a floating-point number) on the Earth. The weight W should be read from the console. */

using System;
using System.Threading;                                                     
using System.Globalization;

class WeightOnTheMoon
{
    static void Main()
    {
        // change the culture of the program in American standard 
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US"); 
            
        double weightOnTheEarth = double.Parse(Console.ReadLine()); 

        double weightOnTheMoon = weightOnTheEarth * 0.17;
        
        Console.WriteLine(weightOnTheMoon.ToString("F3"));
        //Console.WriteLine(weightOnTheMoon.ToString("N3"));
        //Console.WriteLine("{0:F3}", weightOnTheMoon);
    }
}