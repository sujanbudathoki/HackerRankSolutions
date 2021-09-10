using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
  public  class flatLandSpaceStationsClass
    {
     public   static int flatlandSpaceStations(int n, int[] c)
        {
         
            int minimum = Int32.MaxValue;
            for(int i = 0; i <= n; i++)
            {
                int curelemn = Int32.MaxValue;
               for(int j = 0; j < c.Length; j++)
                {
                    if (curelemn > Math.Abs(c[j] - i))
                    {
                        curelemn = Math.Abs(c[j] - i);
                        
                    }
                }
                if (minimum > curelemn)
                {
                    minimum = curelemn;
                }
            }

            return minimum;

        }

    }
}
