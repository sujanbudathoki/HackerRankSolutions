using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.HackerRankSolutions.HackerRankSolutions.Algorithms
{
  public  class minimumNumberPassword
    {
        public static int minimumNumber(int n, string password)
        {
            // Return the minimum number of characters to make the password strong
            int small = 0;
            int capital = 0;
            int digit = 0;
            int special = 0;
            int checkLegth = 0;
            int minimum = 0;

            for(int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 0 && password[i] <= 9)
                {
                    digit++;
                }
                else if (password[i] >= 'a' && password[i] <= 'z')
                {
                    small++;
                }
                else if (password[i] >= 'A' && password[i] <= 'Z')
                {
                    capital++;
                }
                else if ("!@#$%^&*()-+".Contains(password[i]))
                {
                    special++;
                }
            }
            if (!(digit > 1))
            {
                minimum++;
            }
            if (!(small > 1))
            {
                minimum++;
            }
            if (!(capital > 1))
            {
                minimum++;
            }
            if (!(special > 1))
            {
                minimum++;
            }
            else
            {

            }

    }
    }
}
