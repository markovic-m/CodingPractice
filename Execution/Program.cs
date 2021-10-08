using CodingPractice.DataStructures.Array;
using CodingPractice.DataStructures.LinkedList;
using CodingPractice.DataStructures.Queue;
using CodingPractice.DataStructures.Stack;
using CodingPractice.DataStructures.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Execution
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            if (s.Length == 1)
                return 1;
            var hs = new HashSet<char>();
            var startInd = 0;
            var endInd = 0;
            var maxLength = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (!hs.Contains(s[i]))
                {
                    hs.Add(s[i]);
                    endInd++;
                    var max = endInd - startInd;
                    if (max > maxLength)
                        maxLength = max;
                }
                else
                {
                    endInd++;
                    do
                    {
                        if (s[startInd] != s[i])
                            hs.Remove(s[startInd]);
                        startInd++;
                    }
                    while (s[startInd] != s[i]);
                    startInd++;
                }
            }
            return maxLength;
        }
    }
    public class LRUCache
    {
        class Node
        {
            public int val;
            public int key;
            public Node next;
            public Node prev;
            public Node(int key, int value, Node nextNode, Node prevNode)
            {
                this.key = key;
                val = value;
                next = nextNode;
                prev = prevNode;
            }
        }
        Node head;
        Node tail;
        int capacity = 0;
        Dictionary<int, Node> dict;
        public LRUCache(int capacity)
        {
            dict = new Dictionary<int, Node>(capacity);
            this.capacity = capacity;
        }

        public int Get(int key)
        {
            char a = (char)97;
            if (dict.TryGetValue(key, out Node valueFound))
            {
                if (valueFound.next != null)
                    valueFound.next.prev = valueFound.prev;
                else
                    RemoveFromTail();
                if (valueFound.prev != null)
                    valueFound.prev.next = valueFound.next;
                else
                    RemoveFromHead();

                AddToHead(key, valueFound.val);
                return valueFound.val;
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            if (dict.ContainsKey(key))
            {
                if (dict[key].prev != null)
                {
                    dict[key].prev.next = dict[key].next;
                }
                else
                {
                    RemoveFromHead();
                }
                if (dict[key].next != null)
                {
                    dict[key].next.prev = dict[key].prev;
                }
                else
                {
                    RemoveFromTail();
                }
                dict[key] = AddToHead(key, value);
                return;
            }

            if (dict.Count == capacity)
            {
                dict.Remove(tail.key);
                RemoveFromTail();
                dict.Add(key, AddToHead(key, value));
            }
            else
            {
                dict.Add(key, AddToHead(key, value));
            }

        }

        private Node AddToHead(int key, int val)
        {
            Node tempNode = null;
            if (head == null)
            {
                tempNode = new Node(key, val, null, null);
                head = tempNode;
                tail = tempNode;
            }
            else
            {
                tempNode = new Node(key, val, head, null);
                head.prev = tempNode;
                head = tempNode;
            }
            return tempNode;
        }
        private void RemoveFromTail()
        {
            tail = tail.prev;
            if (tail != null)
                tail.next = null;
        }
        private void RemoveFromHead()
        {
            head = head.next;
            if (head != null)
                head.prev = null;
        }
    }

    /**
     * Your LRUCache object will be instantiated and called as such:
     * LRUCache obj = new LRUCache(capacity);
     * int param_1 = obj.Get(key);
     * obj.Put(key,value);
     */
    class Program
    {
        static void Main(string[] args)
        {


            private List<int> swap(List<int> lst, int i, int j)
            {
                var temp = list[i];
                list[i] = list[j];
                list[j] = temp;
                return list;
            }


            Solution sadsas = new Solution();
            sadsas.LengthOfLongestSubstring("pwwkew");
            int capacity = 10;
            LRUCache obj = new LRUCache(capacity);
            obj.Put(10, 13);
            obj.Put(3, 17);
            obj.Put(6, 11);
            obj.Put(10, 5);
            obj.Put(0, 10);
            int param_1 = obj.Get(13);
            obj.Put(2, 19);
            int param_3 = obj.Get(2);
            int param_2 = obj.Get(3);
            int param_4 = obj.Get(4);
            int param_5 = obj.Get(5);
            int param_6 = obj.Get(6);
            obj.Put(6, 11);
            obj.Put(6, 11);
            obj.Put(6, 11);
            obj.Put(6, 11);
            obj.Put(6, 11);
            obj.Put(6, 11);
            obj.Put(6, 11);
            obj.Put(6, 11);
            int param2 = obj.Get(2);
            obj.Put(4, 4);
            int param1 = obj.Get(1);
            int param3 = obj.Get(3);
            int para4 = obj.Get(4);
            //TestDynamicArray();
            //TestSinglyLinkedList();
            //TestDoublyLinkedList();
            //TestDynamicArrayStack();
            //TestLinkedListStack();
            //TestQeueue();
            TestBST();
            Console.Read();
        }
        public static void TestBST()
        {
            var tree = new BinarySearchTree();
            tree.Insert(32);
            tree.Insert(11, tree.root);
            tree.Insert(43, tree.root);
            tree.Insert(21, tree.root);
            tree.Insert(7, tree.root);
            tree.Insert(33, tree.root);
            tree.Insert(9, tree.root);
            tree.Insert(46, tree.root);
            tree.Insert(12, tree.root);
            tree.Print();
        }

        public static void TestQeueue()
        {
            var queue = new CodingPractice.DataStructures.Queue.Queue<int>();
            queue.Print();
            queue.Enqueue(1);
            queue.Print();
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);

            queue.Print();
            Console.WriteLine(queue.Dequeue().ToString());
            Console.WriteLine(queue.Dequeue().ToString());
            Console.WriteLine(queue.Dequeue().ToString());
            Console.WriteLine(queue.Dequeue().ToString());
            Console.WriteLine(queue.Dequeue().ToString());
            Console.WriteLine(queue.Dequeue().ToString());
            queue.Print();
        }

        public static void TestLinkedListStack()
        {
            var linkedListStack = new LinkedListStack<int>();

            linkedListStack.Push(9);
            linkedListStack.Push(8);
            linkedListStack.Push(7);
            linkedListStack.Push(6);
            linkedListStack.Push(5);
            linkedListStack.Push(4);
            linkedListStack.Push(3);
            linkedListStack.Push(2);
            linkedListStack.Push(1);
            linkedListStack.Push(0);

            linkedListStack.Print();


            linkedListStack.Pop();
            linkedListStack.Pop();
            linkedListStack.Pop();

            linkedListStack.Print();
            linkedListStack.Pop();

            linkedListStack.Print();
        }

        public static void TestDynamicArrayStack()
        {
            var dynamicArrayStack = new DynamicArrayStack<int>();

            dynamicArrayStack.Push(11);
            dynamicArrayStack.Push(10);
            dynamicArrayStack.Push(9);
            dynamicArrayStack.Push(8);
            dynamicArrayStack.Push(7);
            dynamicArrayStack.Push(6);
            dynamicArrayStack.Push(5);
            dynamicArrayStack.Push(4);
            dynamicArrayStack.Push(3);
            dynamicArrayStack.Push(2);
            dynamicArrayStack.Push(1);
            dynamicArrayStack.Push(0);
            dynamicArrayStack.Print();


            dynamicArrayStack.Pop();
            dynamicArrayStack.Pop();
            dynamicArrayStack.Print();
            dynamicArrayStack.Pop();
            dynamicArrayStack.Pop();
            dynamicArrayStack.Print();
            dynamicArrayStack.Pop();
            dynamicArrayStack.Pop();
            dynamicArrayStack.Pop();
            dynamicArrayStack.Pop();
            dynamicArrayStack.Print();
            dynamicArrayStack.Push(7);
            dynamicArrayStack.Print();
        }
        public static void TestDoublyLinkedList()
        {
            var doublyLinkedList = new DoublyLinkedList<int>();

            doublyLinkedList.Print();
            doublyLinkedList.ReversePrint();

            doublyLinkedList.InsertAtIndex(3, 0);
            doublyLinkedList.InsertAtIndex(2, 0);
            doublyLinkedList.InsertAtIndex(1, 0);
            doublyLinkedList.InsertAtIndex(6, 3);
            doublyLinkedList.InsertAtIndex(7, 4);
            doublyLinkedList.InsertAtIndex(4, 3);
            doublyLinkedList.InsertAtIndex(5, 4);

            //doublyLinkedList.InsertAtHead(3);
            //doublyLinkedList.InsertAtHead(2);
            //doublyLinkedList.InsertAtHead(1);
            //doublyLinkedList.InsertAtTail(4);
            //doublyLinkedList.InsertAtTail(5);
            //doublyLinkedList.InsertAtTail(6);
            doublyLinkedList.Print();
            doublyLinkedList.ReversePrint();

            doublyLinkedList.DeleteAtHead();
            doublyLinkedList.Print();
            doublyLinkedList.ReversePrint();

            doublyLinkedList.Delete(4);
            doublyLinkedList.Print();
            doublyLinkedList.ReversePrint();

            doublyLinkedList.DeleteAtTail();
            doublyLinkedList.Print();
            doublyLinkedList.ReversePrint();

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

            singlyLinkedList.InsertAtIndex(3, index: 0);
            singlyLinkedList.InsertAtHead(2);
            singlyLinkedList.InsertAtHead(1);
            singlyLinkedList.InsertAtIndex(4, index: 3);
            singlyLinkedList.InsertAtTail(6);
            singlyLinkedList.InsertAtTail(7);
            singlyLinkedList.InsertAtIndex(5, index: 4);
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
