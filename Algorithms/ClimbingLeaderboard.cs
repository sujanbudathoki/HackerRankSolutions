using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
   public class ClimbingLeaderboard
    {
        //Unsolved--Incomplete
        public static List<int> LeaderboardFunction(List<int> ranked, List<int> player)
        {
            ranked.Sort();
            ranked.Reverse();
            int Rank = 1;
            List<int> playerRanking = new List<int>(new int[player.Count]);
            Dictionary<int, int> newRanking = new Dictionary<int, int>();
            for(int i = 0; i < ranked.Count; i++)
            {
               
              
                if (!newRanking.ContainsKey(ranked[i]))
                {
                    newRanking.Add(ranked[i],Rank);
                    Rank++;
                    
                }
            }
            int index = 0;
            foreach(var item in player)
            {
                if (newRanking.ContainsKey(item))
                {
                    playerRanking[index]=newRanking[item];
                    index++;

                }
                else
                {
                    foreach(var itemList in newRanking)
                    {
                        if (item > itemList.Key)
                        {
                            playerRanking[index]=newRanking[itemList.Key];
                            index++;
                            break;
                        }
                        
                       
                    }
                }
            }
            return playerRanking;


        }
    }
}
