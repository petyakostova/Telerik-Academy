/* 12.  Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
        Create an instance of the GSM class.
        Add few calls.
        Display the information about the calls.
        Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
        Remove the longest call from the history and calculate the total price again.
        Finally clear the call history and print it.
*/

namespace MobilePhoneDevice
{
    using System;

    class GSMCallHistoryTest
    {
        public void GSMCallHistoryTesting()
        {
            // Create an instance of the GSM class.
            GSM testGsm = new GSM("Nokia", "TelerikCorp");

            // Add few calls.
            testGsm.AddCall("+359873432142", 53);
            testGsm.AddCall("+359811432142", 123);
            testGsm.AddCall("+359872412142", 41);
            testGsm.AddCall("+359833332142", 72);
            testGsm.AddCall("+359614432142", 231);

            // Display the information about the calls.
            testGsm.ShowCallHistory();

            // Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
            Console.WriteLine("Total call price: " + testGsm.TotalCallPrice());

            //  Remove the longest call from the history and calculate the total price again.
            testGsm.DeleteCall(5);
            Console.WriteLine("Removed Longest call!");
            Console.WriteLine("Total call price: " + testGsm.TotalCallPrice());

            // Clear the call history and print it.
            testGsm.ClearCallHistory();
            Console.WriteLine("Cleared call history!");
            testGsm.ShowCallHistory();
        }
    }
}