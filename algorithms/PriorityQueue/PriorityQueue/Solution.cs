using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue.Core
{
    public static class Solution
    {
        public int[] solution(int[] A, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var lengthOfArray = A.Length;
        }
        



        public static int BinaryGap(int N)
        {
            bool binaryGapStarted = false;
            var binary = Convert.ToString(N, 2);
            List<int> binaryGaps = new List<int>();
            int binaryGap = 0;

            for (int i = 1; i < binary.Length; i++)
            {
                if (binaryGapStarted
                    && binary[i] == '0')
                {
                    binaryGap++;
                }
                else if (binaryGapStarted == true
                    && binary[i] == '1')
                {
                    binaryGapStarted = false;
                    binaryGaps.Add(binaryGap);
                    binaryGap = 0;
                }
                else if (binary[i - 1] == '1'
                    && binary[i] == '0')
                {
                    binaryGap++;
                    binaryGapStarted = true;
                }
            }

            return binaryGaps.Count == 0
            ? 0
            : binaryGaps.Max();
        }
    }
}
