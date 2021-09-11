using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
  public  class stringInHackerrank
    {
        public static string hackerrankInStringFunc(string s)
        {
            string newString = "hackerrank";
            int j = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if (j < newString.Length && newString[j] == s[i] )
                    j++;
            }
            return j == newString.Length ? "YES" : "NO";

        }
    }
}
