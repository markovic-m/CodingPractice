using System;

namespace CodingPractice.CTCIQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            ArraysAndStrings varaa = new ArraysAndStrings();
            var a1 = varaa.IsUnique("");
            var a2 = varaa.IsUnique("123asdert");
            var a3 = varaa.IsUnique("1111");
            var a4 = varaa.IsUnique("123asdert1");
            var a5 = varaa.IsUnique("~~");

            var a6 = varaa.IsUnique2("");
            var a7 = varaa.IsUnique2("123asdert");
            var a8 = varaa.IsUnique2("1111");
            var a9 = varaa.IsUnique2("123asdert1");
            var a10 = varaa.IsUnique2("~~");

            var a11 = varaa.CheckPermutation("", "");
            var a12 = varaa.CheckPermutation(" ", " ");
            var a13 = varaa.CheckPermutation("a", "a");
            var a14 = varaa.CheckPermutation("asdasd", "dsadsa");
            var a15 = varaa.CheckPermutation("asdasd", "qweqwe");
            var a16 = varaa.CheckPermutation("qweewqqwe", "qweewqqwe");
            var a17 = varaa.CheckPermutation("a", "ase");

            var a18 = varaa.URLify(new char[] { });
            var a19 = varaa.URLify(new char[] { ' ', ' ', ' ' });
            var a20 = varaa.URLify(new char[] { 'a' });
            var a21 = varaa.URLify(new char[] { 'a', ' ', 'a', ' ', ' ' });
            var a22 = varaa.URLify(new char[] { ' ', 'a', ' ', ' ', ' ', ' ', ' ' });
            var a23 = varaa.URLify(new char[] { 'a', ' ', ' ', ' ' });
            var a24 = varaa.URLify(new char[] { ' ', 'a', ' ', ' ' });
            var a25 = varaa.URLify(new char[] { 'a', 'd', 'm', ' ', 'i', 'n', ' ', ' ' });


            var a26 = varaa.IsPalindromePermutation("");
            var a27 = varaa.IsPalindromePermutation(" ");
            var a28 = varaa.IsPalindromePermutation("  ");
            var a29 = varaa.IsPalindromePermutation("a");
            var a30 = varaa.IsPalindromePermutation("aa");
            var a31 = varaa.IsPalindromePermutation("aaa");
            var a32 = varaa.IsPalindromePermutation("bav");
            var a33 = varaa.IsPalindromePermutation("caba");

            var a34 = varaa.IsOneAway("pale", "ple");
            var a35 = varaa.IsOneAway("pale", "pales");
            var a36 = varaa.IsOneAway("pale", "bale");
            var a37 = varaa.IsOneAway("pale", "bake");

            Console.ReadLine();
        }
    }
}
