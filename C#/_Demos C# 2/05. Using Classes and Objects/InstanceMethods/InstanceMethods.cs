using System;

class InstanceMethods
{
    static void Main()
    {
        String sampleLower = new String('a', 5);
        String sampleUpper = sampleLower.ToUpper();

        Console.WriteLine(sampleLower); // aaaaa
        Console.WriteLine(sampleUpper); // AAAAA

        DateTime now = DateTime.Now;    
        DateTime later = now.AddHours(8);   

        Console.WriteLine("Now: {0}", now);// Now: 25.5.2016 ã. 3:35:19
        Console.WriteLine("8 hours later: {0}", later);// 8 hours later: 25.5.2016 ã. 11:35:19
    }
}