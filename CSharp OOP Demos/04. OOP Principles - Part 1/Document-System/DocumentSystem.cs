namespace Document_System
{
    using System;
    using System.Collections.Generic;

    class DocumentSystem
    {
        static void Main()
        {
            // creating this doc is not ok, because it's not clear what type is it,
            // so we make the class Document abstract and it can't be inicialize already
            //Document doc = new Document("Petya", "I will be an excellent software ingeneer.");
            //System.Console.WriteLine(doc.Information());

            //BinaryDocument bDoc = new BinaryDocument("Petya", "I will be an excellent software ingeneer.", 2000);
            //System.Console.WriteLine(bDoc.Information());

            WordDocument wDoc = new WordDocument("Petya", "I will be an excellent software ingeneer.", 2000, "2015", 1000);
            //System.Console.WriteLine(wDoc.Information());

            // interfaces can not be instantiated
            //IDocument iDoc = new IDocument();

            //IDocument iDoc = new BinaryDocument("Jordan", 1000);
            //Console.WriteLine(iDoc.Name);
        }

        // higher level of abstraction
        static void PrintDocuments(IEnumerable<IDocument> documents)    // instead of List<Document>
        {
            foreach (var doc in documents)
            {
                Console.WriteLine(doc.Name);
                Console.WriteLine(doc.GetInformation());
            }
        }
    } 
}
