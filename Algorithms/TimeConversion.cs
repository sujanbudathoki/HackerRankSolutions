using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
  public  class TimeConversion
    {
        public static string timeConversionFunction(string s)
        {
            
            string[] times;
            times = s.Split(':');
            int hour = int.Parse(times[0]);
            string minutes = times[1];
            string seconds = times[2].Substring(0, 2);
            string symbol = times[2].Substring(2, 2);
            if (symbol == "AM" && hour == 12)
            {
                hour = 0;
            }
            if(symbol=="PM" && hour < 12)
            {
                hour += 12;
            }


            return hour < 10 ? $"0{hour}:{minutes}:{seconds}":$"{hour}:{minutes}:{seconds}";

            
        }
    }
}
