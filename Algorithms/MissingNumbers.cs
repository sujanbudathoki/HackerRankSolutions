using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
   public class MissingNumbers
    {
        public static List<int> missingNumbers(List<int> arr, List<int> brr)
        {
            var result = new List<int>();
            Dictionary<int, int> storeA = new Dictionary<int, int>();
            Dictionary<int, int> storeB = new Dictionary<int, int>();

            for(int i = 0; i < arr.Count; i++)
            {

                if (storeA.ContainsKey(arr[i]))
                {
                    storeA[arr[i]] = storeA[arr[i]] + 1;
                }
                else
                {
                    storeB[arr[i]] = 1;
                }
            }
            for(int i = 0; i < brr.Count; i++)
            {
                if (storeB.ContainsKey(brr[i]))
                {
                    storeB[brr[i]] = storeB[brr[i]] + 1;
                }
                else
                {
                    storeB[brr[i]] = 1;
                }
            }
            foreach(var item in storeA)
            {
                if (storeB[item.Key] != item.Value)
                {
                    result.Add(item.Key);
                }
            }
            return result;

         
           
        }
    }
}
