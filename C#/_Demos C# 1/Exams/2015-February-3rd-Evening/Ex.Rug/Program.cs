namespace Ex.Rug
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            char hash = '#';
            char dot = '.';
            char forwardSlash = '\\';
            char backSlash = '/';
            char X = 'X';

            int width, height;
            width = height = 2 * N + 1;

            if (D >= N * 2 + 1)
            {
                for (int i = 0; i < height; i++)
                {
                    Console.WriteLine(new string(hash, width));
                }
            }
            else
            {
                char[,] rug = new char[height, width];

                // Right-to-left hashes
                for (int i = 0; i < D / 2 + 1; i++)
                {
                    for (int row = 0, col = i; col < width; row++, col++)
                    {
                        rug[row, col] = hash;
                    }

                    for (int row = i, col = 0; row < height; row++, col++)
                    {
                        rug[row, col] = hash;
                    }
                }

                // Left-to-right hashes
                for (int i = 0; i < D / 2 + 1; i++)
                {
                    for (int row = 0, col = width - 1 - i; col >= 0; row++, col--)
                    {
                        rug[row, col] = hash;
                    }

                    for (int row = i, col = width - 1; row < height; row++, col--)
                    {
                        rug[row, col] = hash;
                    }
                }

                // Forward slashes
                for (int row = 0, col = D / 2 + 1; col < width / 2; row++, col++)
                {
                    rug[row, col] = forwardSlash;
                }

                for (int row = D / 2 + 1, col = 0; row < height / 2; row++, col++)
                {
                    rug[row, col] = forwardSlash;
                }

                for (int row = height / 2 + 1, col = width / 2 + D / 2 + 1 + 1; col < width; row++, col++)
                {
                    rug[row, col] = forwardSlash;
                }

                for (int row = height / 2 + D / 2 + 1 + 1, col = width / 2 + 1; row < height; row++, col++)
                {
                    rug[row, col] = forwardSlash;
                }

                // Back slashes
                for (int row = 0, col = width - 1 - D / 2 - 1; col > width / 2; row++, col--)
                {
                    rug[row, col] = backSlash;
                }

                for (int row = D / 2 + 1, col = width - 1; row < height / 2; row++, col--)
                {
                    rug[row, col] = backSlash;
                }

                for (int row = height / 2 + 1, col = width / 2 - D / 2 - 1 - 1; col >= 0; row++, col--)
                {
                    rug[row, col] = backSlash;
                }

                for (int row = height / 2 + D / 2 + 1 + 1, col = width / 2 - 1; row < height; row++, col--)
                {
                    rug[row, col] = backSlash;
                }

                // Fill X's
                rug[height / 2 - D / 2 - 1, width / 2] = X;
                rug[height / 2 + D / 2 + 1, width / 2] = X;
                rug[height / 2, width / 2 - D / 2 - 1] = X;
                rug[height / 2, width / 2 + D / 2 + 1] = X;

                // Fill points
                for (int row = 0; row < rug.GetLength(0); row++)
                {
                    for (int col = 0; col < rug.GetLength(1); col++)
                    {
                        if (rug[row, col] == '\0')
                        {
                            rug[row, col] = dot;
                        }
                    }
                }

                Print(rug);
            }
        }

        static void Print(char[,] rug)
        {
            for (int row = 0; row < rug.GetLength(0); row++)
            {
                for (int col = 0; col < rug.GetLength(1); col++)
                {
                    Console.Write(rug[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
