/* Problem 12.** Falling Rocks
Implement the "Falling Rocks" game in the text console.
A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
Ensure a constant game speed by Thread.Sleep(150).
Implement collision detection and scoring system.                                */

using System;
using System.Threading;

class FallingRocks
{
    static void Main()
    {
        Console.WindowHeight = 26;
        Console.WindowWidth = 26;
        int point = 0;
        bool isColision = false;
        string[] allSymbols = { "^", "@", "*", "&", "+", "%", "$", "#", "!", ".", ";" };
        string[,] canvas = new string[25, 25];
        for (int i = 0; i < canvas.GetLength(0); i++)
        {
            for (int j = 0; j < canvas.GetLength(1); j++)
            {
                canvas[i, j] = " ";
            }
        }
        Random rnd = new Random();
        string dwarf = "(0)";
        int dwarfPosition = 5;
        while (isColision == false)
        {
            string[] newLine = GenerateNewLineWithSymbols(rnd, allSymbols);
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo dwarfDirection = Console.ReadKey();
                switch (dwarfDirection.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (dwarfPosition - 1 >= 0)
                        {
                            canvas[canvas.GetLength(0) - 1, dwarfPosition] = " ";
                            dwarfPosition--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (dwarfPosition + 1 < canvas.GetLength(1) - 3)
                        {
                            canvas[canvas.GetLength(0) - 1, dwarfPosition] = " ";
                            dwarfPosition++;
                        }
                        break;
                }
            }
            isColision = FillCanvas(canvas, dwarfPosition, dwarf, newLine);
            PaintCanvas(canvas);
            point++;
            Thread.Sleep(150);          // needs using System.Threading;
        }
        Console.WriteLine("You result is {0}", point);
    }

    public static void PaintCanvas(string[,] canvas)
    {
        Console.Clear();
        for (int row = 0; row < canvas.GetLength(0); row++)
        {
            for (int col = 0; col < canvas.GetLength(1); col++)
            {
                Console.Write(canvas[row, col]);
            }
            Console.WriteLine();
        }
    }

    private static bool FillCanvas(string[,] canvas, int position, string dwarf, string[] newLine)
    {
        for (int i = 1; i < 2; i++)
        {
            for (int j = 0; j < canvas.GetLength(1); j++)
            {
                canvas[i, j] = newLine[j];
            }
        }
        canvas[canvas.GetLength(0) - 1, position] = dwarf;
        bool result = false;
        for (int row = canvas.GetLength(0) - 2; row >= 0; row--)
        {
            for (int col = canvas.GetLength(1) - 1; col >= 0; col--)
            {
                if (row == canvas.GetLength(0) - 2)
                {
                    if (canvas[row, col] != " ")
                    {
                        if (col == position || col == position + 1 || col == position + 2)
                        {
                            result = true;
                            Console.Beep();
                        }
                        else
                        {
                            if (col < position)
                            {
                                canvas[row + 1, col] = canvas[row, col];
                            }
                            else
                            {
                                canvas[row + 1, col - 3] = canvas[row, col];
                            }
                        }
                    }
                    if (canvas[row + 1, col] != dwarf)
                    {
                        canvas[row + 1, col] = canvas[row, col];
                    }
                }
                else
                {
                    canvas[row + 1, col] = canvas[row, col];
                }
            }
        }
        return result;
    }

    public static string[] GenerateNewLineWithSymbols(Random rnd, string[] symbols)
    {
        string[] result = new string[25];
        int numberOffGenerateSymbols = rnd.Next(0, 3);
        for (int i = 0; i < numberOffGenerateSymbols; i++)
        {
            result[rnd.Next(0, 24)] = symbols[rnd.Next(0, 9)];
        }
        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] == null)
            {
                result[i] = " ";
            }
        }
        return result;
    }
}