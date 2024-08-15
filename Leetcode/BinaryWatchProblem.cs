using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class BinaryWatchProblem
    {
        public IList<string> ReadBinaryWatch(int turnedOn)
        {
            List<string> times = [];
            for (int h = 0; h < 12; h++)
            {
                for (int m = 0; m < 60; m++)
                {
                    var totalBit = CountBit1(m) + CountBit1(h);
                    if (totalBit == turnedOn)
                        times.Add($"{h}:{m:D2}");
                }
            }
            return times;
        }
        int CountBit1(int num)
        {
            if (num == 1) return 1;
            var count = 0;
            while (num > 0)
            {
                if (num % 2 == 1) count++;
                num >>= 1;
            }
            return count;
        }
    }
}
