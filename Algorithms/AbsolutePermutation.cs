using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
    public class AbsolutePermutationClass
    {
        public static List<int> absolutePermutation(int n, int k)
        {
           int total = 2*k;
            List<int> result = new List<int>();
            if (k == 0)
            {
                for(int i = 1; i <= n; i++)
                {
                    result.Add(i);
                }
            }
            else if (n % total == 0)
            {
                
                for(int i = 0; i < n / total; i++)
                {
                    for(int j = 1; j <= k; j++)
                    {
                        result.Add(2 * i * k + k + j);
                    }
                    for(int j = 1; j <= k; j++)
                    {
                        result.Add(2 * k * i + j);
                            
                            
                    }
                }
         
            }
            else
            {
               return new List<int>() { -1 };
            }
            return result;

        }
    }
}

