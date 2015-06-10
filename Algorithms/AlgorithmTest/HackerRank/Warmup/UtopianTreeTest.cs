using Xunit;
using Algorithms.HackerRank.Warmup;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTest.HackerRank.Warmup
{
    public class UtopianTreeTest
    {
        [Fact]
        public void ExecuteTest()
        {
            var input = new List<int>() { 0, 1, 4 };
            var expectedOutput = new StringBuilder().AppendLine("1").AppendLine("2").AppendLine("7").ToString();
            UtopianTree utopianTree = new UtopianTree();
            var actualOutput = utopianTree.Execute(input);
            Assert.StrictEqual(expectedOutput, actualOutput);
        }
    }
}
