/* 2. Bonus Score
   Write a program that applies bonus score to given score in the range [1...9] by the following rules:
        If the score is between 1 and 3, the program multiplies it by 10.
        If the score is between 4 and 6, the program multiplies it by 100.
        If the score is between 7 and 9, the program multiplies it by 1000.
        If the score is less than 0 or more than 9, the program prints "invalid score".
   The only input line will contain one integer number - the score.
   Output the score with the applied bonus.
   Constraints: The score will always be a valid integer number. */

using System;

class BonusScore
{
    static void Main()
    {
        int score = int.Parse(Console.ReadLine());

        // first way - using switch-case
        switch (score)                                                          
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine(score * 10);
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine(score * 100);
                break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine(score * 1000);
                break;
            default:
                Console.WriteLine("invalid score");
                break;
        }

        //// second way - using multiple if-else
        //if (score >= 1 && score <= 3)                                           
        //{
        //    Console.WriteLine(score* 10);
        //}
        //else if (score >= 4 && score <= 6)
        //{
        //    Console.WriteLine(score* 100);
        //}
        //else if (score >= 7 && score <= 9)
        //{
        //    Console.WriteLine(score* 1000);
        //}
        //else
        //{
        //    Console.WriteLine("invalid score");
        //}
    }
}