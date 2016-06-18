namespace MobilePhoneDevice
{
    using System;

    /*  7. Write a class GSMTest to test the GSM class:
        Create an array of few instances of the GSM class.
        Display the information about the GSMs in the array.
        Display the information about the static property IPhone4S. */
    class Tester
    {
        static void Main()
        {
            GSMTest();

            GSMCallHistoryTest();
        }

        private static void GSMCallHistoryTest()
        {
            GSM testGsm = new GSM("Nokia", "TelerikCorp");

            testGsm.AddCall("+359873432142", 53);
            testGsm.AddCall("+359811432142", 123);
            testGsm.AddCall("+359872412142", 41);
            testGsm.AddCall("+359833332142", 72);
            testGsm.AddCall("+359614432142", 231);

            testGsm.ShowCallHistory();

            Console.WriteLine("Total call price: " + testGsm.TotalCallPrice());

            testGsm.DeleteCall(5);
            Console.WriteLine("Removed Longest call!");

            Console.WriteLine("Total call price: " + testGsm.TotalCallPrice());

            testGsm.ClearCallHistory();
            Console.WriteLine("Cleared call history!");
            testGsm.ShowCallHistory();
        }

        private static void GSMTest()
        {
            GSM test1 = new GSM("Nokia", "Connecting People", 140000
                , "HappyOwner", new Battery("BestBatteryEVER", 1000, 10000, Battery.Type.AlienTech), new Display(1000, 1000, 16000000));

            GSM test2 = new GSM("Kia", "Thailand");

            GSM test3 = new GSM("Somebrand", "SomeManufacturer", 100, "Az", new Battery(), new Display());

            GSM[] testAll = new GSM[] { test1, test2, test3 };

            foreach (var gsm in testAll)
            {
                Console.WriteLine(gsm);
            }

            Console.WriteLine(GSM.IPhone4S);
        }

    }
}
