using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
   public class AppendAndDelete
    {
        public static string appendAndDelete(string s, string t, int k)
        {
            int minLength = s.Length<t.Length?s.Length:t.Length;
            int minSteps = 0;
            for(int i = 0; i < minLength; i++)
            {
                if (s[i] == t[i])
                {
                    minSteps++;

                }
                else
                {
                    break;
                }
            }

            minSteps = s.Length + t.Length - (2 * minSteps);

            return k < minSteps ? "NO" : (k - minSteps) % 2 == 0 ? "YES" : "NO";

        }
    }
}
