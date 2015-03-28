namespace Document_System
{
    class DocumentSystem
    {
        static void Main()
        {
            Document doc = new Document("Petya", "I will be an excellent software ingeneer.");
            System.Console.WriteLine(doc.Information());

            BinaryDocument bDoc = new BinaryDocument("Petya", "I will be an excellent software ingeneer.", 2000);
            System.Console.WriteLine(bDoc.Information());

            WordDocument wDoc = new WordDocument("Petya", "I will be an excellent software ingeneer.", 2000, "2015", 1000);
            System.Console.WriteLine(wDoc.Information());
        }
    } 
}
