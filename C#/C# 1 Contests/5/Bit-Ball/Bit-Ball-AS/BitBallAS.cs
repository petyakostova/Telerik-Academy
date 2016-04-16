using System;

public class BitBallAS
{
    static void Main(string[] args)
    {
        short byteLength = 8;
        int topTeamScore = 0;
        int bottomTeamScore = 0;

        #region Read Top Team Players
        byte top0 = byte.Parse(Console.ReadLine());
        byte top1 = byte.Parse(Console.ReadLine());
        byte top2 = byte.Parse(Console.ReadLine());
        byte top3 = byte.Parse(Console.ReadLine());
        byte top4 = byte.Parse(Console.ReadLine());
        byte top5 = byte.Parse(Console.ReadLine());
        byte top6 = byte.Parse(Console.ReadLine());
        byte top7 = byte.Parse(Console.ReadLine());
        #endregion

        #region Read Bottom Team Players
        byte bottom0 = byte.Parse(Console.ReadLine());
        byte bottom1 = byte.Parse(Console.ReadLine());
        byte bottom2 = byte.Parse(Console.ReadLine());
        byte bottom3 = byte.Parse(Console.ReadLine());
        byte bottom4 = byte.Parse(Console.ReadLine());
        byte bottom5 = byte.Parse(Console.ReadLine());
        byte bottom6 = byte.Parse(Console.ReadLine());
        byte bottom7 = byte.Parse(Console.ReadLine());
        #endregion

        #region Check For Red Cards
        for (int i = 0; i < byteLength; i++)
        {
            if (((top0 >> i) & 1) == 1 &&
                ((bottom0 >> i) & 1) == 1)
            {
                top0 = (byte)(top0 & (~(1 << i)));
                bottom0 = (byte)(bottom0 & (~(1 << i)));
            }

            if (((top1 >> i) & 1) == 1 &&
                ((bottom1 >> i) & 1) == 1)
            {
                top1 = (byte)(top1 & (~(1 << i)));
                bottom1 = (byte)(bottom1 & (~(1 << i)));
            }

            if (((top2 >> i) & 1) == 1 &&
                ((bottom2 >> i) & 1) == 1)
            {
                top2 = (byte)(top2 & (~(1 << i)));
                bottom2 = (byte)(bottom2 & (~(1 << i)));
            }

            if (((top3 >> i) & 1) == 1 &&
                ((bottom3 >> i) & 1) == 1)
            {
                top3 = (byte)(top3 & (~(1 << i)));
                bottom3 = (byte)(bottom3 & (~(1 << i)));
            }

            if (((top4 >> i) & 1) == 1 &&
                ((bottom4 >> i) & 1) == 1)
            {
                top4 = (byte)(top4 & (~(1 << i)));
                bottom4 = (byte)(bottom4 & (~(1 << i)));
            }

            if (((top5 >> i) & 1) == 1 &&
                ((bottom5 >> i) & 1) == 1)
            {
                top5 = (byte)(top5 & (~(1 << i)));
                bottom5 = (byte)(bottom5 & (~(1 << i)));
            }

            if (((top6 >> i) & 1) == 1 &&
                ((bottom6 >> i) & 1) == 1)
            {
                top6 = (byte)(top6 & (~(1 << i)));
                bottom6 = (byte)(bottom6 & (~(1 << i)));
            }

            if (((top7 >> i) & 1) == 1 &&
                ((bottom7 >> i) & 1) == 1)
            {
                top7 = (byte)(top7 & (~(1 << i)));
                bottom7 = (byte)(bottom7 & (~(1 << i)));
            }
        }
        #endregion

        #region Perform Top Team Attacks
        for (int row = 0; row < byteLength; row++)
        {
            for (int col = 0; col < byteLength; col++)
            {
                switch (row)
                {
                    case (0):
                        if (((top0 >> col) & 1) == 1)
                        {
                            if ((((top1 | top2 | top3 | top4 | top5 | top6 | top7 | bottom1 | bottom2 | bottom3 | bottom4 | bottom5 | bottom6 | bottom7) >> col) & 1) == 0)
                            {
                                topTeamScore++;
                            }
                        }
                        break;
                    case (1):
                        if (((top1 >> col) & 1) == 1)
                        {
                            if ((((top2 | top3 | top4 | top5 | top6 | top7 | bottom2 | bottom3 | bottom4 | bottom5 | bottom6 | bottom7) >> col) & 1) == 0)
                            {
                                topTeamScore++;
                            }
                        }
                        break;
                    case (2):
                        if (((top2 >> col) & 1) == 1)
                        {
                            if ((((top3 | top4 | top5 | top6 | top7 | bottom3 | bottom4 | bottom5 | bottom6 | bottom7) >> col) & 1) == 0)
                            {
                                topTeamScore++;
                            }
                        }
                        break;
                    case (3):
                        if (((top3 >> col) & 1) == 1)
                        {
                            if ((((top4 | top5 | top6 | top7 | bottom4 | bottom5 | bottom6 | bottom7) >> col) & 1) == 0)
                            {
                                topTeamScore++;
                            }
                        }
                        break;
                    case (4):
                        if (((top4 >> col) & 1) == 1)
                        {
                            if ((((top5 | top6 | top7 | bottom5 | bottom6 | bottom7) >> col) & 1) == 0)
                            {
                                topTeamScore++;
                            }
                        }
                        break;
                    case (5):
                        if (((top5 >> col) & 1) == 1)
                        {
                            if ((((top6 | top7 | bottom6 | bottom7) >> col) & 1) == 0)
                            {
                                topTeamScore++;
                            }
                        }
                        break;
                    case (6):
                        if (((top6 >> col) & 1) == 1)
                        {
                            if ((((top7 | bottom7) >> col) & 1) == 0)
                            {
                                topTeamScore++;
                            }
                        }
                        break;
                    case (7):
                        if (((top7 >> col) & 1) == 1)
                        {
                            topTeamScore++;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region Perform Bottom Team Attacks
        for (int row = byteLength - 1; row >= 0; row--)
        {
            for (int col = 0; col < byteLength; col++)
            {
                switch (row)
                {
                    case (7):
                        if (((bottom7 >> col) & 1) == 1)
                        {
                            if ((((top6 | top5 | top4 | top3 | top2 | top1 | top0 | bottom6 | bottom5 | bottom4 | bottom3 | bottom2 | bottom1 | bottom0) >> col) & 1) == 0)
                            {
                                bottomTeamScore++;
                            }
                        }
                        break;
                    case (6):
                        if (((bottom6 >> col) & 1) == 1)
                        {
                            if ((((top5 | top4 | top3 | top2 | top1 | top0 | bottom5 | bottom4 | bottom3 | bottom2 | bottom1 | bottom0) >> col) & 1) == 0)
                            {
                                bottomTeamScore++;
                            }
                        }
                        break;
                    case (5):
                        if (((bottom5 >> col) & 1) == 1)
                        {
                            if ((((top4 | top3 | top2 | top1 | top0 | bottom4 | bottom3 | bottom2 | bottom1 | bottom0) >> col) & 1) == 0)
                            {
                                bottomTeamScore++;
                            }
                        }
                        break;
                    case (4):
                        if (((bottom4 >> col) & 1) == 1)
                        {
                            if ((((top3 | top2 | top1 | top0 | bottom3 | bottom2 | bottom1 | bottom0) >> col) & 1) == 0)
                            {
                                bottomTeamScore++;
                            }
                        }
                        break;
                    case (3):
                        if (((bottom3 >> col) & 1) == 1)
                        {
                            if ((((top2 | top1 | top0 | bottom2 | bottom1 | bottom0) >> col) & 1) == 0)
                            {
                                bottomTeamScore++;
                            }
                        }
                        break;
                    case (2):
                        if (((bottom2 >> col) & 1) == 1)
                        {
                            if ((((top1 | top0 | bottom1 | bottom0) >> col) & 1) == 0)
                            {
                                bottomTeamScore++;
                            }
                        }
                        break;
                    case (1):
                        if (((bottom1 >> col) & 1) == 1)
                        {
                            if ((((top0 | bottom0) >> col) & 1) == 0)
                            {
                                bottomTeamScore++;
                            }
                        }
                        break;
                    case (0):
                        if (((bottom0 >> col) & 1) == 1)
                        {
                            bottomTeamScore++;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region Print Final Score
        Console.WriteLine("{0}:{1}", topTeamScore, bottomTeamScore);
        #endregion
    }
}