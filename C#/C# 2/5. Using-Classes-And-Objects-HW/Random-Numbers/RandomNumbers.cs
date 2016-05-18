/*  2. Random numbers
    Write a program that generates and prints to the console 10 random values in the range [100, 200].
 */

using System;

class RandomNumbers
{
    static void Main()
    {
        Random rndGenerator = new Random();

        for (int i = 0; i < 10; i++)
        {
            // prints to the console random value in the range [100, 200]
            Console.WriteLine(rndGenerator.Next(100, 201)); 
        }
    }
}