using System;
using System.Collections.Generic;

class BullsAndCows
{
    static void Main()
    {
        int secretNumber = int.Parse(Console.ReadLine());
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        
        // split the digits of the secret number
        int secretNumberD = secretNumber % 10;
        secretNumber /= 10;
        int secretNumberC = secretNumber % 10;
        secretNumber /= 10;
        int secretNumberB = secretNumber % 10;
        secretNumber /= 10;
        int secretNumberA = secretNumber % 10;
        
        bool foundNumber = false;

        // check all 4-digit numbers 
        for (int i = 1000; i <= 9999; i++)
        {
            // save i => the current 4-digit number
            int currentNumber = i;

            // split the digits of the current number
            int currentD = currentNumber % 10;
            currentNumber /= 10;
            int currentC = currentNumber % 10;
            currentNumber /= 10;
            int currentB = currentNumber % 10;
            currentNumber /= 10;
            int currentA = currentNumber % 10;

            // The secret number doesn't include 0-s 
            if (currentA == 0 || currentB == 0 || currentC == 0 || currentD == 0)   
            {
                continue;
            }

            // reset the counters for bulls and cows
            int currentBulls = 0;
            int currentCows = 0;

            // set the secret digits to the right value
            int tempSecretA = secretNumberA;
            int tempSecretB = secretNumberB;
            int tempSecretC = secretNumberC;
            int tempSecretD = secretNumberD;

            #region Find Bulls
            if (currentA == tempSecretA)
            {
                currentBulls++;
                // change the values to mark them as used => so they couldn't match with other digits later by searching cows                
                currentA = -1;
                tempSecretA = -2;
            }
            if (currentB == tempSecretB)
            {
                currentBulls++;
                currentB = -1;
                tempSecretB = -2;
            }
            if (currentC == tempSecretC)
            {
                currentBulls++;
                currentC = -1;
                tempSecretC = -2;
            }
            if (currentD == tempSecretD)
            {
                currentBulls++;
                currentD = -1;
                tempSecretD = -2;
            }
            #endregion

            #region Find Cows
            var list = new List<int>();
            // add the current digits to list
            if (currentA > 0) list.Add(currentA);   
            if (currentB > 0) list.Add(currentB);
            if (currentC > 0) list.Add(currentC);
            if (currentD > 0) list.Add(currentD);

            // if the list contains the digit of secret number, remove it from list and coint it for cow
            if (list.Contains(tempSecretA))    
            {
                list.Remove(tempSecretA);  
                currentCows++;
            }
            if (list.Contains(tempSecretB))
            {
                list.Remove(tempSecretB);
                currentCows++;
            }
            if (list.Contains(tempSecretC))
            {
                list.Remove(tempSecretC);
                currentCows++;
            }
            if (list.Contains(tempSecretD))
            {
                list.Remove(tempSecretD);
                currentCows++;
            }
            #endregion

            if (currentBulls == bulls && currentCows == cows)
            {
                foundNumber = true;
                Console.Write("{0} ", i);
            }
        }

        if (!foundNumber)
        {
            Console.WriteLine("No");
        }

    }
}