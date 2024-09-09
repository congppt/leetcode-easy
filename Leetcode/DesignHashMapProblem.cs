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
            private LinkedList<KeyValuePair<int, int>>[] _map;
            private int _size;
            public MyHashMap()
            {
                _map = new LinkedList<KeyValuePair<int, int>>[2];
            }

            public void Put(int key, int value)
            {
                if (_size == _map.Length) Resize();
                var index = key % _map.Length;
                if (_map[index] == null)
                {
                    _map[index] = new LinkedList<KeyValuePair<int, int>>();
                    _map[index].AddFirst(new KeyValuePair<int, int>(key, value));
                    _size++;
                    return;
                }
                var iter = _map[index].First;
                while (iter != null)
                {
                    if (iter.Value.Key == key)
                    {
                        iter.Value = new KeyValuePair<int, int>(key, value);
                        return;
                    }
                    iter = iter.Next;
                }
                _size++;
                _map[index].AddLast(new KeyValuePair<int, int>(key, value));

            }

            public int Get(int key)
            {
                var index = key % _map.Length;
                if (_map[index] == null) return -1;
                foreach (var pair in _map[index])
                    if (pair.Key == key) return pair.Value;
                return -1;
            }

            public void Remove(int key)
            {
                var index = key % _map.Length;
                if (_map[index] == null) return;
                foreach (var pair in _map[index])
                    if (pair.Key == key)
                    {
                        _map[index].Remove(pair);
                        _size--;
                        break;
                    }

            }
            private void Resize()
            {
                var temp = _map;
                _map = new LinkedList<KeyValuePair<int, int>>[_size * 2];
                _size = 0;
                for (int i = 0; i < temp.Length; i++){
                    if (temp[i] == null) continue;
                    foreach (var pair in temp[i]) Put(pair.Key, pair.Value);
                }
            }
        }
    }
}