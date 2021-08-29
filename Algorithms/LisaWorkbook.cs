using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
  public  class LisaWorkbook
    {
        public static int workbook(int n, int k, List<int> arr)
        {
            int counter = 0;
            int page = 1;
            for (int i = 0; i < arr.Count; i++)
            {
                int total = arr[i];
                for(int j = 1; j <= total; j++)
                {
                    if (j == page)
                        counter++;
                    if (j % k == 0 || j == total)
                        page++;

                }
                
                
            }

            return counter;
        }
    }
}
