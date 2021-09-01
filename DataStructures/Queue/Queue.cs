using CodingPractice.DataStructures.LinkedList;
using System;

namespace CodingPractice.DataStructures.Queue
{
    public class Queue<T>
    {
        private DoublyLinkedList<T> list;

        public Queue()
        {
            list = new DoublyLinkedList<T>();
        }

        public void Enqueue(T item)
        {
            list.InsertAtHead(item);
        }

        public T Dequeue()
        {
            var elem = list.tail;
            list.DeleteAtTailEfficient();
            return elem.data;
        }

        public void Print()
        {
            if (list != null && list.ElementCount > 0)
            {
                Console.WriteLine("Queue");
                list.ReversePrint();
            }
            else
            {
                Console.WriteLine("Queue is empty");
            }
        }
    }
}
