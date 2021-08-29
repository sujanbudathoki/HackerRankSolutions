using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
   public class PangramsMain
    {
        public static string pangrams(string s)
        {
            s = s.ToLower();
          
            HashSet<char> storage = new HashSet<char>();
            for(int i = 0; i < s.Length; i++)
            {
                if (!(s[i]==' '))
                {
                    storage.Add(s[i]);
                }
            }
            return storage.Count==27?"Pangram":"Not Pangram";
        }
    }
}
