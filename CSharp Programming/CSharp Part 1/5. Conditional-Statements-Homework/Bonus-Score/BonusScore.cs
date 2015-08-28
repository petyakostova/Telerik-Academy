/* Problem 2. Bonus Score
Write a program that applies bonus score to given score in the range [1…9] by the following rules:
    If the score is between 1 and 3, the program multiplies it by 10.
    If the score is between 4 and 6, the program multiplies it by 100.
    If the score is between 7 and 9, the program multiplies it by 1000.
    If the score is 0 or more than 9, the program prints “invalid score”.
Examples:
score 	result
2 	    20
4 	    400
9 	    9000
-1 	    invalid score
10 	    invalid score
*/

using System;

class BonusScore
{
    static void Main()
    {
        int score;
        Console.Write("Enter a score in the [1...9]: ");
        while (!int.TryParse(Console.ReadLine(), out score))                    // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid score!");
            Console.WriteLine("Enter a correct score: ");
        }
        switch (score)                                                          // first way - using switch-case
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine("result = {0}", score * 10);
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine("result = {0}", score * 100);
                break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine("result = {0}", score * 1000);
                break;
            default:
                Console.WriteLine("invalid score");
                break;
        }
        //if (score >= 1 && score <= 3)                                           // second way - using multiple if-else
        //{
        //    score *= 10;
        //    Console.WriteLine("result = {0}", score);
        //}
        //else if (score >= 4 && score <= 6)
        //{
        //    score *= 100;
        //    Console.WriteLine("result = {0}", score);
        //}
        //else if (score >= 7 && score <= 9)
        //{
        //    score *= 1000;
        //    Console.WriteLine("result = {0}", score);
        //}
        //else
        //{
        //    Console.WriteLine("invalid score");
        //}
    }
}