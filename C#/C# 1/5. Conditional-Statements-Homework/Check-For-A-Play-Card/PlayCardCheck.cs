/* Problem 3. Check for a Play Card
Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. 
Examples:
character 	Valid card sign?
5 	        yes
1 	        no
Q 	        yes
q 	        no
P 	        no
10 	        yes
500 	    no                                      */

using System;

class PlayCardCheck
{
    static void Main()
    {
        Console.Write("Enter a sigh: ");
        string sign = Console.ReadLine();
        if (sign == "2" || sign == "3" || sign == "4" || sign == "5" || sign == "6" || sign == "7" || sign == "8" || sign == "9" 
            || sign == "10" || sign == "J" || sign == "Q" || sign == "K" || sign == "A") // first way - if-else statement
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
        //switch (sign)                                                                  // second way - using swicth-case
        //{
        //    case "2":
        //    case "3":
        //    case "4":
        //    case "5":
        //    case "6":
        //    case "7":
        //    case "8":
        //    case "9":
        //    case "10":
        //    case "J":
        //    case "Q":
        //    case "K":
        //    case "A":
        //        Console.WriteLine("yes");
        //        break;
        //    default: Console.WriteLine("no");
        //        break;
        //}
    }
}