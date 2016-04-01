using System;
using System.IO;

class FixingMovieSubtitles
{
    const int COEFFICIENT = 2;
    const int ADDITION = 5000;
    const string INPUT_FILE = @"..\..\source.sub";
    const string OUTPUT_FILE = @"..\..\fixed.sub";
	
    static void Main()
    {
        try
        {
            // Getting Cyrillic encoding 
            System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(1251);
			
            // Create reader with the Cyrillic encoding
            StreamReader streamReader = new StreamReader(INPUT_FILE, encoding);
            // Create writer with the Cyrillic encoding
            StreamWriter streamWriter = new StreamWriter(OUTPUT_FILE, false, encoding);
            try
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    streamWriter.WriteLine(FixLine(line));
                }
            }
            finally
            {
                streamReader.Close();
                streamWriter.Close();
            }
        }
        catch (System.Exception exc)
        {
            Console.WriteLine(exc.Message);
        }
    }

    static string FixLine(string line)
    {
        // Find closing brace
        int bracketFromIndex = line.IndexOf('}');

        // Extract 'from' time
        string fromTimeStr = line.Substring(1, bracketFromIndex - 1);
        int fromTime = Convert.ToInt32(fromTimeStr);

        // Calculate new 'from' time
        int newFromTime = fromTime * COEFFICIENT + ADDITION;

        // Find the following closing brace
        int bracketToIndex = line.IndexOf('}', bracketFromIndex + 1);

        // Extract 'to' time
        string toTimeStr = line.Substring(bracketFromIndex + 2, 
                                          bracketToIndex - bracketFromIndex - 2);
        int toTime = Convert.ToInt32(toTimeStr);

        // Calculate new 'to' time
        int newToTime = toTime * COEFFICIENT + ADDITION;

        // Create a new line using the new 'from' and 'to' times
        string fixedLine = "{" + newFromTime + "}" + "{" + newToTime + "}" + 
                           line.Substring(bracketToIndex + 1);

        return fixedLine;
    }
}
