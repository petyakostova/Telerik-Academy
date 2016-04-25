using System;
using System.Numerics;

class SaddyKopperWithStrings
{
    static void Main()
    {
        string strNum = Console.ReadLine();

        int transformations = 0;

        while (strNum.Length > 1 && transformations < 10)
        {
            BigInteger product = 1;
            while (strNum.Length > 0)
            {
                strNum = strNum.Substring(0, strNum.Length - 1); // step 2
                int sum = 0;
                for (int i = 0; i < strNum.Length; i += 2)
                {
                    sum += strNum[i] - '0';
                }


                if (sum != 0)
                {
                    product *= sum;
                }
                // other way
                // product *= sum != 0 ? sum : 1;   

            }

            transformations++;
            strNum = product.ToString();
        }

        // output
        if (transformations < 10)
        {
            Console.WriteLine(transformations);

        }
        Console.WriteLine(strNum);

    }
}