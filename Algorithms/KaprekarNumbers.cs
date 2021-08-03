using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
  public  class KaprekarNumbers
    {
        public static void kaprekarNumbers(int p, int q)
        {
            int r, l, len, d, counter = 0;
            string conversion;
            for (int i = p; i <= q; i++)
            {
                conversion = (i * i).ToString();
                len = conversion.Length;
                d = len / 2;
                if (len > 1)
                {
                    
                        r = Convert.ToInt32(conversion.Substring(d));
                        l = Convert.ToInt32(conversion.Substring(0, d));
                        if (r + l == i)
                        {
                            Console.Write(i + " ");
                            counter++;
                        }
                    
                   
                }
                else
                {
                    if (i == 1 || i == 9)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("INVALID RANGE");
            }
        }
    }
}
