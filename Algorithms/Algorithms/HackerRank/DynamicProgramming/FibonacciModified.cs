using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.HackerRank.DynamicProgramming
{
    public class FibonacciModified : ISolveHackerRankProblems<int>
    {

        #region Problem Statement

        /*
        A series is defined in the following manner:
        Given the nth and (n+1)th terms, the (n+2)th can be computed by the following relation 
        Tn+2 = (Tn+1)^2 + Tn 

        So, if the first two terms of the series are 0 and 1: 
         the third term = 12 + 0 = 1 
         fourth term = 12 + 1 = 2 
         fifth term = 22 + 1 = 5 
         ... And so on. 

        Given three integers A, B and N, such that the first two terms of the series (1st and 2nd terms) are A and B respectively, compute the Nth term of the series. 

        Input Format 
        You are given three space separated integers A, B and N on one line. 

        Input Constraints 
         0 <= A,B <= 2 
         3 <= N <= 20 

        Output Format 
        One integer. 
         This integer is the Nth term of the given series when the first two terms are A and B respectively. 
        Note:
        •Some output may even exceed the range of 64 bit integer. 

        Sample Input 
        0 1 5  
        Sample Output 
        5
        Explanation 
        The first two terms of the series are 0 and 1. The fifth term is 5. How we arrive at the fifth term, is explained step by step in the introductory sections. 
        */

        #endregion

        public string Execute(IEnumerable<int> input)
        {
            var splitInput = input.ToArray();
            BigInteger NMinus2 = splitInput[0];
            BigInteger NMinus1 = splitInput[1];
            int counter = 2;
            BigInteger N = 0;
            if(splitInput[2] < 2)
            {
                return splitInput[splitInput[2]].ToString();
            }

            while(counter < splitInput[2])
            {
                N = BigInteger.Pow(NMinus1, 2) + NMinus2;
                NMinus2 = NMinus1;
                NMinus1 = N;
                counter++;
            }


            //BigInteger Console.WriteLine is slow so split integer to small strings and print to Console.
            BigInteger B = N;

            var ans = new List<BigInteger>();
            var p10 = BigInteger.Pow(10, 100);
            while (B != 0)
            {
                ans.Add(B % p10);
                B /= p10;
            }
            Console.Write(ans[ans.Count - 1]);
            var fmt = new string('0', 100);
            for (var i = ans.Count - 2; i >= 0; i--)
            {
                var str = ans[i].ToString();
                Console.Write("{0}{1}", fmt.Substring(0, 100 - str.Length), str);
            }
            Console.WriteLine();

            return N.ToString();
        }
    }
}
