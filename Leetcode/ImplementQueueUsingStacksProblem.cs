using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ImplementQueueUsingStacksProblem
    {
        
        public class MyQueue1
        {
            Stack<int> stack1;
            Stack<int> stack2;

            public MyQueue1()
            {
                stack1 = [];
                stack2 = [];
            }

            public void Push(int x)
            {
                if (stack1.Count == 0)
                {
                    while (stack2.Count > 0)
                        stack1.Push(stack2.Pop());
                }
                stack1.Push(x);
            }

            public int Pop()
            {
                if (stack2.Count == 0)
                {
                    while (stack1.Count > 0)
                        stack2.Push(stack1.Pop());
                }
                
                return stack2.Pop();
            }

            public int Peek()
            {
                if (stack2.Count == 0)
                {
                    while (stack1.Count > 0)
                        stack2.Push(stack1.Pop());
                }
                return stack2.Peek();
            }

            public bool Empty()
            {
                return stack1.Count == 0 && stack2.Count == 0;
            }
        }

    }
}
