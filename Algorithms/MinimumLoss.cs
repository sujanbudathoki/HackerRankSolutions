using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
  public  class MinimumLoss
    {
        public static int minimumLoss(List<long> price)
        {
            //alert :- few test cases failed
            long minimum = price.Max();
            for(int i = 0; i < price.Count; i++)
            {
                for(int j = i + 1; j < price.Count; j++)
                {
                    
                    if (price[i] > price[j]) //indicates financial loss
                    {
                     
                        if ((price[i]-price[j]) < minimum)
                        {
                            minimum = price[i] - price[j];
                        }
                    
                    }
                }
            }
            return (int)minimum;
        }
    }
}
