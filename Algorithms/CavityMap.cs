using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
   public class CavityMap
    {
        public static List<string> cavityMap(List<string> grid)
        {
            //alert :- few test cases failed

            var result = new List<string>();
            
            for(int i = 0; i < grid.Count; i++)
            {
                char[] arr = new char[grid[i].Length];

                for (int j = 0; j < grid[i].Length; j++)
                {

                   
                    if (!(i == 0 || i == grid.Count - 1 ||j==0||j<grid[i].Length-1))
                    {
                        if (grid[i][j] > grid[i - 1][j] && grid[i][j] > grid[i][j - 1] &&
                             grid[i][j] > grid[i + 1][j] && grid[i][j] > grid[i][j + 1])
                        {
                            arr[j]= 'X';
                        }
                        else
                        {
                            arr[j] = grid[i][j];
                        }
                    }
                    else
                    {
                        arr[j] = grid[i][j];
                    }

                   

                }
                result.Add(new string(arr));
            }
            return result;
        }
    }
}
