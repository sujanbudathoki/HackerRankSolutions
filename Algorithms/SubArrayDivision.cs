using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
   public class SubArrayDivision
    {
        public static int birthday(List<int> s, int d, int m)
        {
            int result = 0;
            for (int i = 0; i <= s.Count - m; i++)
            {
              
                int sum = s.GetRange(i, m).Sum();
                result = sum == d ? result + 1 : result;
            }
            return result;
        }
    }
}
