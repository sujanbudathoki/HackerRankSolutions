﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
   public class nonDivisibleSubsetClass
    {
        public static int nonDivisibleSubset(int k, List<int> s)
        {
            int count = 0;
            int maxcount = 0;
            for(int i = 0; i < s.Count; i++)
            {
                if (s[i] % k == 0)
                {
                    count = 0;
                    for (int j = i + 1; j < s.Count; j++)
                    {
                        if (s[j] % k == 0)
                        {
                            count++;
                        }
                    }
                }
                maxcount = maxcount > count ? maxcount : count;
            }
            return maxcount;
        }
    }
}
