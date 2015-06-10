using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.HackerRank
{
    public class InputReader
    {
        public IEnumerable<T> ReadInput<T>()
        {
            var testCaseCountString = Console.ReadLine();
            var testCaseCount = int.Parse(testCaseCountString);
            var input = new List<T>();
            for(var count = 0; count < testCaseCount; count++)
            {
                var currentTestCaseString = Console.ReadLine();
                var convertedInput = (T)Convert.ChangeType(currentTestCaseString, typeof(T));
                input.Add(convertedInput);
            }
            return input;
        }
    }
}
