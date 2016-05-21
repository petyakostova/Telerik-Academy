/*  HTML:   text<tag>text<tag>text...
    get only text
 */

using System;
using System.Text;

class Automata
{
    static void Main()
    {
        string str = "ab<tt>c def<tag>jhi";

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
                    continue; // goes to the next symbol
                }
            }
        }

        Console.WriteLine(sb.ToString()); //abc defjhi
    }
}