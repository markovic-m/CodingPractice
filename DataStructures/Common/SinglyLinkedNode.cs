using System;

namespace CodingPractice.DataStructures.Common
{
    public class SinglyLinkedNode<T>
    {
        public readonly T data;
        public SinglyLinkedNode<T> next;

        public SinglyLinkedNode(T nodeData, SinglyLinkedNode<T> nextPointer)
        {
            data = nodeData;
            next = nextPointer;
        }

        internal void Dispose()
        {
            Console.WriteLine($"Safely disposing of nodes data: {data} not to leak any memory");
        }
    }
}
