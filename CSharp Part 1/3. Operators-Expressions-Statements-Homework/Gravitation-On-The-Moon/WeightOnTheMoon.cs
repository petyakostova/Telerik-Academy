/*Problem 2. Gravitation on the Moon
The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
Examples:
weight 	weight on the Moon
86 	    14.62
74.6    12.682
53.7    9.129                    */

using System;
using System.Threading;                                                     // line 11 and 12 are necessary for the line 18
using System.Globalization;

class WeightOnTheMoon
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");     /* changes the culture of the program in American standard 
                                                                               so the decimal point character is . */
        Console.WriteLine("Insert the weight of a man on the Earth \n (for real value please use the decimal point character '.'): ");
        double weightOnTheEarth = double.Parse(Console.ReadLine().Replace(",", "."));  /* parsing and replacing the character ',' with '.'
                                                                                        * for ensuring the correct result 
                                                                                        * even with introduced ","-format */
        double weightOnTheMoon = weightOnTheEarth * 0.17;
        Console.WriteLine("The weight of the man on the moon will be: {0} \n", weightOnTheMoon);
    }
}