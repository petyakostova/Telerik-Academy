using System;

public class FormulaBit1AS
{
    static void Main(string[] args)
    {
        int byteLength = 8;
        byte track0; byte track1; byte track2; byte track3;
        byte track4; byte track5; byte track6; byte track7;

        track0 = byte.Parse(Console.ReadLine());
        track1 = byte.Parse(Console.ReadLine());
        track2 = byte.Parse(Console.ReadLine());
        track3 = byte.Parse(Console.ReadLine());
        track4 = byte.Parse(Console.ReadLine());
        track5 = byte.Parse(Console.ReadLine());
        track6 = byte.Parse(Console.ReadLine());
        track7 = byte.Parse(Console.ReadLine());


        long track = 0L;
        track |= track7; track <<= byteLength;
        track |= track6; track <<= byteLength;
        track |= track5; track <<= byteLength;
        track |= track4; track <<= byteLength;
        track |= track3; track <<= byteLength;
        track |= track2; track <<= byteLength;
        track |= track1; track <<= byteLength;
        track |= track0;

        if (track0 % 2 != 0)
        {
            Console.WriteLine("No 0");
            return;
        }

        int currentRow = 0;
        int currentCol = 0;

        string previousDirection = "down";
        string currentDirection = "down";

        int turnsCount = 0;
        int trackLength = 0;
        bool trackIsFinished = false;
        bool trackCanContinue = true;

        while (trackCanContinue)
        {
            trackLength++;

            //Checks if we have made a turn
            if (currentDirection != previousDirection)
            {
                turnsCount++;
            }

            //Checks if track has ended
            if (currentRow == byteLength - 1 && currentCol == byteLength - 1)
            {
                trackIsFinished = true;
                break;
            }

            previousDirection = currentDirection;

            int possibleNextRow = 0;
            int possibleNextCol = 0;
            int testIfTrackIsZero = 0;

            //Checks if we can continue in the same direction
            bool canContinueInSameDirection = false;

            switch (currentDirection)
            {
                case "down":
                    possibleNextRow = currentRow + 1;
                    possibleNextCol = currentCol;
                    if (possibleNextRow > byteLength - 1)
                    {
                        canContinueInSameDirection = false;
                    }
                    else
                    {
                        testIfTrackIsZero = possibleNextRow * byteLength + possibleNextCol;
                        if (((track >> testIfTrackIsZero) & 1) == 0)
                        {
                            canContinueInSameDirection = true;
                        }
                    }
                    break;
                case "up":
                    possibleNextRow = currentRow - 1;
                    possibleNextCol = currentCol;
                    if (possibleNextRow < 0)
                    {
                        canContinueInSameDirection = false;
                    }
                    else
                    {
                        testIfTrackIsZero = possibleNextRow * byteLength + possibleNextCol;
                        if (((track >> testIfTrackIsZero) & 1) == 0)
                        {
                            canContinueInSameDirection = true;
                        }
                    }
                    break;
                case "leftAfterDown":
                case "leftAfterUp":
                    possibleNextRow = currentRow;
                    possibleNextCol = currentCol + 1;
                    if (possibleNextCol > byteLength - 1)
                    {
                        canContinueInSameDirection = false;
                    }
                    else
                    {
                        testIfTrackIsZero = possibleNextRow * byteLength + possibleNextCol;
                        if (((track >> testIfTrackIsZero) & 1) == 0)
                        {
                            canContinueInSameDirection = true;
                        }
                    }
                    break;
                default:
                    break;
            }

            if (canContinueInSameDirection)
            {
                currentRow = possibleNextRow;
                currentCol = possibleNextCol;
                //previousDirection = currentDirection;
            }
            else
            {
                //We must make a turn
                switch (currentDirection)
                {
                    case "down":
                        //We try to turn left
                        possibleNextRow = currentRow;
                        possibleNextCol = currentCol + 1;
                        testIfTrackIsZero = possibleNextRow * byteLength + possibleNextCol;
                        if (((track >> testIfTrackIsZero) & 1) == 0 && possibleNextCol < byteLength)
                        {
                            currentDirection = "leftAfterDown";
                        }
                        else
                        {
                            trackIsFinished = false;
                            trackCanContinue = false;
                        }
                        break;
                    case "leftAfterDown":
                        //We try to go up
                        possibleNextRow = currentRow - 1;
                        possibleNextCol = currentCol;
                        testIfTrackIsZero = possibleNextRow * byteLength + possibleNextCol;
                        if (((track >> testIfTrackIsZero) & 1) == 0 && possibleNextRow >= 0)
                        {
                            currentDirection = "up";
                        }
                        else
                        {
                            trackIsFinished = false;
                            trackCanContinue = false;
                        }
                        break;
                    case "up":
                        //We try to go left
                        possibleNextRow = currentRow;
                        possibleNextCol = currentCol + 1;
                        testIfTrackIsZero = possibleNextRow * byteLength + possibleNextCol;
                        if (((track >> testIfTrackIsZero) & 1) == 0 && possibleNextCol < byteLength)
                        {
                            currentDirection = "leftAfterUp";
                        }
                        else
                        {
                            trackIsFinished = false;
                            trackCanContinue = false;
                        }
                        break;
                    case "leftAfterUp":
                        //we try to go down
                        possibleNextRow = currentRow + 1;
                        possibleNextCol = currentCol;
                        testIfTrackIsZero = possibleNextRow * byteLength + possibleNextCol;
                        if (((track >> testIfTrackIsZero) & 1) == 0 && possibleNextRow < byteLength)
                        {
                            currentDirection = "down";
                        }
                        else
                        {
                            trackIsFinished = false;
                            trackCanContinue = false;
                        }
                        break;
                    default:
                        break;
                }
                currentRow = possibleNextRow;
                currentCol = possibleNextCol;
            }
        }

        if (trackIsFinished)
        {
            Console.WriteLine("{0} {1}", trackLength, turnsCount);

        }
        else
        {
            Console.WriteLine("No {0}", trackLength);
        }
    }
}