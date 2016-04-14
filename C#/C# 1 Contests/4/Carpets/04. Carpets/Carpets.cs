/* Logic:
   Fill all with '.' (dots).
   Split the image into 4 parts. 
   Go with the first part and modify it. Using symmetry modify and the remaining 3 parts.
   Note where should '/' begin (n/2 - 1) and modify the start for the lines down (--).
   Note where '/' end (n/2 - 1) => the vertical red line
*/
using System;

class Carpets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        int startSlash = n / 2 - 1; 
        int endSlash = n / 2 - 1;   

        bool isSlash = true; // every line we start with '/'; then is ' ' => alternate/rotate

        for (int row = 0; row < n / 2; row++)
        {
            for (int col = 0; col < n / 2; col++)
            {
                if (startSlash <= col && col <= endSlash)
                {
                    if (isSlash)
                    {
                        matrix[row, col] = 2;                 // '/'  for the first part
                        matrix[row, n - 1 - col] = 3;         // '\\' for the second part
                        matrix[n - 1 - row, col] = 3;         // '\\' for the third part
                        matrix[n - 1 - row, n - 1 - col] = 2; // '/'  for the fourth part
                        isSlash = false;
                    }
                    else
                    {
                        // for the whitespaces in the four parts
                        matrix[row, col] = 1;
                        matrix[row, n - 1 - col] = 1;
                        matrix[n - 1 - row, col] = 1;
                        matrix[n - 1 - row, n - 1 - col] = 1;
                        isSlash = true;
                    }
                }
            }

            isSlash = true; //on every new line first go '/'
            startSlash--; // modify the condition for starting Slash for the next line
        }

        //printing
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write('.');
                }
                else if (matrix[row, col] == 1)
                {
                    Console.Write(' ');
                }
                else if (matrix[row, col] == 2)
                {
                    Console.Write('/');
                }
                else if (matrix[row, col] == 3)
                {
                    Console.Write('\\');
                }
            }
            Console.WriteLine();
        }
    }
}