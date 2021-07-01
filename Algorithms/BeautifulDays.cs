using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.Algorithms
{
   public class BeautifulDays
    {
        public static int beautifulDays(int i, int j, int k)
        {
            int counter = 0;
           

            for (int l= i; l <= j; l++)
            {
                int result = (l - reverser(l)) % k;
                if (result == 0)
                {
                    counter++;
                }
            }
            return counter;

        }
        private static int reverser(int n)
        {
            int rem = 0; int reverse = 0;
        
            
            while(n>0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;
            }
            return reverse;
        }

    }
}
