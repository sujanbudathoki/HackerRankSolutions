using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
   public  class EqualizeArray
    {
        public static int equalizeArray(List<int> arr)
        {
            int result = 0;
            Dictionary<int, int> check = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                if (check.ContainsKey(item))
                {
                    check[item] = check[item] + 1;
                }
                else
                {
                    check.Add(item, 1);
                }
            }


            int longestValue = check.Max(x => x.Value);
            result = arr.Count - longestValue;
            return result;
        }
    }
}
