using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
 public   class laryArray
    {
        public static string larrysArray(List<int> A)
        {
            int count = 0;
            for(int i=1;i<A.Count;i++)
            {
                for(int j = i-1; j <= 0; j--)
                {
                    if (A[i] < A[j])
                    {
                        count++;
                    }
                }
            }
            return count % 2 == 0 ? "YES" : "NO";
        }

    }
}
