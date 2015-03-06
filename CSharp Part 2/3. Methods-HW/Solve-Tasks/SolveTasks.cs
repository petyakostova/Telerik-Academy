/*  Problem 13. Solve tasks
    Write a program that can solve these tasks:
        Reverses the digits of a number
        Calculates the average of a sequence of integers
        Solves a linear equation a * x + b = 0
    Create appropriate methods.
    Provide a simple text-based menu for the user to choose which task to solve.
    Validate the input data:
        The decimal number should be non-negative
        The sequence should not be empty
        a should not be equal to 0
*/

using System;
using System.Text;

class MultipleTaskSolver
{
    public static void Main()
    {
        int choice = ChooseTaskToSolve();

        if (choice == 1)
        {
            ReversingDigitsOfNumber();
        }
        else if (choice == 2)
        {
            CalculatingAverageOfSequence();
        }
        else
        {
            SolvingLinearEquation();
        }
    }

    private static int ChooseTaskToSolve()
    {
        Console.WriteLine("Choose 1, 2 or 3 for a task to solve: ");
        Console.WriteLine("1: for reversing the digits of a number");
        Console.WriteLine("2: for calculating the average of sequence of integers");
        Console.WriteLine("3: for solving a linear expression of the type ax + b = 0");

        int choice = 0;

        do
        {
            int.TryParse(Console.ReadLine(), out choice);
        }
        while (choice != 1 && choice != 2 && choice != 3);

        return choice;
    }

    public static void ReversingDigitsOfNumber()
    {
        Console.Write("Enter the number : ");
        string number = Console.ReadLine().Trim();

        while (number[0] == '-')
        {
            Console.Write("Enter the number again! It can not be negative : ");
            number = Console.ReadLine().Trim();
        }

        StringBuilder answer = new StringBuilder();

        for (int i = number.Length - 1; i >= 0; i--)
        {
            answer.Append(number[i]);
        }

        Console.WriteLine(answer.ToString());
    }

    public static void CalculatingAverageOfSequence()
    {
        Console.Write("Enter the number of integers: ");
        double n = int.Parse(Console.ReadLine());
        while (n == 0)
        {
            Console.WriteLine("The number of integers should not be 0!\n Enter the number of integers again:");
            n = int.Parse(Console.ReadLine());
        }
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the {0} integer : ", i);
            sum += double.Parse(Console.ReadLine());
        }

        Console.WriteLine(sum / n);
    }

    public static void SolvingLinearEquation()
    {
        Console.Write("Enter coeficient before x : ");
        double x = double.Parse(Console.ReadLine());
        while (x == 0)
        {
            Console.WriteLine("the coeficient before x can not be 0! Enter it again: ");
            x = double.Parse(Console.ReadLine());
        }

        Console.Write("Enter the free coeficient : ");
        double free = double.Parse(Console.ReadLine());

        double answer = (free * (-1)) / x;
        Console.WriteLine(answer);
    }
}