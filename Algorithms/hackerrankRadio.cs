using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
   public class hackerrankRadio
    {
        public static int hackerlandRadioTransmitters(List<int> x, int k)
        {
            int minimum = 0;
            int counterDouble = 0;
            int checker = 0;
            int check = 0;
            //using dictionary
          
            for(int i = 1; i < x.Count-1; i++)
            {
                if (checker > 0)
                {
                    checker = 0;
                }
                else
                {
                    if (x[i + 1] - 1 == x[i])
                    {
                      
                        checker++;
                    }
                    else if (x[i - 1] + 1 == x[i])
                    {
                      
                        checker++;
                    }
                    if (check > 0)
                    {
                        check++;
                    }
                }
               
               
            }

            return minimum;
        }
    }
}
