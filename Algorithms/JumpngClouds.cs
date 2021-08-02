using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
  public  class JumpngClouds
    {
        public static int jumpingOnClouds(List<int> c)
        {
            int minimum = 0;
            for(int i = 0; i < c.Count; i+=2)
            {
                if (c[i] == 1)
                {
                    minimum++;
                    i--;

                }
                else
                {
                    minimum++;
                }
            }
            return minimum;

        }
    }
}
