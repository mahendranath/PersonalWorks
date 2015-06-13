using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.HackerRank.Challenges.IndeedPrimeChallengeJun15
{
    public class AsciiSpacecraftArt
    {

        /*
          /\
          ||
         /||\
        /:||:\
        |/||\|
          **
          **

          /\
          ||
          ||
         /||\
        /:||:\
        |:||:|
        |/||\|
          **
          **
        */

        public string Solve(int size)
        {
            StringBuilder output = new StringBuilder();

            const string FIRST_LINE = @"  /\";
            const string SECOND_LINE = "  ||";
            const string THIRD_LINE = @" /||\";
            const string FOURTH_LINE =@"/:||:\";
            const string FIFTH_LINE = @"|:||:|";
            const string SIXTH_LINE = @"|/||\|";
            const string LAST_LINE =   "  **  ";

            int sizeOfRocket = 1 + size + 1 + size + 1 + 2;
            
            for (int i = 0; i < sizeOfRocket; i++)
            {
                if(i == 0)
                {
                    output.AppendLine(FIRST_LINE);
                }
                else if (i <= size)
                {
                    output.AppendLine(SECOND_LINE);
                }
                else if(i == size + 1)
                {
                    output.AppendLine(THIRD_LINE);
                }
                else if(i == size + 2)
                {
                    output.AppendLine(FOURTH_LINE);
                }
                else if(i == sizeOfRocket - 3)
                {
                    output.AppendLine(SIXTH_LINE);
                }
                else if(i >= sizeOfRocket - 2)
                {
                    output.AppendLine(LAST_LINE);
                }
                else
                {
                    output.AppendLine(FIFTH_LINE);
                }
            }
            return output.ToString();
        } 
    }
}
