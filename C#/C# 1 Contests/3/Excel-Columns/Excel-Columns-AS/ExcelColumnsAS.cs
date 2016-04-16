using System;

class ExcelColumnsAS
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        long index = 0; // If N > 12 we should use bigger data type (e.g. decimal or BigInteger)
        for (int i = 1; i <= N; i++)
        {
            char ch = char.Parse(Console.ReadLine()); // Console.ReadLine()[0]
            index *= 26;
            index += ch - 'A' + 1;
        }
        Console.WriteLine(index);
    }
}