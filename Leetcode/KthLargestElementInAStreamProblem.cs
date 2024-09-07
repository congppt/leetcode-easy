using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class KthLargestElementInAStreamProblem
    {
        public class KthLargestQueue
        {
            private  readonly int _pos;
            private readonly PriorityQueue<int, int> _queue;
            public KthLargestQueue(int k, int[] nums)
            {
                _pos = k;
                _queue = new();
                foreach (int num in nums)
                    _queue.Enqueue(num, num);
            }

            public int Add(int val)
            {
                //only enqueue new value if not enough values or new value is higher than the minimal value
                if (_queue.Count < _pos || val >= _queue.Peek())
                    _queue.Enqueue(val, val);
                //remove unnecessary values after kth position
                while (_queue.Count > _pos)
                    _queue.Dequeue();
                return _queue.Peek();
            }
        }
        
        public class KthLargestList
        {
            private  readonly int _pos;
            private readonly List<int> _nums;
            public KthLargestList(int k, int[] nums)
            {
                _pos = k;
                _nums = new List<int>(nums);
                _nums.Sort((a, b) => b - a);
            }

            public int Add(int val)
            {
                int index = -1;
                for (int i = 0; i < _nums.Count; i++){
                    if (_nums[i] < val) {
                        index = i;
                        _nums.Insert(i, val);
                        break;
                    }
                }
                if (index == -1) _nums.Add(val);
                return _nums[_pos - 1];
            }
        }

    }
}