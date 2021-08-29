using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
   public class LilyHomeworkClass
    {
        public static int lilysHomework(List<int> arr)
        {

            List<int> sorted = arr.OrderBy(x=>x).ToList();
            
            int minimalSwap = 0;
            for(int i = 0; i < arr.Count; i++)
            {
                if (arr[i] != sorted[i])
                {
                    minimalSwap++;
                    int index = sorted.IndexOf(arr[i]);
                    //swapping 
                    int temp = arr[index];
                    arr[index] = arr[i];
                    arr[i] = temp;
                }
            }
            return minimalSwap;

        }
    }
}
