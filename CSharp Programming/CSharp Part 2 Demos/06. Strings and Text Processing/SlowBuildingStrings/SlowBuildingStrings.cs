using System;

class SlowBuildingStrings
{
    public static string DupChar(char ch, int count)
    {
        string result = "";
        for (int i = 0; i < count; i++)
        {
            result += ch;
        }
        return result;
    }

    static void Main()
    {
        DateTime startTime = DateTime.Now;
		Console.WriteLine("Concatenation 50 000 chars...");
		DupChar('a', 50000);
		DateTime endTime = DateTime.Now;
		Console.WriteLine("... done in {0} seconds", endTime - startTime);
        //Concatenation 50 000 chars...
        //... done in 00:00:02.5301447 seconds

        startTime = DateTime.Now;
		Console.WriteLine("Concatenation 200 000 chars...");
		DupChar('a', 200000);
        endTime = DateTime.Now;
		Console.WriteLine("... done in {0} seconds", endTime - startTime);
        //Concatenation 200 000 chars...
        //... done in 00:00:51.1859276 seconds

	}
}
