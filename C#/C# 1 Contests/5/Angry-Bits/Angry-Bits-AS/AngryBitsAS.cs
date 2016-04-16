using System;

public class AngryBitsAS
{
    static void Main(string[] args)
    {
        int byteLength = 8;
        int shortLength = 16;
        int totalScore = 0;

        ushort field0; ushort field1; ushort field2; ushort field3;
        ushort field4; ushort field5; ushort field6; ushort field7;
        long one = 1L;

        field0 = ushort.Parse(Console.ReadLine());
        field1 = ushort.Parse(Console.ReadLine());
        field2 = ushort.Parse(Console.ReadLine());
        field3 = ushort.Parse(Console.ReadLine());
        field4 = ushort.Parse(Console.ReadLine());
        field5 = ushort.Parse(Console.ReadLine());
        field6 = ushort.Parse(Console.ReadLine());
        field7 = ushort.Parse(Console.ReadLine());

        long upperField = 0L;
        upperField |= field3; upperField <<= shortLength;
        upperField |= field2; upperField <<= shortLength;
        upperField |= field1; upperField <<= shortLength;
        upperField |= field0;

        long lowerField = 0L;
        lowerField |= field7; lowerField <<= shortLength;
        lowerField |= field6; lowerField <<= shortLength;
        lowerField |= field5; lowerField <<= shortLength;
        lowerField |= field4;

        bool isBird = false;
        for (int col = 0; col < byteLength; col++)
        {
            for (int row = 0; row < byteLength; row++)
            {
                //Search for a bird
                if (row < (byteLength / 2))
                {
                    int bytesToShift = (row * shortLength) + (byteLength + col);
                    isBird = ((upperField >> bytesToShift) & 1) == 1;
                    upperField &= (~(one << bytesToShift));
                }
                else
                {
                    int bytesToShift = ((row % 4) * shortLength) + (byteLength + col);
                    isBird = ((lowerField >> bytesToShift) & 1) == 1;
                    lowerField &= (~(one << bytesToShift));
                }

                if (isBird)
                {
                    int currentRow = row;
                    int currentCol = col + byteLength;
                    int flightLength = 0;
                    bool isAttackUpwards = true;
                    bool isHit = false;

                    //Perform attack
                    while (isHit == false)
                    {
                        if (currentRow == 0)
                        {
                            isAttackUpwards = false;
                        }

                        int possibleNextRow = isAttackUpwards ? currentRow - 1 : currentRow + 1;
                        int possibleNextCol = currentCol - 1;

                        //Is the bird in the bounds of the field
                        if (possibleNextRow >= byteLength || possibleNextCol < 0)
                        {
                            break;
                        }

                        currentRow = possibleNextRow;
                        currentCol = possibleNextCol;
                        flightLength++;

                        if (currentRow < (byteLength / 2))
                        {
                            int bytesToShift = (currentRow * shortLength) + currentCol;
                            if (((upperField >> bytesToShift) & 1) == 1)
                            {
                                isHit = true;
                                upperField &= (~(one << bytesToShift));
                            }
                        }
                        else
                        {
                            int bytesToShift = ((currentRow % 4) * shortLength) + currentCol;
                            if (((lowerField >> bytesToShift) & 1) == 1)
                            {
                                isHit = true;
                                lowerField &= (~(one << bytesToShift));
                            }
                        }

                        if (isHit)
                        {
                            break;
                        }
                    }

                    if (isHit)
                    {
                        //Count bird hits
                        int birdHits = 1;

                        int checkedRow = currentRow - 1;
                        int checkedCol = currentCol;

                        if (checkedRow >= 0)
                        {
                            int bytesToShift = ((checkedRow % 4) * shortLength) + checkedCol;
                            if (checkedRow < (byteLength / 2))
                            {
                                if (((upperField >> bytesToShift) & 1) == 1)
                                {
                                    birdHits++;
                                    upperField &= (~(one << bytesToShift));
                                }
                            }
                            else
                            {
                                if (((lowerField >> bytesToShift) & 1) == 1)
                                {
                                    birdHits++;
                                    lowerField &= (~(one << bytesToShift));
                                }
                            }
                        }

                        checkedRow = currentRow - 1;
                        checkedCol = currentCol + 1;
                        if (checkedRow >= 0 && checkedCol < byteLength)
                        {
                            int bytesToShift = ((checkedRow % 4) * shortLength) + checkedCol;
                            if (checkedRow < (byteLength / 2))
                            {
                                if (((upperField >> bytesToShift) & 1) == 1)
                                {
                                    birdHits++;
                                    upperField &= (~(one << bytesToShift));
                                }
                            }
                            else
                            {
                                if (((lowerField >> bytesToShift) & 1) == 1)
                                {
                                    birdHits++;
                                    lowerField &= (~(one << bytesToShift));
                                }
                            }
                        }

                        checkedRow = currentRow - 1;
                        checkedCol = currentCol - 1;
                        if (checkedRow >= 0 && checkedCol >= 0)
                        {
                            int bytesToShift = ((checkedRow % 4) * shortLength) + checkedCol;
                            if (checkedRow < (byteLength / 2))
                            {
                                if (((upperField >> bytesToShift) & 1) == 1)
                                {
                                    birdHits++;
                                    upperField &= (~(one << bytesToShift));
                                }
                            }
                            else
                            {
                                if (((lowerField >> bytesToShift) & 1) == 1)
                                {
                                    birdHits++;
                                    lowerField &= (~(one << bytesToShift));
                                }
                            }
                        }

                        checkedRow = currentRow;
                        checkedCol = currentCol - 1;
                        if (checkedCol >= 0)
                        {
                            int bytesToShift = ((checkedRow % 4) * shortLength) + checkedCol;
                            if (checkedRow < (byteLength / 2))
                            {
                                if (((upperField >> bytesToShift) & 1) == 1)
                                {
                                    birdHits++;
                                    upperField &= (~(one << bytesToShift));
                                }
                            }
                            else
                            {
                                if (((lowerField >> bytesToShift) & 1) == 1)
                                {
                                    birdHits++;
                                    lowerField &= (~(one << bytesToShift));
                                }
                            }
                        }

                        checkedRow = currentRow + 1;
                        checkedCol = currentCol - 1;
                        if (checkedRow < byteLength && checkedCol >= 0)
                        {
                            int bytesToShift = ((checkedRow % 4) * shortLength) + checkedCol;
                            if (checkedRow < (byteLength / 2))
                            {
                                if (((upperField >> bytesToShift) & 1) == 1)
                                {
                                    birdHits++;
                                    upperField &= (~(one << bytesToShift));
                                }
                            }
                            else
                            {
                                if (((lowerField >> bytesToShift) & 1) == 1)
                                {
                                    birdHits++;
                                    lowerField &= (~(one << bytesToShift));
                                }
                            }
                        }

                        checkedRow = currentRow + 1;
                        checkedCol = currentCol;
                        if (checkedRow < byteLength)
                        {
                            int bytesToShift = ((checkedRow % 4) * shortLength) + checkedCol;
                            if (checkedRow < (byteLength / 2))
                            {
                                if (((upperField >> bytesToShift) & 1) == 1)
                                {
                                    birdHits++;
                                    upperField &= (~(one << bytesToShift));
                                }
                            }
                            else
                            {
                                if (((lowerField >> bytesToShift) & 1) == 1)
                                {
                                    birdHits++;
                                    lowerField &= (~(one << bytesToShift));
                                }
                            }
                        }

                        checkedRow = currentRow + 1;
                        checkedCol = currentCol + 1;
                        if (checkedRow < byteLength && checkedCol < byteLength)
                        {
                            int bytesToShift = ((checkedRow % 4) * shortLength) + checkedCol;
                            if (checkedRow < (byteLength / 2))
                            {
                                if (((upperField >> bytesToShift) & 1) == 1)
                                {
                                    birdHits++;
                                    upperField &= (~(one << bytesToShift));
                                }
                            }
                            else
                            {
                                if (((lowerField >> bytesToShift) & 1) == 1)
                                {
                                    birdHits++;
                                    lowerField &= (~(one << bytesToShift));
                                }
                            }
                        }

                        checkedRow = currentRow;
                        checkedCol = currentCol + 1;
                        if (checkedCol < byteLength)
                        {
                            int bytesToShift = ((checkedRow % 4) * shortLength) + checkedCol;
                            if (checkedRow < (byteLength / 2))
                            {
                                if (((upperField >> bytesToShift) & 1) == 1)
                                {
                                    birdHits++;
                                    upperField &= (~(one << bytesToShift));
                                }
                            }
                            else
                            {
                                if (((lowerField >> bytesToShift) & 1) == 1)
                                {
                                    birdHits++;
                                    lowerField &= (~(one << bytesToShift));
                                }
                            }
                        }
                        totalScore += (flightLength * birdHits);
                    }
                }
            }
        }

        bool isPassed = true;
        if (upperField > 0 || lowerField > 0)
        {
            isPassed = false;
        }
        Console.WriteLine("{0} {1}", totalScore, isPassed ? "Yes" : "No");
    }
}