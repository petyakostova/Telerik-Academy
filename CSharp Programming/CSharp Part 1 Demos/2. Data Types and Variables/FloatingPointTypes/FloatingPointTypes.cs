using System;

class FloatingPointTypes
{
    static void Main()
    {
        float floatPI = 3.141592653589793238f;
        double doublePI = 3.141592653589793238;
        Console.WriteLine("Float PI is: {0}", floatPI);
        Console.WriteLine("Double PI is: {0}", doublePI);

        // Example of comparison abnormality
        double a = 1.0f;
        double b = 0.33f;
        double sum = 1.33f;
        bool equal = (a + b == sum);
        Console.WriteLine(
			"Float calculation: a+b={0}  sum={1}  equal={2}", 
			a + b, sum, equal);

        // Decimal numbers do not have comparison abnormalities
        decimal aDecimal = 1.0M;
        decimal bDecimal = 0.33M;
        decimal sumDecimal = 1.33M;
        bool equalDecimal = (aDecimal + bDecimal == sumDecimal);
        Console.WriteLine(
			"Decimal calculation: a+b={0}  sum={1}  equal={2}", 
			aDecimal + bDecimal, sumDecimal, equalDecimal);
    }
}
