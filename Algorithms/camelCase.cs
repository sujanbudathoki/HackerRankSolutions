using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
   public class camelCase
    {
        public static int camelcase(string s)
        {
            int count = 1;
            for(int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                    count++;

            }
            

            return count;
        }
    }
}
