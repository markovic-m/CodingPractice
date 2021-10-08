using System;

namespace CodingPractice.CTCIQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArraysAndStrings
            //ArraysAndStrings arraysAndStrings = new ArraysAndStrings();
            //var a1 = arraysAndStrings.IsUnique("");
            //var a2 = arraysAndStrings.IsUnique("123asdert");
            //var a3 = arraysAndStrings.IsUnique("1111");
            //var a4 = arraysAndStrings.IsUnique("123asdert1");
            //var a5 = arraysAndStrings.IsUnique("~~");

            //var a6 = arraysAndStrings.IsUnique2("");
            //var a7 = arraysAndStrings.IsUnique2("123asdert");
            //var a8 = arraysAndStrings.IsUnique2("1111");
            //var a9 = arraysAndStrings.IsUnique2("123asdert1");
            //var a10 = arraysAndStrings.IsUnique2("~~");

            //var a11 = arraysAndStrings.CheckPermutation("", "");
            //var a12 = arraysAndStrings.CheckPermutation(" ", " ");
            //var a13 = arraysAndStrings.CheckPermutation("a", "a");
            //var a14 = arraysAndStrings.CheckPermutation("asdasd", "dsadsa");
            //var a15 = arraysAndStrings.CheckPermutation("asdasd", "qweqwe");
            //var a16 = arraysAndStrings.CheckPermutation("qweewqqwe", "qweewqqwe");
            //var a17 = arraysAndStrings.CheckPermutation("a", "ase");

            //var a18 = arraysAndStrings.URLify(new char[] { });
            //var a19 = arraysAndStrings.URLify(new char[] { ' ', ' ', ' ' });
            //var a20 = arraysAndStrings.URLify(new char[] { 'a' });
            //var a21 = arraysAndStrings.URLify(new char[] { 'a', ' ', 'a', ' ', ' ' });
            //var a22 = arraysAndStrings.URLify(new char[] { ' ', 'a', ' ', ' ', ' ', ' ', ' ' });
            //var a23 = arraysAndStrings.URLify(new char[] { 'a', ' ', ' ', ' ' });
            //var a24 = arraysAndStrings.URLify(new char[] { ' ', 'a', ' ', ' ' });
            //var a25 = arraysAndStrings.URLify(new char[] { 'a', 'd', 'm', ' ', 'i', 'n', ' ', ' ' });


            //var a26 = arraysAndStrings.IsPalindromePermutation("");
            //var a27 = arraysAndStrings.IsPalindromePermutation(" ");
            //var a28 = arraysAndStrings.IsPalindromePermutation("  ");
            //var a29 = arraysAndStrings.IsPalindromePermutation("a");
            //var a30 = arraysAndStrings.IsPalindromePermutation("aa");
            //var a31 = arraysAndStrings.IsPalindromePermutation("aaa");
            //var a32 = arraysAndStrings.IsPalindromePermutation("bav");
            //var a33 = arraysAndStrings.IsPalindromePermutation("caba");

            //var a34 = arraysAndStrings.IsOneAway("pale", "ple");
            //var a35 = arraysAndStrings.IsOneAway("pale", "pales");
            //var a36 = arraysAndStrings.IsOneAway("pale", "bale");
            //var a37 = arraysAndStrings.IsOneAway("pale", "bake");


            //var a38 = arraysAndStrings.Compression("aabcccccaaa");
            //var a39 = arraysAndStrings.Compression("aabcccccccaaa");
            //var a40 = arraysAndStrings.Compression("");
            //var a41 = arraysAndStrings.Compression("a");
            //var a42 = arraysAndStrings.Compression("aa");
            //var a43 = arraysAndStrings.Compression("ababababa");

            //var mat = new int[,] { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } };

            //QuestionHelper.PrintMatrix(mat);
            //arraysAndStrings.RotateMatrix(mat);
            //QuestionHelper.PrintMatrix(mat);



            //var mat2 = new int[,] { { 1, 2, 0, 4, 5 }, { 0, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } };

            //QuestionHelper.PrintMatrix(mat2);
            //arraysAndStrings.NullifyMatrix(mat2);
            //QuestionHelper.PrintMatrix(mat2);
            #endregion

            #region LinkedLists
            LinkedLists linkedLists = new LinkedLists();

            var list = new LinkedLists.LinkedList();
            list.head = new LinkedLists.Node(9);
            list.head.next = new LinkedLists.Node(3);
            list.head.next.next = new LinkedLists.Node(3);
            list.head.next.next.next = new LinkedLists.Node(9);
            list.head.next.next.next.next = new LinkedLists.Node(9);

            var list1 = new LinkedLists.LinkedList();
            list1.head = new LinkedLists.Node(9);
            list1.head.next = new LinkedLists.Node(3);
            list1.head.next.next = new LinkedLists.Node(3);
            list1.head.next.next.next = new LinkedLists.Node(9);

            //linkedLists.RemoveDups(list);
            //linkedLists.RemoveDupsWithoutBuffer(list);
            //var a = linkedLists.ReturnKthToLast(list, 2);
            //linkedLists.Partition(list, 3);
            //var a = linkedLists.Add2(list, list1);
            var a = linkedLists.IsPalindrome(list);
            #endregion

            Console.ReadLine();
            return;
        }
    }
}
