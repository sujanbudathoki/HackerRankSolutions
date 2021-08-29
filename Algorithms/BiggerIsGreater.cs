using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
   public class BiggerIsGreater
    {
        public static string biggerIsGreater(string w)
        {
            char[] a = w.ToCharArray();
            for(int i = w.Length; i > 0; i--)
            {
              for(int j = i; j > 0; j--)
                {
                    if (w[j] > w[j - 1])
                    {
                        char temp = a[j];
                        a[j] = a[j - 1];
                        a[j - 1] = temp;
                        int store = j + 1;
                        while (store> w.Length - 1)
                        {
                            if (a[store] > a[store + 1])
                            {
                                char storeTemp = a[store];
                                a[store] = a[store + 1];
                                a[store + 1] = storeTemp;
                            }
                        }
                        break;

                    }
                }
            }
            return new string(a);
        }
    }
}
