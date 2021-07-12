using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
  public  class SparseArrays
    {
        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            var Output = new List<int>(new int[queries.Count]);
            for(int i = 0; i < strings.Count; i++)
            {
                for(int j = 0; j < queries.Count; j++)
                {
                    if (strings[i] == queries[j])
                    {

                        Output[j] = Output[j] + 1;
                    }
                }
            }
             
            return Output;


         

        }
    }
}
