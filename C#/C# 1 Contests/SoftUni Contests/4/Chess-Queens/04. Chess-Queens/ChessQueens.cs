using System;

class ChessQueens
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        /* We must add 1 to the given distance to specify the corresponding coordinate, for example:
           If we have d=1 and position a1 => the position of the right distance=1 will be a3, 
           but 1 + d = 2 => diff must be d+1 */
        int diff = d + 1;   
        
        char[] letters = new char[n];
        for (int i = 0; i < letters.Length; i++)
        {
            letters[i] = (char)('a' + i);
        }

        bool isExist = false;

        for (int x1 = 0; x1 < n; x1++)
        {
            for (int y1 = 0; y1 < n; y1++)
            {
                for (int x2 = 0; x2 < n; x2++)
                {
                    for (int y2 = 0; y2 < n; y2++)
                    {
                        //bool meetX = x1 == x2 && Math.Abs(y1 - y2) == diff;                        
                        bool meetX = (x1 == x2 && y1 == y2 + d + 1) || (x1 == x2 && y1 == y2 - (d + 1));  // (a,b,...)
                        //bool meetY = y1 == y2 && Math.Abs(x1 - x2) == diff;
                        bool meetY = (y1 == y2 && x1 == x2 + d + 1) || (y1 == y2 && x1 == x2 - (d + 1));  // (1,2,...)

                        // x1>x2 && y1<y2
                        bool meetDiagonal1 = (x1 == x2 + d + 1) && (y1 == y2 - (d + 1));
                        // x1<x2 && y1<y2
                        bool meetDiagonal2 = (x1 == x2 - (d + 1)) && (y1 == y2 - (d + 1));
                        // x1>x2 && y1>y2   
                        bool meetDiagonal3 = (x1 == x2 + d + 1) && (y1 == y2 + d + 1);
                        // x1<x2 && y1>y2
                        bool meetDiagonal4 = (x1 == x2 - (d + 1)) && (y1 == y2 + d + 1);

                        //bool meetDiagonal = Math.Abs(x1 - x2) == diff && Math.Abs(y1 - y2) == diff;
                        bool meetDiagonal = meetDiagonal1 || meetDiagonal2 || meetDiagonal3 || meetDiagonal4;

                        if (meetX || meetY || meetDiagonal)
                        {
                            //for y we add 1, because it must start from 1, not from 0 (like it's in the for loop) 
                            Console.WriteLine("{0}{1} - {2}{3}", letters[x1], y1 + 1, letters[x2], y2 + 1); 
                            isExist = true;
                        }
                    }
                }
            }
        }

        if (!isExist)
        {
            Console.WriteLine("No valid positions");
        }
    }
}