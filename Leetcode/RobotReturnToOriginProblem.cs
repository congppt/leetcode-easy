using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RobotReturnToOriginProblem
    {
        public bool JudgeCircle(string moves)
        {
            int x = 0, y = 0;
            for (int i = 0; i < moves.Length; i++)
            {
                switch (moves[i])
                {
                    case 'L':
                        x++;
                        break;
                    case 'R':
                        x--;
                        break;
                    case 'U':
                        y++;
                        break;
                    default:
                        y--;
                        break;
                }
            }
            return x == 0 && y == 0;
        }
    }
}