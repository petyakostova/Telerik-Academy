using System;

class ArithmeticOperators
{
	static void Main()
	{
        int squarePerimeter = 17;
        double squareSide = squarePerimeter / 4.0;
        double squareArea = squareSide * squareSide;
        Console.WriteLine(squareSide); // 4.25
        Console.WriteLine(squareArea); // 18.0625
        
        int a = 5;
        int b = 4;
        Console.WriteLine(a + b); // 9
        Console.WriteLine(a + b++); // 9     [ 5+4=9;  b=4+1=5 ]
        Console.WriteLine(a + b); // 10      [ 5+5=10 ]
        Console.WriteLine(a + (++b)); // 11  [ b=5+1=6; 5+6=11 ] 
        Console.WriteLine(a + b); // 11      [ 5+6=11 ]

        Console.WriteLine(11 / 3); // 3
        Console.WriteLine(11 % 3); // 2
        Console.WriteLine(12 / 3); // 4

		Console.WriteLine(11.0 / 3); // 3.66666666666667
		Console.WriteLine(11 / 3.0); // 3.66666666666667
		Console.WriteLine(11 % 3);   // 2
		Console.WriteLine(11 % -3);  // 2       [11=-3*(-3)+2]
		Console.WriteLine(-11 % 3);  // -2      [-11=3*(-3)+(-2)]

		Console.WriteLine("1.5 / 0.0 = " + (1.5 / 0.0)); // Infinity
		Console.WriteLine("-1.5 / 0.0 = " + (-1.5 / 0.0)); // -Infinity
		Console.WriteLine("0.0 / 0.0 = " + (0.0 / 0.0)); // NaN

		// This will produce DivideByZeroException
		//int x = 0;    // devision by 0 with integer numbers produce exception
		//Console.WriteLine("5 / 0 = " + (5 / x));

		int bigNum = 2000000000;
		int bigSum = 2 * bigNum; // Integer overflow!
		Console.WriteLine(bigSum); // -294967296

		bigNum = Int32.MaxValue;            //2147483647
		bigNum = bigNum + 1;
		Console.WriteLine(bigNum);          // -2147483648  Integer overflow!

        bigNum = Int32.MaxValue;            //2147483647
        long yetBigger = (long)bigNum + 1;  // 2147483648
        Console.WriteLine(yetBigger);

        checked
		{
            //This will cause OverflowException

            //bigSum = bigNum * 2;
        }
	}
}