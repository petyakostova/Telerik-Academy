using System;

class TypeConversions
{
	static void Main()
	{
		float heightInMeters = 1.74f; // Explicit conversion => 1,74

        double maxHeight = heightInMeters; // Implicit conversion => 1,74000000953674
        double minHeight = (double) heightInMeters; // Explicit conversion (not required) => 1,74000000953674

        float actualHeight = (float) maxHeight; // Explicit conversion => 1,74

        //float maxHeightFloat = maxHeight; // Compilation error!

        int numberOfClients = 10;
		object numberOfThings = numberOfClients;
		// The following type casting is allowed because
		// numberOfThings actually contains int value 
		int numberOfSellers = (int) numberOfThings;         //10
		
		// The following would not cause a compilation error
		// but during run-time will break the program:
		//double sellingPrice = (double)numberOfThings;

		Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}",
			heightInMeters, maxHeight, minHeight, actualHeight,
			numberOfClients, numberOfSellers);        
    }
}