using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int guessNumber = int.Parse(Console.ReadLine());
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        bool foundNumber = false;
        for (int i = 1000; i <= 9999; i++)
        {
            int currentBulls = 0;
            int currentCows = 0;

            int currentNumber = i;
            int currentD = currentNumber % 10;
            currentNumber /= 10;
            int currentC = currentNumber % 10;
            currentNumber /= 10;
            int currentB = currentNumber % 10;
            currentNumber /= 10;
            int currentA = currentNumber % 10;

            if (currentA == 0 || currentB == 0 || currentC == 0 || currentD == 0)
            {
                continue;
            }

            int tempGuessNumber = guessNumber;
            int guessNumberD = tempGuessNumber % 10;
            tempGuessNumber /= 10;
            int guessNumberC = tempGuessNumber % 10;
            tempGuessNumber /= 10;
            int guessNumberB = tempGuessNumber % 10;
            tempGuessNumber /= 10;
            int guessNumberA = tempGuessNumber % 10;

            #region Find bulls
            if (currentA == guessNumberA)
            {
                currentBulls++;
                currentA = -1;
                guessNumberA = -2;
            }

            if (currentB == guessNumberB)
            {
                currentBulls++;
                currentB = -1;
                guessNumberB = -2;
            }

            if (currentC == guessNumberC)
            {
                currentBulls++;
                currentC = -1;
                guessNumberC = -2;
            }

            if (currentD == guessNumberD)
            {
                currentBulls++;
                currentD = -1;
                guessNumberD = -2;
            }
            #endregion

            var list = new List<int>();
            if (currentA > 0) list.Add(currentA);
            if (currentB > 0) list.Add(currentB);
            if (currentC > 0) list.Add(currentC);
            if (currentD > 0) list.Add(currentD);
            if (list.Contains(guessNumberA))
            {
                list.Remove(guessNumberA);
                currentCows++;
            }
            if (list.Contains(guessNumberB))
            {
                list.Remove(guessNumberB);
                currentCows++;
            }
            if (list.Contains(guessNumberC))
            {
                list.Remove(guessNumberC);
                currentCows++;
            }
            if (list.Contains(guessNumberD))
            {
                list.Remove(guessNumberD);
                currentCows++;
            }

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
        else
        {
            Console.WriteLine();
        }
    }
}