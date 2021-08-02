using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
    public  class CutTheSticks
    {
        public static List<int> cutTheSticks(List<int> arr)
        {
            List<int> rem = new List<int>();
            arr.Sort();
            rem.Add(arr.Count);
            int remaining=arr.Count;
            Dictionary<int, int> storage = new Dictionary<int, int>();
            for(int i = 0; i < arr.Count; i++)
            {
                if (storage.ContainsKey(arr[i]))
                {
                    storage[arr[i]] = storage[arr[i]] + 1;
                }
                else
                {
                    storage.Add(arr[i], 1);
                }
            }
            foreach(var a in storage)
            {
                remaining = remaining - a.Value;
                if (remaining > 0)
                {
                    rem.Add(remaining);
                }
            }
            return rem;
        }
    }
}
