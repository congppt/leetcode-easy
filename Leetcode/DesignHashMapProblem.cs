using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leetcode
{
    public class DesignHashMapProblem
    {
        public class MyHashMap
        {
            private int[] _map;
            public MyHashMap()
            {
                _map = new int[1000001];
            }

            public void Put(int key, int value)
            {
                _map[key] = value + 1;
            }

            public int Get(int key)
            {
                if (_map[key] >= 1) return _map[key] - 1;
                return -1;
            }

            public void Remove(int key)
            {
                _map[key] = 0;
            }
        }
    }
}