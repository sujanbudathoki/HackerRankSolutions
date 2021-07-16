using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
  public  class BeautifulTriplets
    {
        public static int beautifulTriplets(int d, List<int> arr)
        {

            int tripletCount = 0;
            for(int i = 0; i < arr.Count; i++)
            {
                int curValue = arr[i];
                
                    if (arr.Contains(curValue + d))
                    {
                        if (arr.Contains(curValue + (d * 2)))
                        {
                        tripletCount++;
                        }
                    }
               
                
            }
            return tripletCount;
        }
    }
}
