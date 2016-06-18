namespace MobilePhoneDevice
{    
    class Start
    {
        static void Main()
        {
            GSMTest test = new GSMTest();
            test.GSMTesting();

            GSMCallHistoryTest callHistory = new GSMCallHistoryTest();
            callHistory.GSMCallHistoryTesting();
        }
    }
}