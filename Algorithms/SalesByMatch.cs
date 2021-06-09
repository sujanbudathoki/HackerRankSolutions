using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
   public class SalesByMatch
    {
        public static int sockMerchant(int n, List<int> ar)
        {
            int counter=0;

            Dictionary<int, int> values = new Dictionary<int, int>();
            foreach(int a in ar)
            {
                values[a] = values.ContainsKey(a) ? values[a] + 1 : 1;

            }
            foreach(KeyValuePair<int,int> item in values)
            {
                counter = item.Value % 2 == 0 ? counter + (item.Value/2) : counter + (item.Value - 1)/2;
            }
            return counter;
        }
    }
}
