using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
class Program
{
    static readonly Random rand = new Random(100);

    static void Main(string[] args)
    {   
        /* this is NOT my production code quality */
        const string TESTS_DIR = ".\\tests";
        Directory.CreateDirectory(TESTS_DIR);
        int ix = 0;

        while (true)
        {
            ix += 1;
            string name = "test." + (ix + "").PadLeft(3, '0');
            Console.WriteLine("Generating test case " + name);

            var userFile = TESTS_DIR + "\\" + name + ".user.txt";

            TextWriter userOutput, userSaved;
            TextReader userInput;

            if (File.Exists(userFile))
            {
                userInput = new StreamReader(userFile);
                userOutput = new StringWriter();
                userSaved = new StringWriter();
            }
            else
            {
                userInput = Console.In;
                userOutput = Console.Out;
                userSaved = new StreamWriter(TESTS_DIR + "\\" + name + ".user.txt");
            }

            using (var input = new StreamWriter(TESTS_DIR + "\\" + name + ".in.txt"))
            using (var output = new StreamWriter(TESTS_DIR + "\\" + name + ".out.txt"))
            using (var debug = new StreamWriter(TESTS_DIR + "\\" + name + ".debug.txt"))
            using (userInput)
            using (userOutput)
            using (userSaved)
            {
                Generate(input, output, debug, userInput, userOutput, userSaved);
            }
        }

    }

    static void Generate(
        TextWriter input,
        TextWriter output,
        TextWriter debug,
        TextReader userInput,
        TextWriter userOutput,
        TextWriter userSaved)
    {
        bool[,] field = new bool[4, 8];
        int score = 0;
        string shape = null;
        int row = 0;

        Action wrongInput = () => userOutput.WriteLine("Wrong input, try again...");

        Action<bool> print = (bool ignoreShape) => {
            Print(debug, field, shape, row, ignoreShape);
            debug.WriteLine();
            debug.WriteLine("score: " + score);

            Print(userOutput, field, shape, row, ignoreShape);
        };
        Action end = () => {
            output.WriteLine(score);
            debug.WriteLine();
            debug.WriteLine("Game over:");
            Print(debug, field, null, 0, true);
            debug.WriteLine();
            debug.WriteLine("score: " + score);

        };


        while (true)
        {
            userOutput.WriteLine("Enter next shape as string of 0s and 1s, followed by optional modifier:");
            userOutput.WriteLine("01234567");

            var inputString = userInput.ReadLine();

            if (inputString == null)
            {
                end();
                return;
            }
            var split = inputString.Split('|');

            shape = split[0].PadRight(8, '0');

            if (shape.Length != 8 ||
               shape.Any(c => (c != '0' && c != '1')))
            {
                wrongInput();
                continue;
            }

            if (!shape.Any(c => c == '1'))
            {
                wrongInput();
                continue;
            }

            string modifier = "0";

            if (split.Length >= 2)
            {
                modifier = split[1];
            }

            input.WriteLine((Convert.ToUInt32(modifier, 2) << 8) + Convert.ToUInt32(shape, 2));

            debug.WriteLine();
            debug.WriteLine(">> " + Convert.ToUInt32(shape, 2));
            debug.WriteLine();

            userSaved.WriteLine(inputString);

            row = 0;

            while (true)
            {
                print(false);

                if (row != 3)
                {
                    userOutput.WriteLine("Enter push direction (L/R/D/\"\"):");
                    string dir = userInput.ReadLine().ToUpper();

                    
                    if (dir == "L")
                    {
                        if (shape[0] == '0')
                            shape = shape.Substring(1) + "0";
                    }
                    else if (dir == "R")
                    {
                        if (shape[7] == '0')
                            shape = "0" + shape.Substring(0, 7);
                    }
                    else if (dir == "D" || dir == "")
                    {
                    }
                    else
                    {
                        wrongInput();
                        continue;
                    }

                    input.WriteLine(dir);

                    userSaved.WriteLine(dir);

                    debug.WriteLine();
                    debug.WriteLine(">> " + dir);
                    debug.WriteLine();

                }



                row += 1;

                int hammingWeight = inputString.Count(c => c == '1');

                if (row == 4 ||
                    Enumerable.Range(0, 8).Any(i => shape[i] == '1' && field[row, i]))
                {
                    SetRow(field, row - 1, shape);

                    if (GetRow(field, row - 1).All(b => b))
                    {
                        DeleteRow(field, row - 1);
                        score += hammingWeight * 10;

                    }
                    else
                    {
                        score += hammingWeight;
                    }

                    input.Write(PadDirections(row));

                    if (row != 4)
                    {
                        print(true);
                    }



                    if (GetRow(field, 0).Any(b => b))
                    {
                        end();
                        return;
                    }

                    break;
                }



            }
        }
    }

    static string PadDirections(int row)
    {
        string ret = "";
        for (int ii = row + 1; ii < 4; ++ii)
        {
            ret += ("LDR"[rand.Next(0, 3)]) + "\r\n";
        }
        return ret;
    }
    static void DeleteRow(bool[,] field, int row)
    {
        for (int row2 = row; row2 > 0; --row2)
        {
            for (int col = 0; col < field.GetLength(1); ++col)
            {
                field[row2, col] = field[row2 - 1, col];
            }
        }
        for (int col = 0; col < field.GetLength(1); ++col)
        {
            field[0, col] = false;
        }
    }

    static void SetRow(bool[,] field, int row, string shape)
    {
        for (int col = 0; col < shape.Length; ++col)
        {
            if (shape[col] == '1')
                field[row, col] = true;
        }
    }

    static IEnumerable<bool> GetRow(bool[,] field, int row)
    {
        return Enumerable.Range(0, field.GetLength(1))
                         .Select(col => field[row, col]);
    }

    static void Print(TextWriter tw, bool[,] field, string shape, int row, bool ignoreShape)
    {
        for (int row2 = 0; row2 < field.GetLength(0); ++row2)
        {
            for (int col = 0; col < field.GetLength(1); ++col)
            {
                tw.Write((field[row2, col] || (!ignoreShape && row2 == row && shape[col] == '1')) ? '1' : '0');
            }
            tw.WriteLine();
        }


    }

}



















