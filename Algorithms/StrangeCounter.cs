using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
   public class StrangeCounterClass
    {
        public static long strangeCounter(long t)
        {
            long time = 1,value=3,initValue=3;
            while (time !=t)
            {
                if (value <= 1)
                {
                    value = 2 * initValue;
                    initValue = value;
                    time++;
                }
                else
                {
                    value--;
                    time++; 
                }
            }
            return value;
        }
    }
}
