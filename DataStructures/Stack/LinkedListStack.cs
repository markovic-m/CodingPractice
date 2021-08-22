using CodingPractice.DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.DataStructures.Stack
{
    public class LinkedListStack<T>
    {
        private SinglyLinkedList<T> _internalList;
        private int _elementCount;
        public object print;

        public LinkedListStack()
        {
            _elementCount = 0;
            _internalList = new SinglyLinkedList<T>();
        }


        public void Push(T item)
        {
            _internalList.InsertAtHead(item);
            _elementCount++;
        }

        public T Pop()
        {
            var temp = _internalList.head;
            _internalList.DeleteAtHead();
            _elementCount--;
            return temp.data;
        }

        public void Print()
        {
            if (_internalList == null || _internalList.head == null || _elementCount == 0)
            {
                Console.WriteLine("LinkedListStack is empty");
                return;
            }
            var tempCount = _elementCount - 1;
            Console.WriteLine("LinkedListStack: top to bottom");
            var tempHead = _internalList.head;
            while (tempCount >= 0)
            {
                Console.WriteLine(tempHead.data);
                tempHead = tempHead.next;
                tempCount--;
            }
        }
    }
}
