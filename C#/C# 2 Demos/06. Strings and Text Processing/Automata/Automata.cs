/*  HTML:   text<tag>text<tag>text...
    get only text
 */

using System;
using System.Text;

class Automata
{
    static void Main()
    {
        string str = "ab<cd>e";

        StringBuilder sb = new StringBuilder(); // for adding the text

        bool isInState = false;
        bool isOutState = true;
        
        foreach (var ch in str)
        {
            if (isOutState)
            {                
                if (ch == '<')
                {
                    isInState = true;
                    isOutState = false;
                }                
                else
                {
                    sb.Append(ch);
                }
            }
            else if (isInState)
            {
                if (ch == '>')
                {
                    isOutState = true;
                    isInState = false;
                }
                else
                {
                    continue;   // преминава на следващия символ
                }
            }
        }
        Console.WriteLine(sb.ToString());

    }
}