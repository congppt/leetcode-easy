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
                _dict = new bool[100];
            }

            public void Add(int key)
            {
                if (key >= _dict.Length) Resize(key);
                _dict[key] = true;
            }

            public void Remove(int key)
            {
                if (key >= _dict.Length) return;
                _dict[key] = false;
            }

            public bool Contains(int key)
            {
                if (key >= _dict.Length) return false;
                return _dict[key];
            }
            private void Resize(int mid){
                bool[] temp = _dict;
                _dict = new bool[mid * 2];
                for (int i = 0; i < temp.Length; i++)
                    if (temp[i]) Add(i);
            }
        }
    }
}