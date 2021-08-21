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
                head = newNode;
            }
            else
            {
                newNode.next = head;
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
            tempHead.next = null;
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
            temp.next = null;
            temp.Dispose();
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
