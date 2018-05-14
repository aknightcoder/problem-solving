using System.Collections.Generic;
using System.Linq;

namespace problemsolving.HashTable
{
    public class TrivialHashTable<T> where T : IKeyed
    {
        private const int TableSize = 100;

        private readonly LinkedList<T>[] _array;

        public TrivialHashTable()
        {
            _array = new LinkedList<T>[TableSize];

            InitializeArray();
        }

        public void Add(T value)
        {
            var idx = GetHashIndex(value.Key);

            var values = _array[idx];

            if (!values.Contains(value))
                values.AddLast(value);
        }

        public void Remove(T value)
        {
            var idx = GetHashIndex(value.Key);

            var values = _array[idx];

            if (values.Contains(value))
                values.Remove(value);
        }

        public T Get(int key){
            return Find(key);
        }

        private T Find(int key)
        {
            var idx = GetHashIndex(key);

            var values = _array[idx];

            if (values == null || !values.Any()) return default(T);

            foreach(var value in values)
            {
                if (value.Key == key)
                    return value;
            }

            return default(T);
        }

        private int GetHashIndex(int key)
        {
            return key % TableSize;
        }

        private void InitializeArray()
        {
            for (int i = 0; i < _array.Length; i++){
                _array[i] = new LinkedList<T>();
            }
        }
    }
}
