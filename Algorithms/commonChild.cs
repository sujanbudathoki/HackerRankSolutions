using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
 public   class commonChildClass
    {

        public int commonChild(string s1, string s2)
        {

            List<List<int>> collection = new List<List<int>>();
            for(int i = 0; i < s1.Length; i++)
            {
                for(int j = 0; j < s2.Length; j++)
                {
                    if (s1[i] == s2[j])
                    {
                        collection[i + 1][ j + 1] = collection[i][j] + 1; 
                    }
                    else
                    {
                        collection[i + 1][ j + 1] = getMax(collection[i + 1][ j], collection[i][ j + 1]);
                    }
                }
            }
            return collection[s1.Length - 1][ s2.Length - 1];

        }
        static int getMax(int a1,int a2)
        {
            return a1 > a2 ? a1 : a2;
        }
         

    }
   


}
