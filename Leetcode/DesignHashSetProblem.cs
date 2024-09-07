using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class DesignHashSetProblem
    {
        public class MyHashSet
        {
            private bool[] _dict;
            public MyHashSet()
            {
                _dict = new bool[1000001];
            }

            public void Add(int key)
            {
                _dict[key] = true;
            }

            public void Remove(int key)
            {
                _dict[key] = false;
            }

            public bool Contains(int key)
            {
                return _dict[key];
            }
        }
    }
}