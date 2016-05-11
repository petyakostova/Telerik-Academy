/*  Problem 6. Matrix class
    Write a class Matrix, to hold a matrix of integers. 
    Overload the operators for adding, subtracting and multiplying of matrices, 
    indexer for accessing the matrix content and ToString().
 */
using System;

class MatrixTester
{
    static void Main()
    {
        Matrix testMatrix1 = new Matrix(2, 3);
        testMatrix1[0, 0] = 1;
        testMatrix1[0, 1] = 2;
        testMatrix1[0, 2] = 3;

        testMatrix1[1, 0] = 4;
        testMatrix1[1, 1] = 5;
        testMatrix1[1, 2] = 6;

        Matrix testMatrix2 = new Matrix(3, 2);
        testMatrix2[0, 0] = 7;
        testMatrix2[0, 1] = 8;

        testMatrix2[1, 0] = 9;
        testMatrix2[1, 1] = 10;

        testMatrix2[2, 0] = 11;
        testMatrix2[2, 1] = 12;

        Matrix testMatrix3 = new Matrix(2, 3);
        testMatrix3[0, 0] = 1;
        testMatrix3[0, 1] = 2;
        testMatrix3[0, 2] = 3;

        testMatrix3[1, 0] = 4;
        testMatrix3[1, 1] = 5;
        testMatrix3[1, 2] = 6;
        
        Matrix resultAdd = Matrix.Add(testMatrix1, testMatrix3);
        var add = testMatrix1 + testMatrix3;

        Console.WriteLine(add);
        Console.WriteLine(resultAdd);

        Matrix resultSubstract = Matrix.Substract(testMatrix1, testMatrix3);
        var substract = testMatrix1 - testMatrix3;

        Console.WriteLine(resultSubstract);
        Console.WriteLine(substract);

        Matrix resultMultiply = Matrix.Multiply(testMatrix1, testMatrix2);
        var multiply = testMatrix1 * testMatrix2;

        Console.WriteLine(resultMultiply);
        Console.WriteLine(multiply);
    }
}