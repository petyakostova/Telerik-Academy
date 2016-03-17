using System;

class BinarySearch
{
    static Random rand = new Random();

    static void Main()
    {
        string[] beers =
        {
            "Zagorka", "Ariana", "Shumensko", "Astika",
            "Kamenitza", "Bolyarka", "Amstel"
        };
        Array.Sort(beers);

        string target = "Astika";
        int index = Array.BinarySearch(beers, target);
        Console.WriteLine("{0} is found at index {1}.", target, index);
        //// Result: Astika is found at index 2.

        target = "Heineken";
        index = Array.BinarySearch(beers, target);
        Console.WriteLine("{0} is not found (index={1}).", target, index);
        //// Result: Heineken is not found (index=-5).
    }
}