using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Algorithms.HackerRank.Challenges.IndeedPrimeChallengeJun15;

namespace AlgorithmTest.HackerRank.IndeedPrimeChallengeJun15
{
    public class AsciiSpacecraftArtTest
    {
        [Fact]
        public void ExecuteTest()
        {
            AsciiSpacecraftArt obj = new AsciiSpacecraftArt();
            var output1 = obj.Solve(1);
            var output2 = obj.Solve(2);
            var output3 = obj.Solve(3);
            var output4 = obj.Solve(4);
            var output5 = obj.Solve(5);
        }
    }
}
