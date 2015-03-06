/* Problem 12.* Zero Subset
   We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
   Assume that repeating the same subset several times is not a problem.
Examples:
numbers 	    result
3 -2 1 1 8 	    -2 + 1 + 1 = 0	
3 1 -7 35 22 	no zero subset	
1 3 -4 -2 -1 	1 + -1 = 0
	            1 + 3 + -4 = 0
	            3 + -2 + -1 = 0	
1 1 1 -1 -1 	1 + -1 = 0
	            1 + 1 + -1 + -1 = 0	
0 0 0 0 0 	    0 + 0 + 0 + 0 + 0 = 0
Hint: you may check for zero each of the 31 subsets with 31 if statements.
*/

using System;

class ZeroSubset
{
    static void Main()
    {
        int a, b, c, d, e;
        Console.Write("Enter an integer number a = ");
        while (!int.TryParse(Console.ReadLine(), out a))                    // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number!");
            Console.WriteLine("Enter a correct integer number a= ");
        }
        Console.Write("Enter an integer number b = ");
        while (!int.TryParse(Console.ReadLine(), out b))                    // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number!");
            Console.WriteLine("Enter a correct integer number b= ");
        }
        Console.Write("Enter an integer number c = ");
        while (!int.TryParse(Console.ReadLine(), out c))                    // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number!");
            Console.WriteLine("Enter a correct integer number c= ");
        } Console.Write("Enter an integer number d = ");
        while (!int.TryParse(Console.ReadLine(), out d))                    // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number!");
            Console.WriteLine("Enter a correct integer number d= ");
        } Console.Write("Enter an integer number e = ");
        while (!int.TryParse(Console.ReadLine(), out e))                    // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number!");
            Console.WriteLine("Enter a correct integer number e= ");
        }

        int count = 0;

        //all are 0
        if (a == 0 && b == 0 && c == 0 && d == 0 && e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
            count++;
        }
        else
        {
            // sum from 2 numbers
            if (a + b == 0) { Console.WriteLine("{0} + {1} = 0", a, b); count++; }
            if (a + c == 0) { Console.WriteLine("{0} + {1} = 0", a, c); count++; }
            if (a + d == 0) { Console.WriteLine("{0} + {1} = 0", a, d); count++; }
            if (a + e == 0) { Console.WriteLine("{0} + {1} = 0", a, e); count++; }
            if (b + c == 0) { Console.WriteLine("{0} + {1} = 0", b, c); count++; }
            if (b + d == 0) { Console.WriteLine("{0} + {1} = 0", b, d); count++; }
            if (b + e == 0) { Console.WriteLine("{0} + {1} = 0", b, e); count++; }
            if (c + d == 0) { Console.WriteLine("{0} + {1} = 0", c, d); count++; }
            if (c + e == 0) { Console.WriteLine("{0} + {1} = 0", c, e); count++; }
            if (d + e == 0) { Console.WriteLine("{0} + {1} = 0", d, e); count++; }

            // sum from 3 numbers
            if (a + b + c == 0) { Console.WriteLine("{0} + {1} + {2} = 0", a, b, c); count++; }
            if (a + b + d == 0) { Console.WriteLine("{0} + {1} + {2} = 0", a, b, d); count++; }
            if (a + b + e == 0) { Console.WriteLine("{0} + {1} + {2} = 0", a, b, e); count++; }
            if (a + c + d == 0) { Console.WriteLine("{0} + {1} + {2} = 0", a, c, d); count++; }
            if (a + c + e == 0) { Console.WriteLine("{0} + {1} + {2} = 0", a, c, e); count++; }
            if (a + d + e == 0) { Console.WriteLine("{0} + {1} + {2} = 0", a, d, e); count++; }
            if (b + c + d == 0) { Console.WriteLine("{0} + {1} + {2} = 0", b, c, d); count++; }
            if (b + c + e == 0) { Console.WriteLine("{0} + {1} + {2} = 0", b, c, e); count++; }
            if (b + d + e == 0) { Console.WriteLine("{0} + {1} + {2} = 0", b, d, e); count++; }
            if (c + d + e == 0) { Console.WriteLine("{0} + {1} + {2} = 0", c, d, e); count++; }

            // sum from 4 numbers
            if (a + b + c + d == 0) { Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d); count++; }
            if (a + b + c + e == 0) { Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e); count++; }
            if (a + b + d + e == 0) { Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e); count++; }
            if (a + c + d + e == 0) { Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, d, e); count++; }
            if (b + c + d + e == 0) { Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e); count++; }

            // sum from 5 numbers
            if (a + b + c + d + e == 0) { Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e); count++; }

            if (count == 0) Console.WriteLine("no zero subset");
        }
    }
}