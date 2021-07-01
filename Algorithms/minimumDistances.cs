using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
   public class HackerRank3
    {
        public static int minimumDistances(List<int> a)
        {
            int minimumDistance=0;
            int index = 0;
            Dictionary<int, int> Store = new Dictionary<int, int>();
            foreach(int result in a)
            {
                if (Store.ContainsKey(result))
                {
                    if (minimumDistance == 0)//first minimum
                    {
                        minimumDistance = index - Store[result];
                    }
                    else
                    {
                        if(minimumDistance>(index-Store[result]))
                        {
                            minimumDistance = index - Store[result];
                        }
                    }
                }
                else
                {
                    Store.Add(result, index);
                }
                index++;
            }
            return minimumDistance == 0 ? -1 : minimumDistance;

        }
    }
}
