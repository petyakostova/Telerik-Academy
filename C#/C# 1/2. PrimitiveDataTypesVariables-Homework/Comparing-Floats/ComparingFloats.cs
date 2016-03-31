/*Problem 13. Comparing Floats
Write a program that safely compares two floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
Input
    On the first line you will receive the first floating-point number
    On the second line you will receive the second floating-point number
Hint: Use double.Parse(Console.ReadLine()) to read input
Output
    Print true if the numbers are equal or false if they are not

Sample tests
Input      	  Equal (with precision eps=0.000001)     Explanation
5.3 	        	  false 	                      The difference of 0.71 is too big (> eps)
6.01                  
5.00000001 	     	  true 	                          The difference 0.00000002 < eps
5.00000003            
5.00000005 	     	  true 	                          The difference 0.00000004 < eps
5.00000001            
-0.0000007 	     	  true 	                          The difference 0.00000077 < eps
0.00000007            
-4.999999 	     	  false 	                      Border case. The difference 0.000001 == eps. 
-4.999998                                                   We consider the numbers are different.  
4.999999 	     	  false 	                      Border case. The difference 0.000001 == eps. 
4.999998                                                    We consider the numbers are different.
*/

using System;
using System.Threading;
using System.Globalization; 

class ComparingFloats
{
    static void Main()
    {
        // fix the decimal point to "."
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double eps = 0.000001;
        double difference = Math.Abs(a - b);
        
        // first way
        if (difference < eps)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }

        //// other way 
        //bool equal = difference < eps;
        //Console.WriteLine(equal);
    }
}