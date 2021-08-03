using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
public    class TaumBday
    {
        public static long taumBday(Int64 b, Int64 w, Int64 bc, Int64 wc, Int64 z)
        {
            long result = 0;
            result = bc > wc ? bc > (wc + z) ? (wc + z) * b + wc * w : wc * w + bc * b : bc < wc ? wc > (bc + z) ? (bc + z) * w + bc * b : bc * b + wc * w : bc * b + wc * w;
            return result;
        }
    }
}
