using System;

// AUTHOR'S SOLUTION FOR THE BIT TOWER OF DOOM
internal class BitTowerOfDoom
{
    private static void Main(string[] args)
    {
        int knightsTotalCount = 0; // ALL THE KNIGHTS THAT ARRIVED IN THE CHARIOTS
        int knightSurvivorsCount = 0; // ALL KNIGHTS THAT MADE IT TO THE END

        const int CHARIOT_SEATS_COUNT = 8;
        const int GAME_FIELD_WIDTH = 8;

        // SET OF COMMANDS
        const string END_COMMAND = "end";
        const string SELECT_COMMAND = "select";
        const string KILL_COMMAND = "kill";
        //const string MOVE_COMMAND = "move";

        int mask;

        // READING CHARIOTS AND FILLING IN THE FLOORS
        int floor0 = int.Parse(Console.ReadLine());
        int floor1 = int.Parse(Console.ReadLine());
        int floor2 = int.Parse(Console.ReadLine());
        int floor3 = int.Parse(Console.ReadLine());
        int floor4 = int.Parse(Console.ReadLine());
        int floor5 = int.Parse(Console.ReadLine());
        int floor6 = int.Parse(Console.ReadLine());
        int floor7 = int.Parse(Console.ReadLine());

        // COUNTING ALL THE CARRIED BITS
        for (int i = 0; i < CHARIOT_SEATS_COUNT; i++)
        {
            mask = 1 << i;

            if ((floor0 & mask) > 0)
            {
                knightsTotalCount++;
            }

            if ((floor1 & mask) > 0)
            {
                knightsTotalCount++;
            }

            if ((floor2 & mask) > 0)
            {
                knightsTotalCount++;
            }

            if ((floor3 & mask) > 0)
            {
                knightsTotalCount++;
            }

            if ((floor4 & mask) > 0)
            {
                knightsTotalCount++;
            }

            if ((floor5 & mask) > 0)
            {
                knightsTotalCount++;
            }

            if ((floor6 & mask) > 0)
            {
                knightsTotalCount++;
            }

            if ((floor7 & mask) > 0)
            {
                knightsTotalCount++;
            }
        }

        knightSurvivorsCount = knightsTotalCount;

        // EXECUTING BATTLE COMMANDS (MAIN GAME LOOP)
        while (true)
        {
            string command = Console.ReadLine();

            if (command == END_COMMAND) // GAME HAS ENDED
            {
                break;
            }

            bool select = command == SELECT_COMMAND;
            int currentFloorNumber = int.Parse(Console.ReadLine());
            int position = (GAME_FIELD_WIDTH - 1) - int.Parse(Console.ReadLine()); // SWITCH FROM TOWER COORDINATES TO BIT POSITION

            int currentFloor = 0;

            // GETING THE CURRENT FLOOR'S SITUATION
            switch (currentFloorNumber)
            {
                case 0:
                    currentFloor = floor0;
                    break;

                case 1:
                    currentFloor = floor1;
                    break;

                case 2:
                    currentFloor = floor2;
                    break;

                case 3:
                    currentFloor = floor3;
                    break;

                case 4:
                    currentFloor = floor4;
                    break;

                case 5:
                    currentFloor = floor5;
                    break;

                case 6:
                    currentFloor = floor6;
                    break;

                case 7:
                    currentFloor = floor7;
                    break;
            }

            mask = 1 << position; // POSITION THE MASK OVER THE BIT

            if (select)
            {
                currentFloor = currentFloor ^ mask; // SELECTS THE KNIGHT ("TAKES" THE BIT FROM IT'S POSITION)
            }
            else
            {
                if (position >= 0 && position < GAME_FIELD_WIDTH)
                {
                    bool defender = (currentFloor & mask) > 0;
                    bool kill = command == KILL_COMMAND;

                    if (defender) // IN ANY CASE ONE OF THE BITS DIES, DESN'T MATTER WHO
                    {
                        knightSurvivorsCount--;
                        continue;
                    }

                    bool leftDefender = false;
                    bool rightDefender = false;

                    // ATEMPT TO LOOK FOR A DEFENDER ON THE LEFT OF THE DESTINATION POSITION
                    if (position < GAME_FIELD_WIDTH - 1)
                    {
                        mask = 1 << (position + 1);
                        leftDefender = (currentFloor & mask) > 0;
                    }

                    // ATEMPT TO LOOK FOR A DEFENDER ON THE RIGHT OF THE DESTINATION POSITION
                    if (position > 0)
                    {
                        mask = 1 << (position - 1);
                        rightDefender = (currentFloor & mask) > 0;
                    }

                    // IF THERE ARE TWO DEFENDERS IN RANGE THE ATTACKER DIES FOR SURE
                    if (leftDefender && rightDefender)
                    {
                        knightSurvivorsCount--;
                        continue;
                    }

                    if (leftDefender)
                    {
                        if (kill) // BOTH ATTACKER AND DEFENDER DIE
                        {
                            mask = 1 << (position + 1);
                            currentFloor = currentFloor ^ mask;

                            knightSurvivorsCount -= 2;
                        }
                        else // MOVING KNIGHT DIES BY THE LEFT DEFENDER'S HANDS
                        {
                            knightSurvivorsCount--;
                        }
                    }
                    else if (rightDefender)
                    {
                        if (kill) // BOTH ATTACKER AND DEFENDER DIE
                        {
                            mask = 1 << (position - 1);
                            currentFloor = currentFloor ^ mask;

                            knightSurvivorsCount -= 2;
                        }
                        else // MOVING KNIGHT DIES BY THE RIGHT DEFENDER'S HANDS
                        {
                            knightSurvivorsCount--;
                        }
                    }
                    else // NO GUARDIANS WERE FOUND, THE ATTACKER MOVES TO THE DESTINATION AND STAIS THERE
                    {
                        mask = (1 << position);
                        currentFloor = currentFloor | mask;
                    }
                }
                else
                {
                    if (currentFloorNumber > 1)
                    {
                        knightSurvivorsCount--;
                    }
                }
            }

            // UPDATES THE CURRENT FLOOR
            switch (currentFloorNumber)
            {
                case 0:
                    floor0 = currentFloor;
                    break;

                case 1:
                    floor1 = currentFloor;
                    break;

                case 2:
                    floor2 = currentFloor;
                    break;

                case 3:
                    floor3 = currentFloor;
                    break;

                case 4:
                    floor4 = currentFloor;
                    break;

                case 5:
                    floor5 = currentFloor;
                    break;

                case 6:
                    floor6 = currentFloor;
                    break;

                case 7:
                    floor7 = currentFloor;
                    break;
            }
        }

        int sum = floor0 + floor1 + floor2 + floor3 + floor4 + floor5 + floor6 + floor7;

        // PRINTING OUTPUT
        Console.WriteLine(knightsTotalCount);
        Console.WriteLine(knightSurvivorsCount);
        Console.WriteLine(sum);
    }
}