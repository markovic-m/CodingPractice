using CodingPractice.DataStructures.Common;
using System;

namespace CodingPractice.DataStructures.LinkedList
{
    public class SinglyLinkedList<T>
    {
        public SinglyLinkedNode<T> head;

        public SinglyLinkedList()
        {
            head = null;
        }

        public void Delete(T item)
        {
            if (head is null)
                return;

            if (head.data.Equals(item))
            {
                DeleteAtHead();
                return;
            }

            var follower = head;
            while (follower.next != null)
            {
                var traverser = follower.next;
                if (traverser.data.Equals(item))
                {
                    follower.next = traverser.next;
                    traverser.next = null;
                    traverser.Dispose();
                    return;
                }
                else
                {
                    follower = follower.next;
                }
            }
        }

        public void DeleteAtTail()
        {
            var tempHead = head;
            while (tempHead.next.next != null)
            {
                tempHead = tempHead.next;
            }
            var temp = tempHead.next;
            tempHead.next = null;
            temp.Dispose();
        }

        public void DeleteAtHead()
        {
            if (head == null)
                return;
            var temphead = head.next;
            head.next = null;
            head.Dispose();
            head = temphead;
        }

        public bool InsertAtIndex(T item, int index)
        {
            if (head == null)
            {
                if (index == 0)
                {
                    InsertAtHead(item);
                    return true;
                }
                else
                {
                    return false;
                }
            }

            var tempHead = head;
            for (int i = 0; i < index - 1; i++)
            {
                if (tempHead == null) return false;

                tempHead = tempHead.next;
            }
            var node = new SinglyLinkedNode<T>(item, null);
            if (tempHead.next == null)
            {
                tempHead.next = node;
                return true;
            }
            else
            {
                var tmp = tempHead.next;
                tempHead.next = node;
                node.next = tmp;
            }
            return true;
        }


        public void InsertAtTail(T item)
        {
            var node = new SinglyLinkedNode<T>(item, null);
            if (head == null)
            {
                head = node;
                return;
            }
            var tempHead = head;
            while (tempHead.next != null)
            {
                tempHead = tempHead.next;
            }
            tempHead.next = node;
        }

        public void InsertAtHead(T item)
        {
            var node = new SinglyLinkedNode<T>(item, head);
            head = node;
        }

        public void Print()
        {
            Console.WriteLine("SinglyLinkedList: ");
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
    }
}
