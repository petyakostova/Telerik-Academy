namespace De_cat_coding_AS
{
    using System;
    using System.Text;

    class DeCatCodingAS
    {
        static void Main()
        {
            int inNumBase = 21;
            int outNumBase = 26;
            //new TestGenerator().GenerateTests(inNumBase, outNumBase);
            //return;

            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                ulong num = ConvertToDecimal(words[i], inNumBase);
                string newWord = ConvertToString(num, outNumBase);
                sb.AppendFormat("{0} ", newWord);
            }

            sb.Length--;
            Console.WriteLine(sb.ToString());
        }

        private static string ConvertToString(ulong num, int numBase)
        {
            string res = "";
            while (num != 0)
            {
                char ch = (char)((int)(num % (ulong)numBase) + 'a');
                res = ch + res;
                num /= (ulong)numBase;
            }

            return res;
        }

        private static ulong ConvertToDecimal(string word, int numBase)
        {
            ulong res = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char ch = word[word.Length - 1 - i];
                res += (ulong)((ch - 'a') * Math.Pow(numBase, i));
            }

            return res;
        }

    }
}