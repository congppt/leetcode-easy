using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class BaseballGameProblem
    {
        public static int CalPoints(string[] operations)
        {
            Stack<int> points = [];
            int totalPoint = 0;
            int point;
            for (int i = 0; i < operations.Length; i++)
            {
                switch (operations[i])
                {
                    case "+":
                        point = points.Pop();
                        int temp = point;
                        point += points.Peek();
                        points.Push(temp);
                        points.Push(point);
                        totalPoint += point;
                        break;
                    case "D":
                        point = points.Peek() * 2;
                        points.Push(point);
                        totalPoint += point;
                        break;
                    case "C":
                        point = points.Pop();
                        totalPoint -= point;
                        break;
                    default:
                        point = int.Parse(operations[i]);
                        points.Push(point);
                        totalPoint += point;
                        break;
                }
            }
            return totalPoint;
        }
    }
}