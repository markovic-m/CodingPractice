using System;

namespace CodingPractice.DataStructures.LinkedList
{
    public class DoublyLinkedNode<T>
    {
        public readonly T data;
        public DoublyLinkedNode<T> prev;
        public DoublyLinkedNode<T> next;

        public DoublyLinkedNode(T nodeData, DoublyLinkedNode<T> prevPointer, DoublyLinkedNode<T> nextPointer)
        {
            data = nodeData;
            next = nextPointer;
            prev = prevPointer;
        }

        internal void Dispose()
        {
            Console.WriteLine($"Safely disposing of nodes data: {data} not to leak any memory");
        }
    }
}
