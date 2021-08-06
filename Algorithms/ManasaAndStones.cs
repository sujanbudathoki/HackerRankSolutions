using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
   public class ManasaAndStones
    {
        public static List<int> stones(int n, int a, int b)
        {
            List<int> result = new List<int>();
            for(int i = n - 1,j=0; i >= 0; i--,j++)
            {
                int curNUmber = i * a + j * b;
                if (!result.Contains(curNUmber))
                    result.Add(curNUmber);
            }
            result.Sort();
            return result;

        }
    }
}
