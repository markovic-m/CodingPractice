using System;

namespace CodingPractice.DataStructures.Array
{
    public class DynamicArray<T>
    {
        private const int DEFAULT_STARTING_CAPACITY = 8;

        private int _internalCapacity;
        private int _elementCount;
        private T[] _internalStaticArray;

        public DynamicArray()
        {
            _internalCapacity = DEFAULT_STARTING_CAPACITY;
            _internalStaticArray = new T[_internalCapacity];
            _elementCount = 0;
        }

        public DynamicArray(int capacity)
        {
            _internalStaticArray = new T[capacity];
            _elementCount = 0;
        }

        public void Insert(T item)
        {
            if (item is null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                if (_elementCount + 1 > _internalCapacity)
                {
                    _internalCapacity = 2 * _internalCapacity;
                    var tempArray = new T[_internalCapacity];
                    for (int i = 0; i < _elementCount; i++)
                    {
                        tempArray[i] = _internalStaticArray[i];
                    }
                    tempArray[_elementCount++] = item;
                    _internalStaticArray = tempArray;
                }
                else
                {
                    _internalStaticArray[_elementCount++] = item;
                }
            }
        }

        public void Delete(T item)
        {
            bool found = false;
            if (_internalStaticArray[_elementCount - 1].Equals(item))
            {
                _internalStaticArray[_elementCount - 1] = default;
                _elementCount--;
                return;
            }
            var count = _elementCount - 1;
            for (int i = 0; i < count; i++)
            {
                if (!found && _internalStaticArray[i].Equals(item))
                {
                    found = true;
                    _elementCount--;
                }
                if (found)
                {
                    var tmp = _internalStaticArray[i];
                    _internalStaticArray[i] = _internalStaticArray[i + 1];
                }
            }
        }

        public int Find(T item)
        {
            for (int i = 0; i < _elementCount; i++)
            {
                if (_internalStaticArray[i].Equals(item))
                    return i;
            }
            return -1;
        }

        public void Print()
        {
            Console.WriteLine("ArrayStart");
            for (int i = 0; i < _elementCount; i++)
            {
                Console.WriteLine(_internalStaticArray[i]);
            }
        }
    }
}
