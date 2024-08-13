using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class NimGameProblem
    {
        public static bool CanWinNim(int n)
        {
            return n % 4 != 0;
        }
    }
}
