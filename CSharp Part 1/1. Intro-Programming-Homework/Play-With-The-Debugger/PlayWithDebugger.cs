//Problem 17.* Play with the Debugger in Visual Studio
//Write a program that prints at the console the numbers from 1 to 1000, each at a separate line.
//You might need to learn how to use loops (search in Internet).
//Set a breakpoint in the line, which prints the next number in the Visual Studio code editor. 
//Run the program through the debugger using the [F5] key. 
//When the debugger stops at the breakpoint trace the code execution with [F10] key.

using System;

class PlayWithDebugger
{
    static void Main()
    {
        Console.BufferHeight = 1001;
        for (int i = 1; i < 1001; i++)
        {
            Console.WriteLine(i);
        }
    }
}