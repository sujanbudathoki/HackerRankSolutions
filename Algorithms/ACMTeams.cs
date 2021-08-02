using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
  public  class ACMTeams
    {
        public static List<int> acmTeam(List<string> topic)
        {
            List<int> result = new List<int>(new int[2]);

          
            int check = 0;
            int len = 0;
            int maxSubj = 0;
            int maxCounter = 0;


            for (int i = 0; i < topic.Count; i++)
            {
                for (int j = i + 1; j < topic.Count; j++)
                {

                    check = 0;
                    len = topic[i].Length;

                    for (int k = 0; k < len; k++)
                    {
                        if (topic[i][k] == '1' || topic[j][k] == '1')
                        {
                            check++;
                        }

                    }
                    if (maxSubj < check)
                    {
                        maxSubj = check;
                        maxCounter = 1;
                    }
                    else if (maxSubj == check)
                    {
                        maxCounter++;
                    }






                }
            }

            result[0] = maxSubj;
            result[1] = maxCounter;
            Console.WriteLine($"{result[0]}  {result[1]}");
            return result;

        }

        

        }
    }

