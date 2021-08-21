using CodingPractice.DataStructures.Array;
using CodingPractice.DataStructures.LinkedList;
using System;

namespace Execution
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDynamicArray();
            TestSinglyLinkedList();
            TestDoublyLinkedList();
            Console.Read();
        }

        public static void TestDoublyLinkedList()
        {
            var doublyLinkedList = new DoublyLinkedList<int>();

            doublyLinkedList.Print();

            doublyLinkedList.InsertAtHead(3);
            doublyLinkedList.InsertAtHead(2);
            doublyLinkedList.InsertAtHead(1);
            doublyLinkedList.InsertAtTail(4);
            doublyLinkedList.InsertAtTail(5);
            doublyLinkedList.InsertAtTail(6);
            doublyLinkedList.Print();

            doublyLinkedList.DeleteAtHead();
            doublyLinkedList.Print();

            doublyLinkedList.Delete(4);
            doublyLinkedList.Print();

            doublyLinkedList.DeleteAtTail();
            doublyLinkedList.Print();

        }

        public static void TestDynamicArray()
        {
            DynamicArray<int> array = new DynamicArray<int>();
            array.Print();
            array.Insert(1);
            array.Insert(2);
            array.Insert(3);
            array.Insert(4);
            array.Insert(5);
            array.Insert(6);
            array.Insert(7);
            array.Insert(8);
            array.Insert(9);
            array.Insert(10);
            array.Insert(11);
            array.Insert(12);
            array.Delete(2);
            var foundIndex = array.Find(2);
            var foundIndex2 = array.Find(3);
            Console.WriteLine(foundIndex);
            Console.WriteLine(foundIndex2);
            array.Print();
        }

        public static void TestSinglyLinkedList()
        {
            var singlyLinkedList = new SinglyLinkedList<int>();

            singlyLinkedList.Print();

            singlyLinkedList.InsertAtHead(3);
            singlyLinkedList.InsertAtHead(2);
            singlyLinkedList.InsertAtHead(1);
            singlyLinkedList.InsertAtTail(4);
            singlyLinkedList.InsertAtTail(5);
            singlyLinkedList.InsertAtTail(6);
            singlyLinkedList.Print();

            singlyLinkedList.DeleteAtHead();
            singlyLinkedList.Print();

            singlyLinkedList.Delete(4);
            singlyLinkedList.Print();

            singlyLinkedList.DeleteAtTail();
            singlyLinkedList.Print();

        }
    }
}
