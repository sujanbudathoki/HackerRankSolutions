using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
  public  class BigSorting
    {
        public static List<string> bigSorting(List<string> unsorted)
        {
             var stringResult =   unsorted.OrderBy(x=>x).ToList();
             return stringResult;
        }
    }
}
