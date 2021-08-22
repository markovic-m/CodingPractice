using CodingPractice.DataStructures.Common;
using System;

namespace CodingPractice.DataStructures.LinkedList
{
    public class DoublyLinkedList<T>
    {
        DoublyLinkedNode<T> head;
        DoublyLinkedNode<T> tail;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
        }

        public void InsertAtHead(T item)
        {
            var newNode = new DoublyLinkedNode<T>(item, null, null);
            if (head == null)
            {
                tail = head = newNode;
            }
            else
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }
        }

        public void InsertAtTail(T item)
        {
            var newNode = new DoublyLinkedNode<T>(item, null, null);
            var tempHead = head;
            while (tempHead.next != null)
            {
                tempHead = tempHead.next;
            }
            tempHead.next = newNode;
            newNode.prev = tempHead;
            tail = newNode;
        }

        public void Delete(T item)
        {
            if (head == null) return;

            if (head.data.Equals(item))
            {
                DeleteAtHead();
                return;
            }

            var traverser = head.next;
            var follower = head;
            while (traverser != null)
            {
                if (traverser.data.Equals(item))
                {
                    var tempTrav = traverser;
                    follower.next = traverser.next;
                    follower.next.prev = follower;
                    tempTrav.next = null;
                    tempTrav.prev = null;
                    tempTrav.Dispose();
                    return;
                }
                else
                {
                    follower = traverser;
                    traverser = traverser.next;
                }
            }
        }

        public void DeleteAtTail()
        {
            if (head == null)
                return;

            var tempHead = head;
            while (tempHead.next.next != null)
            {
                tempHead = tempHead.next;
            }
            var temp = tempHead.next;
            tail = tempHead;
            tail.next = null;
            temp.next = null;
            temp.prev = null;
            temp.Dispose();
        }

        public void DeleteAtHead()
        {
            if (head == null)
                return;

            var temp = head;
            head = head.next;
            head.prev = null;
            temp.next = null;
            temp.Dispose();
        }
        public bool InsertAtIndex(T item, int index)
        {
            var newNode = new DoublyLinkedNode<T>(item, null, null);
            if (head == null)
            {
                if (index == 0)
                {
                    head = tail = newNode;
                    return true;
                }
                else return false;
            }

            if (index == 0)
            {
                InsertAtHead(item);
                return true;
            }

            var tempHead = head;
            for (int i = 0; i < index - 1; i++)
            {
                tempHead = tempHead.next;
            }

            if (tempHead.next == null)
            {
                InsertAtTail(item);
            }
            else
            {
                var tmp = tempHead.next;
                tempHead.next = newNode;
                newNode.prev = tempHead;
                newNode.next = tmp;
                tmp.prev = newNode;
            }
            return true;
        }

        public int Find(T item)
        {
            return -1;
        }


        public void Print()
        {
            Console.WriteLine("DoublyLinkedList: ");
            if (head is null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                var temphead = head;
                while (temphead != null)
                {
                    Console.WriteLine(temphead.data);
                    temphead = temphead.next;
                }
            }
        }

        public void ReversePrint()
        {
            Console.WriteLine("Reversed DoublyLinkedList: ");
            if (head is null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                var tempTail = tail;
                while (tempTail != null)
                {
                    Console.WriteLine(tempTail.data);
                    tempTail = tempTail.prev;
                }
            }
        }
    }
}
