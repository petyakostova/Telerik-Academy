/* Problem 9. Play with Int, Double and String
   Write a program that, depending on the user’s choice, inputs an int, double or string variable.
        If the variable is int or double, the program increases it by one.
        If the variable is a string, the program appends * at the end.
   Print the result at the console. Use switch statement.
Example 1:                                  Example 2:
program 	            user                program 	            user
Please choose a type: 	                    Please choose a type: 	
1 --> int 	                                1 --> int 
2 --> double 	                            2 --> double 	        2
3 --> string 	        3	                3 --> string 
Please enter a string: 	hello	            Please enter a double: 	1.5
hello* 	                                    2.5                                                     */

using System;
using System.Globalization;
using System.Threading;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;/*changes the culture of the program in American standard
                                                                             so the decimal point character is . */
        Console.WriteLine("Please choose a type: \r\n 1 --> int \r\n 2 --> double \r\n 3 --> string");
        string choice = Console.ReadLine();
        while (choice != "1" && choice != "2" && choice != "3")
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("Please choose between 1, 2 or 3: ");
            choice = Console.ReadLine();
        }
        switch (choice)
        {
            case "1":
                {
                    int number;
                    Console.WriteLine("Please enter a int: ");
                    while (!int.TryParse(Console.ReadLine(), out number))
                    {
                        Console.WriteLine("Invalid number.");
                        Console.Write("Please enter a correct integer number: ");
                    }
                    Console.WriteLine(number + 1);
                    break;
                }
            case "2":
                {
                    double number;
                    Console.WriteLine("Please enter a double: ");
                    while (!double.TryParse(Console.ReadLine(), out number))
                    {
                        Console.WriteLine("Invalid number.");
                        Console.Write("Please enter a correct real number: ");
                    }
                    Console.WriteLine(number + 1);
                    break;
                }
            case "3":
                {
                    Console.WriteLine("Please enter a string: ");
                    Console.WriteLine(Console.ReadLine() + "*");
                    break;
                }
        }
    }
}