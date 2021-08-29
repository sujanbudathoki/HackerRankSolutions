using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
   public class MarsExplotation
    {
        public static int marsExploration(string s)
        {
            int result = 0;
            int memoryCount = s.Length / 3;
            for(int i = 0; i <= memoryCount; i++)
            {
                if (!(s[i*3]=='S'))
                {
                    result++;
                }
                else if (!((s[(i * 3) + 1]) == 'O'))
                {
                    result++;
                }
                else if (!(s[(i * 3) + 2] == 'S'))
                {
                    result++;
                }
            }

            return result;
        }

    }
}
