using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
   public class ElectronisShop
    {
      public  static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            /*
             * Write your code here.
             */
            int max = 0;
            for(int i=0;i<keyboards.Length;i++)
            {
                for(int j=0;j<drives.Length;j++)
                {
                    int sum = keyboards[i] + drives[j];
                    if(sum<b)
                    {
                        if(sum>max)
                        {
                            max = sum;
                        }
                    }
                }
            }//end for loop
            return max == 0 ? -1 : max;


        }
    }
}
