using System;

class RockLq
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string dotsOut = new string('.', n);
        string asterix = new string('*', n);
        string dotsIn = "";
        Console.WriteLine("{0}{1}{0}", dotsOut, asterix);   // part 1
        //Console.WriteLine(dotsOut + asterix + dotsOut);         

        for (int i = 0; i < n / 2; i++)
        {
            dotsOut = new string('.', n - 2 - 2 * i);
            dotsIn = new string('.', n + 2 + 4 * i);
            Console.WriteLine("{0}*{1}*{0}", dotsOut, dotsIn);   // part 2
            //Console.WriteLine(dotsOut + "*" + dotsIn + "*" + dotsOut);
        }

        dotsOut = new string('.', n - 2);
        dotsIn = new string('.', n);
        Console.WriteLine("*{0}*{1}*{0}*", dotsOut, dotsIn);   // part 3
        //Console.WriteLine("*" + dotsOut + "*" + dotsIn + "*" + dotsOut + "*");
        
        for (int i = 0; i < n / 2 - 1; i++)
        {
            string dotsR = new string('.', n - 4 - 2 * i);
            dotsOut = new string('.', 1 + 2 * i);
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", dotsR, dotsOut, dotsIn);   // part 4
            //Console.WriteLine("*" + dotsR + "*" + dotsOut + "*" + dotsIn + "*" + dotsOut + "*" + dotsR + "*");
        }

        for (int i = 0; i < n - 1; i++)
        {
            dotsOut = new string('.', n - 1 - i);
            dotsIn = new string('.', n + 2 * i);
            Console.WriteLine("{0}*{1}*{0}", dotsOut, dotsIn);   // part 5
            //Console.WriteLine(dotsOut + "*" + dotsIn + "*" + dotsOut);
        }

        asterix = new string('*', 3 * n);
        Console.WriteLine(asterix);   // part 6
    }
}