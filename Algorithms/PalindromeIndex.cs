using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
  public  class PalindromeIndex
    {
        public static int palindromeIndex(string s)
        {
            int isEqual = 0;
            int i, j;
            for(i = 0,j=s.Length-1; i < s.Length/2; i++,j--)
            {
                if (s[i] != s[j])
                {
                    isEqual = 1;
                    break;
                }
            }
            if (isEqual == 1)
            {
                if (s[i + 1] == s[j])
                {
                    return i;
                }
                else
                {
                    return j;
                }
            }
            else
            {
                return -1;
            }

        }
    }
}
