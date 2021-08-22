using CodingPractice.DataStructures.Array;
using System;

namespace CodingPractice.DataStructures.Stack
{
    public class DynamicArrayStack<T>
    {
        private DynamicArray<T> _internalArray;
        private int _elementCount;

        public DynamicArrayStack()
        {
            _internalArray = new DynamicArray<T>();
            _elementCount = 0;
        }

        public void Push(T item)
        {
            _internalArray.Insert(item);
            _elementCount++;
        }

        public T Pop()
        {
            if (_elementCount == 0)
            { throw new InvalidOperationException(); }
            return _internalArray.Get(--_elementCount);
        }

        public void Print()
        {
            if (_internalArray == null || _elementCount == 0)
            {
                Console.WriteLine("DynamicArrayStack is empty");
                return;
            }
            var tempCount = _elementCount - 1;
            Console.WriteLine("DynamicArrayStack: top to bottom");
            while (tempCount >= 0)
            {
                Console.WriteLine(_internalArray.Get(tempCount--));
            }
        }
    }
}
