namespace TestGenerator
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    internal class Program
    {
        private const string FileNameFormat = "test.{0:000}.in.txt";

        // n, m (1...1000), k (0...10000)
        private static readonly List<Tuple<int, int, int>> Tests = new List<Tuple<int, int, int>>
                                                         {
                                                             ////       n    m    k
                                                             new Tuple<int, int, int>(1, 1, 0), // 1
                                                             new Tuple<int, int, int>(5, 6, 200), // 2
                                                             new Tuple<int, int, int>(8, 10, 400), // 3
                                                             new Tuple<int, int, int>(20, 16, 10000), // 4
                                                             new Tuple<int, int, int>(30, 38, 2), // 5
                                                             new Tuple<int, int, int>(50, 78, 1000), // 6
                                                             new Tuple<int, int, int>(100, 200, 10000), // 7
                                                             new Tuple<int, int, int>(200, 300, 60000), // 8
                                                             new Tuple<int, int, int>(500, 500, 10000), // 9
                                                             new Tuple<int, int, int>(800, 300, 70000), // 10
                                                             new Tuple<int, int, int>(40, 1000, 10000), // 11
                                                             new Tuple<int, int, int>(1000, 40, 10000), // 12
                                                             new Tuple<int, int, int>(1250, 1200, 80000), // 13
                                                             new Tuple<int, int, int>(1500, 1500, 40000), // 14
                                                             new Tuple<int, int, int>(1500, 1500, 29000), // 15
                                                             new Tuple<int, int, int>(2000, 2000, 50000), // 16
                                                             new Tuple<int, int, int>(2000, 2000, 100000), // 17
                                                             new Tuple<int, int, int>(2000, 2000, 1337), // 18
                                                             new Tuple<int, int, int>(2000, 2000, 100000), // 19
                                                             new Tuple<int, int, int>(2000, 2000, 100000), // 20
                                                         };

        private static void Main()
        {
            var rand = new Random();
            for (var i = 1; i <= Tests.Count; i++)
            {
                var test = Tests[i - 1];
                var fileName = string.Format(FileNameFormat, i);
                using (var sw = new StreamWriter(fileName))
                {
                    sw.WriteLine("{0} {1}", test.Item1, test.Item2);
                    sw.WriteLine("{0}", test.Item3);
                    for (int j = 0; j < test.Item3; j++)
                    {
                        var coinX = rand.Next(0, test.Item1);
                        var coinY = rand.Next(0, test.Item2);

                        sw.WriteLine("{0} {1}", coinX, coinY);
                    }
                }
            }
        }
    }
}
