/*  7. Write a class GSMTest to test the GSM class:
    Create an array of few instances of the GSM class.
    Display the information about the GSMs in the array.
    Display the information about the static property IPhone4S.
*/

namespace MobilePhoneDevice
{
    using System;

    public class GSMTest
    {
        public void GSMTesting()
        {
            GSM instance1 = new GSM("Nokia", "Connecting People", 140000, "HappyOwner", 
                new Battery("BestBatteryEVER", 1000, 10000, Battery.Type.AlienTech), new Display(1000, 1000, 16000000));

            GSM instance2 = new GSM("Kia", "Thailand");

            GSM instance3 = new GSM("Somebrand", "SomeManufacturer", 100, "Az", new Battery(), new Display());

            GSM[] testAll = new GSM[] { instance1, instance2, instance3 };

            foreach (var gsm in testAll)
            {
                Console.WriteLine(gsm);
            }

            Console.WriteLine(GSM.IPhone4S);
        }
    }
}