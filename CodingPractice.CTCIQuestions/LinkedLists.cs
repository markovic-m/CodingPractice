using CodingPractice.DataStructures.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.CTCIQuestions
{
    public class LinkedLists
    {
        public class Node
        {
            public int val;
            public Node next;

            public Node(int nodeVal = 0)
            {
                val = nodeVal;
            }
        }

        public class LinkedList
        {
            public Node head;
        }

        public void RemoveDups(LinkedList list)
        {
            if (list == null || list.head == null)
                return;
            var dict = new Dictionary<int, int>();
            var tempHead = list.head;
            Node follower = null;
            while (tempHead != null)
            {
                if (dict.ContainsKey(tempHead.val))
                {
                    var temp = tempHead;
                    follower.next = tempHead.next;
                    temp.next = null;
                    tempHead = tempHead.next;
                    //temp.Dispose();
                }
                else
                {
                    dict.Add(tempHead.val, tempHead.val);
                    follower = tempHead;
                    tempHead = tempHead.next;
                }
            }
        }

        public void RemoveDupsWithoutBuffer(LinkedList list)
        {
            if (list == null || list.head == null)
            {
                return;
            }

            var firstTraverser = list.head;

            while (firstTraverser != null)
            {
                Node follower = firstTraverser;
                var secondTraverser = firstTraverser.next;

                while (secondTraverser != null)
                {
                    if (firstTraverser.val == secondTraverser.val)
                    {
                        var temp = secondTraverser;
                        follower.next = secondTraverser.next;
                        temp.next = null;
                        //temp.Dispose();
                    }
                    follower = secondTraverser;
                    secondTraverser = secondTraverser.next;
                }
                firstTraverser = firstTraverser.next;
            }
        }

        public Node ReturnKthToLast(LinkedList list, int k)
        {
            if (list == null || list.head == null || (list.head.next == null && k != 0) || k < 0)
                return null;
            //reverse list

            Node previous = null;
            Node current = list.head;
            Node next;

            while (current != null)
            {
                next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }
            list.head = previous;

            var tempHead = list.head;
            for (int i = 0; i < k && tempHead != null; i++)
            {
                tempHead = tempHead.next;
            }
            return tempHead;
        }

        public void Partition(LinkedList list, int val)
        {
            if (list == null || list.head == null)
                return;

            Node beforeListHead = null;
            Node beforeListTail = null;
            Node afterListHead = null;
            Node afterListTail = null;

            while (list.head != null)
            {
                var temp = list.head;
                list.head = list.head.next;
                temp.next = null;

                if (temp.val == val)
                {
                    if (afterListHead == null)
                    {
                        afterListHead = temp;
                        afterListTail = temp;
                    }
                    else
                    {
                        var tempHead = afterListHead;
                        afterListHead = temp;
                        temp.next = tempHead;
                    }
                }
                else if (temp.val < val)
                {
                    if (beforeListHead == null)
                    {
                        beforeListHead = temp;
                        beforeListTail = temp;
                    }
                    else
                    {
                        var tempHead = beforeListHead;
                        beforeListHead = temp;
                        temp.next = tempHead;
                    }
                }
                else if (temp.val > val)
                {
                    if (afterListTail == null)
                    {
                        afterListHead = temp;
                        afterListTail = temp;
                    }
                    else
                    {
                        afterListTail.next = temp;
                    }
                }
            }
            if (beforeListTail == null)
            {
                list.head = afterListHead;
            }
            else
            {
                beforeListTail.next = afterListHead;
                list.head = beforeListHead;
            }
        }

        public LinkedList Add(LinkedList list1, LinkedList list2)
        {
            if (list1 == null || list1.head == null)
            {
                return list2;
            }
            if (list2 == null || list2.head == null)
            {
                return list1;
            }
            LinkedList resultingList = new LinkedList();
            var current = resultingList.head;
            var tempHead1 = list1.head;
            var tempHead2 = list2.head;
            int carry = 0;
            while (tempHead1 != null || tempHead2 != null || carry == 1)
            {
                int s = 0;
                s += tempHead1?.val ?? 0;// == null ? 0 : tempHead1.val;
                s += tempHead2?.val ?? 0;// == null ? 0 : tempHead2.val;
                s += carry;
                var temp = new Node(s % 10);
                current.next = temp;
                current = current.next;
                carry = s > 9 ? 1 : 0;
                tempHead1 = tempHead1?.next;
                tempHead2 = tempHead2?.next;
            }
            return resultingList;
        }

        public LinkedList Add2(LinkedList list1, LinkedList list2)
        {
            if (list1 == null || list1.head == null)
            {
                return list2;
            }
            if (list2 == null || list2.head == null)
            {
                return list1;
            }
            LinkedList resultingList = new LinkedList();
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            var tempHead1 = list1.head;
            var tempHead2 = list2.head;
            int carry = 0;
            while (tempHead1 != null || tempHead2 != null)
            {
                if (tempHead1 != null)
                {
                    stack1.Push(tempHead1.val);
                }
                tempHead1 = tempHead1?.next;

                if (tempHead2 != null)
                {
                    stack2.Push(tempHead2.val);
                }
                tempHead2 = tempHead2?.next;
            }

            while (stack1.Count > 0 || stack2.Count > 0 || carry > 0)
            {
                int sum = 0;
                if (stack1.Count > 0)
                {
                    sum += stack1.Pop();
                }
                if (stack2.Count > 0)
                {
                    sum += stack2.Pop();
                }
                sum += carry;
                var temp = resultingList.head;
                resultingList.head = new Node(sum % 10);
                resultingList.head.next = temp;
                carry = sum > 9 ? 1 : 0;
            }
            return resultingList;
        }


        public bool IsPalindrome(LinkedList list)
        {
            if (list == null || list.head == null)
            {
                return false;//true?
            }
            var dict = new Dictionary<int, int>();
            var tempHead = list.head;
            while (tempHead != null)
            {
                if (!dict.ContainsKey(tempHead.val))
                {
                    dict.Add(tempHead.val, 1);
                }
                else
                {
                    dict[tempHead.val]++;
                }
                tempHead = tempHead.next;
            }

            var firstStrike = false;
            foreach (var item in dict)
            {
                if (item.Value % 2 != 0)
                {
                    if (firstStrike)
                        return false;
                    firstStrike = true;
                }
            }
            return true;
        }
    }
}
