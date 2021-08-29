using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
   public class countTriplets
    {
      public  static long countTripletsFunc(List<long> arr, long r)
        {
            
            long counter = 0;
            
            var store = new Dictionary<long, int>();
            for(int i = 0; i < arr.Count; i++)
            {
                if (store.ContainsKey(arr[i]))
                {
                    store[arr[i]] = store[arr[i]] + 1;

                }
                else
                {
                    store[arr[i]] = 1;
                }
            }
            foreach(var item in store)
            {
                int curNumber = 0;
                int totCount = item.Value > 1 ? (item.Value - 1) : 0;
              
                while (curNumber < 2)//max for pattern
                {
                    long nextProg = item.Key * (curNumber+1) * r;

                    if (store.ContainsKey(nextProg))
                    {
                        totCount += (store[nextProg]-1);
                        curNumber++;
                    }
                    else
                    {
                        
                        break;
                    }
                }
                if (!(curNumber < 3))
                {
                    counter += totCount;
                }

                
            }
            

            return counter;

        }
    }
}
