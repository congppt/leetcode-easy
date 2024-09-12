using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class JewelsAndStonesProblem
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            var count = 0;
            HashSet<char> jewelTypes = new(jewels);
            foreach (var c in stones)
                if (jewelTypes.Contains(c)) count++;
            return count;
        }
    }
}