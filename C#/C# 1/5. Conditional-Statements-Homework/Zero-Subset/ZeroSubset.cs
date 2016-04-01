/* Problem 12.* Zero Subset
   We are given 5 integer numbers in a single line, separated by a space. 
   Write a program that finds all subsets of these numbers whose sum is 0.
   Assume that repeating the same subset several times is not a problem.
   Hint: you may check for zero each of the 31 subsets with 31 if statements. */

using System;

class ZeroSubset
{
    static void Main()
    {
        Console.WriteLine("Enter 5 integer numbers in a single line, separated by a space: ");
        string line = Console.ReadLine();
        // define array of characters-separators ' '    [can be also { ' ', ',', '.' } - for space, comma and dot]
        char[] separators = new char[] { ' ' };
        /* define array of strings and using the built-in functionality of the method Split(…) from the class String, 
         * split the contents of a given Input (which is String) by array of characters–separators, 
           which are passed as an argument of the method. 
           All substrings among which is space will be removed and stored in the splitNumbers array.
         * For removing the empty elements after splitting, we add as a second parameter (argument) the constant 
           StringSplitOptions.RemoveEmptyEntries         so we instruct the method Split(…) to: 
         * Return all substrings from the variable that are split by given list of separators. 
         * Consider two or more neighboring separators as one. */
        string[] splitNumbers = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        //string[] splitNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int a = int.Parse(splitNumbers[0]);
        int b = int.Parse(splitNumbers[1]);
        int c = int.Parse(splitNumbers[2]);
        int d = int.Parse(splitNumbers[3]);
        int e = int.Parse(splitNumbers[4]);

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