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
            
            int counter = 0;
            int check=0;
            int len=0;
           
          
            for(int i = 0; i < topic.Count; i++)
            {
              for(int j = 1; j < topic.Count; j++)
                {
                    if (i != j)

                    {
                        check = 1;
                        len = topic[i].Length;

                        for(int k = 0; k < len; k++)
                        {
                            if (topic[i][k] == '0')
                            {
                                if (topic[j][k] == '0')
                                {
                                    check = 0;
                                }
                            }
                              
                        }
                        counter = check == 1 ? counter + 1 : counter;
                           
                     }



                    }
                }
            result[0] = len;
            result[1] = counter;
            return result;

            }

        

        }
    }

