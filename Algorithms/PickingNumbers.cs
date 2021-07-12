using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
  public  class PickingNumbers
    {
        public static int maxLength(List<int> n)
        {
            int max = 0;
            n.Sort();
            for(int i = 0; i < n.Count - 1; i++)
            {
                int currIndex = i;
                int Counter = 0;
                bool isRepeated = i == 0 ? false : n[i] - n[i - 1] == 0 ? true : false;
                if (!isRepeated)
                {

                    while (true)
                    {
                        if (currIndex > n.Count - 1)
                        {

                            break;
                        }
                        else if (n[currIndex] - n[i] <= 1)
                        {
                            currIndex++;
                            Counter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (Counter > max)
                    {
                        max = Counter;
                    }
                }
                
            }
            return max;
        }
    }
}
