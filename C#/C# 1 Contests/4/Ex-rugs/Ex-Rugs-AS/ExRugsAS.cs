using System;
using System.Text;

class ExRugsAS
{
    const char Blank = '.';
    const char Full = '#';
    const char Ex = 'X';
    const char LeftSym = '\\';
    const char RightSym = '/';

    // for hardcoded testing
    //const int size = 5;
    //const int div = 1;

    static void Main()
    {
        //new TestsGenerator().GenerateTests();

        int size = int.Parse(Console.ReadLine());
        int div = int.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();
        int fieldSize = 2 * size + 1;
        for (int row = 0; row < fieldSize; row++)
        {
            for (int col = 0; col < fieldSize; col++)
            {
                if (col - row <= div / 2 && col - row >= -div / 2 ||
                    col + row <= 2 * size + div / 2 && col + row >= 2 * size - div / 2)
                {
                    sb.Append(Full);
                }
                else if ((col == size + div / 2 + 1 || col == size - (div / 2 + 1)) && row == size ||
                    (row == size + (div / 2 + 1) || row == size - (div / 2 + 1)) && col == size)
                {
                    sb.Append(Ex);
                }
                else if (col - row == div / 2 + 1 ||
                    col - row == -(div / 2 + 1))
                {
                    sb.Append(LeftSym);
                }
                else if (col + row == 2 * size + (div / 2 + 1) ||
                    col + row == 2 * size - (div / 2 + 1))
                {
                    sb.Append(RightSym);
                }
                else
                {
                    sb.Append(Blank);
                }
            }

            if (row != fieldSize - 1)
            {
                sb.AppendLine();
            }
        }

        Console.WriteLine(sb);
    }
}