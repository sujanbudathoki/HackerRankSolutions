using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
   public class timeInWordsClass
    {
        public static string timeInWords(int h, int m)
        {
            List<string> storeTime = new List<string>()
            {
                 "zero","one","two","three","four","five","six","seven","eight","nine",
        "ten",
        "eleven",
        "twelve",
        "thirteen",
        "fourteen",
        "fifteen",
        "sixteen",
        "seventeen",
        "eighteen",
        "nineteen",
        "twenty",
        "twenty one",
        "twenty two",
        "twenty three",
        "twenty four",
        "twenty five",
        "twenty six",
        "twenty seven",
        "twenty eight",
        "twenty nine"
            };
            if (m == 0)
            {
                return storeTime[h] + " o' clock";
            }
            else if (m == 15)
            {
                return "quater past " + storeTime[h];
            }
            else if (m == 30)
            {
                return "half past" + storeTime[h];
            }
            else if (m == 45)
            {
                return "quater to" + storeTime[h + 1];
            }
            else if (m > 30)
            {
                return storeTime[60 - m] + " minutes to " + storeTime[h + 1];
            }
            else if (m < 30)
            {
                if (m > 1)
                {
                    return storeTime[m] + " minutes passed" + storeTime[h];
                }
                else
                {
                    return storeTime[m] + " minute passed" + storeTime[h];
                }
            }
            else
            {
                return "";
            }
        }
    }
}
