namespace _02.Bunny_Factory
{
    using System;
    using System.Collections.Generic; // List<int>
    using System.Linq; // Where
    using System.Numerics; // BigInteger

    class BunnyFactory
    {
        static void Main()
        {
            //Some of the calculations during the multiplication process will have more than 20 digits => BigInteger

            List<int> cages = Input();

            // no condition because we don't know how many steps will have
            for (int stepNumber = 1; ; stepNumber++)    
            {
                //1. If there are less than i cages, the factory stops the multiplication process.
                if (cages.Count < stepNumber)
                {
                    break;
                }

                // 2. The factory gets the first i cages and calculate the sum s of all bunnies in them. 
                // when stepNumber is 1, we want to take 0 element so the endIndex = stepNumber - 1
                var firstCagesSum = (int)SumListValuesInRange(cages, 0, stepNumber - 1);

                /* 3. If there are less than s(firstCagesSum) cages after the i-th one, 
                      the factory stops the multiplication process. */
                if (cages.Count - stepNumber < firstCagesSum)
                {
                    break;
                }

                /* 4. The factory gets the next s cages after the i-th one and 
                      calculates the sum and product of all bunnies in them. */
                var sum = SumListValuesInRange(cages, stepNumber, firstCagesSum + stepNumber - 1);
                var product = ProductListValuesInRange(cages, stepNumber, firstCagesSum + stepNumber - 1);

                /* 5. These sum and product are concatenated as next cages. 
                      All cages that were not included in the calculations are simply appended to next.*/
                string result = sum.ToString() + product.ToString();
                for (int i = firstCagesSum + stepNumber; i < cages.Count; i++)
                {
                    result += cages[i];
                }

                /* 6. The factory gets several empty cages then gets the digits of next and 
                        for each digit puts the same amount of bunnies in each cell. 
                        If the digit is 1 or 0, the digit is ignored.*/

                // first way
                var newCages = new List<int>();
                foreach (var ch in result)
                {
                    if (ch != '0' && ch != '1')
                    {
                        newCages.Add(ch - '0'); // convert symbol in number
                    }
                }
                cages = newCages;

                //second way
                //cages.Clear();
                //foreach (var ch in result)
                //{
                //    if (ch != '0' && ch != '1')
                //    {
                //        cages.Add(ch - '0'); // convert symbol in number
                //        //if (ch == '2')
                //        //{
                //        //    cages.Add(2);    // ect. (and so on) for 3,4,5,6,7,8,9  
                //        //}
                //    }
                //}

                // third way => Linq
                //cages = result
                //    .Where(x => x != '0' && x != '1')
                //    .Select(x => x - '0')
                //    .ToList();

                // 7. Step 1 is repeated for the newly generated cages with bunnies...
            }

            Console.WriteLine(string.Join(" ", cages));

        }

        static List<int> Input()
        {
            List<int> cages = new List<int>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                int cage = int.Parse(line);

                cages.Add(cage);
            }

            return cages;
        }

        // sum the elements of the list from startIndex to endIndex
        static BigInteger SumListValuesInRange(List<int> list, int startIndex, int endIndex)   
        {
            BigInteger sum = 0;

            for (int i = startIndex; i <= endIndex; i++)
            {
                sum += list[i];
            }

            return sum;
        }

        //returns the product of the elements of the list in range [startIndex; endIndex]
        static BigInteger ProductListValuesInRange(List<int> list, int startIndex, int endIndex)    
        {
            BigInteger product = 1;

            for (int i = startIndex; i <= endIndex; i++)
            {
                product *= list[i];
            }

            return product;
        }
        
    }
}