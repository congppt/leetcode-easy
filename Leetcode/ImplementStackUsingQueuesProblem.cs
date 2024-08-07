using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class ImplementStackUsingQueuesProblem
    {
        //using 2 queues
        public class MyStack
        {
            private Queue<int> _queue1;
            private Queue<int> _queue2;
            public MyStack()
            {
                _queue1 = [];
                _queue2 = [];
            }

            public void Push(int x)
            {
                if (_queue2.Count > 0) 
                    _queue2.Enqueue(x);
                else _queue1.Enqueue(x);
            }

            public int Pop()
            {
                while (_queue1.Count > 0)
                {
                    var val = _queue1.Dequeue();
                    if (_queue1.Count == 0)
                        return val;
                    _queue2.Enqueue(val);
                }
                while (_queue2.Count > 0)
                {
                    var val = _queue2.Dequeue();
                    if (_queue2.Count == 0)
                        return val;
                    _queue1.Enqueue(val);
                }
                throw new Exception();
            }

            public int Top()
            {
                while (_queue1.Count > 0)
                {
                    var val = _queue1.Dequeue();
                    _queue2.Enqueue(val);
                    if (_queue1.Count == 0)
                        return val;
                }
                while (_queue2.Count > 0)
                {
                    var val = _queue2.Dequeue();
                    _queue1.Enqueue(val);
                    if (_queue2.Count == 0)
                        return val;
                }
                throw new Exception();
            }

            public bool Empty()
            {
                return _queue1.Count == 0 && _queue2.Count == 0;
            }
        }
        //one queue
        public class MyStack2
        {
            private Queue<int> _queue;
            public MyStack2()
            {
                _queue = [];
            }
            public void Push(int x)
            {
                _queue.Enqueue(x);
                for(int i = 0; i < _queue.Count - 1; i++)
                    _queue.Enqueue(_queue.Dequeue()); 
            }

            public int Pop()
            {
                return _queue.Dequeue();
            }

            public int Top()
            {
                return _queue.Peek();
            }

            public bool Empty()
            {
                return _queue.Count == 0;
            }
        }
    }
}
