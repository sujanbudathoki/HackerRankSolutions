using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
   public class FairRations
    {
        public static string fairRations(List<int> B)
        {

            int oddCounter = B.Where(x=>x%2!=0).Count();
            int counter = 0;
            if (oddCounter % 2 == 0)
            {
                for (int i = 0; i < B.Count; i++)
                {
                    if (B[i] %2!= 0)
                    {
                        counter += 2;
                        B[i + 1] = B[i + 1] + 1;
                    }

                }
                return counter.ToString();
            }
            else
            {
                return "NO";
            }
         
        }
    }
}
