using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
  public  class HighestValuePalindrome
    {
        public static string highestValuePalindrome(string s, int n, int k)
        {
            char[] check = s.ToCharArray();
            for(int i = 0; i <= (n / 2); i++)
            {
                if (s[i] != s[i - 1])
                {
                    char temp = check[i] > check[n - i] ? check[i] : check[n - i - 1];
                    check[i] = temp;
                    check[n - i - 1] = temp;
                    k--;
                }
                //middle element
                if (n % 2 != 0 && i == ((n / 2) + 1) && k > 0)
                {
                    check[i] = '9';
                }
            }

            int flag = 0;



            while (k > 1&&flag==(n/2))
            {
                if (check[flag] != '9')
                {
                    check[flag] = '9';
                    check[n - flag - 1] = '9';
                    k = k - 2;
                    flag++;
                }
                else
                {
                    flag++;
                }
                
            }

            return check.ToString();
        }
    }
}
