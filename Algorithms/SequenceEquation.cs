using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
     public  class SequenceEquation
    {
        //using dictionary
        public static List<int> permutationEquation(List<int> p)
        {
            List<int> output = new List<int>(new int[p.Count]);
            int count = 1;
            Dictionary<int, int> dictStore = new Dictionary<int, int>();
            for(int i = 0; i < p.Count; i++)
            {
                dictStore.Add(p[i], i+1);
            }
            while(count<=p.Count)
            {
                int store = dictStore[count];
                int result = dictStore[store];
                output[count+1]=result;
                count++;
            }
            return output;

        }
    }
}
