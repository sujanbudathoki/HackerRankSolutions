using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
 public   class ServiceLane
    {
        public static List<int> ServiceLaneFunc(int n, List<List<int>> cases, List<int> width)
        {
            List<int> result = new List<int>();

            for(int i = 0; i < cases.Count; i++)
            {
                int start = cases[i][0];
                int end = cases[i][1];
                int maxWidth = width.GetRange(start, end - start+1).Min();
                result.Add(maxWidth);
            }

            return result;

        }
    }
}
