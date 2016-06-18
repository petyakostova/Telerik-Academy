namespace MobilePhoneDevice
{    
    class Start
    {
        static void Main()
        {
            var test = new GSMTest();
            test.GSMTesting();

            var callHistory = new GSMCallHistoryTest();
            callHistory.GSMCallHistoryTesting();
        }
    }
}