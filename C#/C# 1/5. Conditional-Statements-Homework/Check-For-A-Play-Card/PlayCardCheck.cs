/* 3. Check for a Play Card
   Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
   Write a program that enters a string and prints "yes CONTENT_OF_STRING" if it is a valid card sign or "no CONTENT_OF_STRING" otherwise. String length will always be between 1 and 5. */

using System;

class PlayCardCheck
{
    static void Main()
    {
        string sign = Console.ReadLine();

        // first way - if-else statement
        if (sign == "2" || sign == "3" || sign == "4" || sign == "5" || sign == "6" || sign == "7" || sign == "8" || sign == "9" 
            || sign == "10" || sign == "J" || sign == "Q" || sign == "K" || sign == "A") 
        {
            Console.WriteLine("yes {0}", sign);
        }
        else
        {
            Console.WriteLine("no {0}", sign);
        }

        ////second way - using swicth-case
        //switch (sign)
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
        //        Console.WriteLine("yes {0}", sign);
        //        break;
        //    default:
        //        Console.WriteLine("no {0}", sign);
        //        break;
        //}

    }
}