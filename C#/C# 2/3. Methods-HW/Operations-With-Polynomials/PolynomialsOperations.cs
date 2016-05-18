/*  Problem 11. Adding polynomials
    Write a method that adds two polynomials.
    Represent them as arrays of their coefficients.
    Example:
                    x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}
 
    // In the file "example AddingPolynomials" the example is displayed better.

    Problem 12. Subtracting polynomials
    Extend the previous program to support also subtraction and multiplication of polynomials.
 */

using Operations_With_Polynomials;

namespace Operations_With_Polynomials
{
    using System;
    using System.Collections.Generic;
    class PolynomialOperations
    {
        static void Main(string[] args)
        {
            Polynomial a;
            Polynomial b;

            a = new Polynomial("x");
            a.AddMononomial(new Mononomial(4, 2));
            a.AddMononomial(new Mononomial(-3, 1));
            a.AddMononomial(new Mononomial(2, 0));

            b = new Polynomial("x");
            b.AddMononomial(new Mononomial(5, 2));
            b.AddMononomial(new Mononomial(2, 1));
            b.AddMononomial(new Mononomial(-7, 0));

            PrintResult(a, b, Operation.Addition);

            a = new Polynomial("x");
            a.AddMononomial(new Mononomial(8, 2));
            a.AddMononomial(new Mononomial(2, 1));

            b = new Polynomial("x");
            b.AddMononomial(new Mononomial(10, 2));
            b.AddMononomial(new Mononomial(2, 1));
            b.AddMononomial(new Mononomial(-9, 0));

            PrintResult(a, b, Operation.Substraction);

            a = new Polynomial("x");
            a.AddMononomial(new Mononomial(3, 1));
            a.AddMononomial(new Mononomial(2, 0));

            b = new Polynomial("x");
            b.AddMononomial(new Mononomial(9, 2));
            b.AddMononomial(new Mononomial(-6, 1));
            b.AddMononomial(new Mononomial(4, 0));

            PrintResult(a, b, Operation.Multiplication);
        }

        private static void PrintResult(Polynomial a, Polynomial b, Operation operation)
        {
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            switch (operation)
            {
                case Operation.Addition:
                    Console.WriteLine("A + B = " + (a + b) + Environment.NewLine);
                    break;
                case Operation.Substraction:
                    Console.WriteLine("A - B = " + (a - b) + Environment.NewLine);
                    break;
                case Operation.Multiplication:
                    Console.WriteLine("A * B = " + (a * b) + Environment.NewLine);
                    break;
                default:
                    break;
            }
        }
    }
}