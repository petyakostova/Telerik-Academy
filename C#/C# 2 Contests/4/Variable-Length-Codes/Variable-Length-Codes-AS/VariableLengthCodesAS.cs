namespace Variable_Length_Codes_AS
{
    using System;
    //using System.IO; // StreamReader
    using System.Text; // StringBuilder

    class VariableLengthCodesAS
    {
        static void Main()
        {
            //using (StreamReader reader = new StreamReader("input.txt"))
            //{
            //string firstLine = reader.ReadLine();
            string encodedText = Console.ReadLine();

            string[] encodedStrings = encodedText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            byte[] encodedNumbers = new byte[encodedStrings.Length];

            for (int i = 0; i < encodedNumbers.Length; i++)
            {
                encodedNumbers[i] = byte.Parse(encodedStrings[i]);
            }

            StringBuilder binaryEncodedText = new StringBuilder();

            foreach (var number in encodedNumbers)
            {
                binaryEncodedText.Append(
                    Convert.ToString(number, 2).PadLeft(8, '0')
                    );
            }

            string[] encodedSymbols = binaryEncodedText.ToString().Split(new char[] { '0' }, StringSplitOptions.RemoveEmptyEntries);

            //int codeTableSize = int.Parse(reader.ReadLine());
            int codeTableSize = int.Parse(Console.ReadLine());

            char[] symbolPerCodeLength = new char[codeTableSize + 1];
            for (int i = 0; i < codeTableSize; i++)
            {
                //string currentCodePair = reader.ReadLine();
                string currentCodePair = Console.ReadLine();
                char symbol = currentCodePair[0];
                int codeLength = int.Parse(currentCodePair.Substring(1));

                symbolPerCodeLength[codeLength] = symbol;
            }

            for (int i = 0; i < encodedSymbols.Length; i++)
            {
                var codedSymbol = encodedSymbols[i];
                Console.Write(symbolPerCodeLength[codedSymbol.Length]);
            }

            Console.WriteLine();
            //}

        }
    }
}