using System;

class ChessQueensAS
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        int diff = d + 1;

        char[] letters = new char[n];

        bool noValid = true;

        for (int i = 0; i < n; i++)
        {
            letters[i] = (char)('a' + i);
        }

        for (int x1 = 0; x1 < n; x1++)
        {
            for (int y1 = 0; y1 < n; y1++)
            {
                for (int x2 = 0; x2 < n; x2++)
                {
                    for (int y2 = 0; y2 < n; y2++)
                    {
                        bool xMeet = x1 == x2 && Math.Abs(y1 - y2) == diff;
                        bool yMeet = y1 == y2 && Math.Abs(x1 - x2) == diff;
                        bool diagonalMeet = Math.Abs(x1 - x2) == diff && Math.Abs(y1 - y2) == diff;

                        if (xMeet || yMeet || diagonalMeet)
                        {
                            Console.WriteLine("{0}{1} - {2}{3}", letters[x1], y1 + 1, letters[x2], y2 + 1);
                            noValid = false;
                        }
                    }
                }
            }
        }
        if (noValid)
        {
            Console.WriteLine("No valid positions");
        }
    }
}