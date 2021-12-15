using System;

namespace Benford_s_law
{
    class Program
    {
        static void Main(string[] args)
        {
            GetBenfordStatistics("1");
            GetBenfordStatistics("abc");
            GetBenfordStatistics("123 456 789");
            GetBenfordStatistics("abc 123 def 456 gf 789 i");
        }


        public static int[] GetBenfordStatistics(string text)
        {
           
            var statistics = new int[10];
            char ver;
            for (int i = 1; i <= text.Length; i++)
            {
                for (int j = 0; j < textArray(text).Length; j++)
                {
                    ver = textArray(text)[j][0];
                    if (i.Equals(ver - '0') && char.IsDigit(ver))
                    {
                        statistics[i]++;
                    }
                }
            }
            return statistics;
        }

        private static string[] textArray(string text)
        {
            return text.Split(" ", StringSplitOptions.None);
        }
    }
}
