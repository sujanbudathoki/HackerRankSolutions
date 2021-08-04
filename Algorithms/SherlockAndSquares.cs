using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
   public class SherlockAndSquares
    {
        public static int squares(int a, int b)
        {
            
            
            double result = Math.Floor(Math.Sqrt(b)) - Math.Ceiling(Math.Sqrt(b)) + 1;

           
            return (int)result;

        }
    }
}
