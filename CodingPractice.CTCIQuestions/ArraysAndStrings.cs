using System.Collections;
using System.Collections.Generic;

namespace CodingPractice.CTCIQuestions
{
    public class ArraysAndStrings
    {
        public bool IsUnique(string s)
        {
            Hashtable ht = new Hashtable();
            for (int i = 0; i < s.Length; i++)
            {
                if (!ht.Contains(s[i]))
                {
                    ht.Add(s[i], s[i]);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        //no aditional data struct
        public bool IsUnique2(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                        return false;
                }
            }
            return true;
        }

        public bool CheckPermutation(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            var dict = new Dictionary<char, int>();

            for (int i = 0; i < s1.Length; i++)
            {
                if (dict.ContainsKey(s1[i]))
                {
                    dict[s1[i]] += 1;
                }
                else
                {
                    dict.Add(s1[i], 1);
                }
            }
            for (int j = 0; j < s2.Length; j++)
            {
                if (dict.ContainsKey(s2[j]))
                {
                    if (dict[s2[j]] <= 0)
                    {
                        return false;
                    }
                    else
                    {
                        dict[s2[j]] -= 1;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public char[] URLify(char[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    if (s.Length > 3)
                    {
                        for (int j = s.Length - 1; j > i + 2 && j > 0; j -= 2)
                        {
                            s[j] = s[j - 2];
                            s[j - 1] = s[j - 3];
                        }
                    }
                    s[i] = '%';
                    s[i + 1] = '2';
                    s[i + 2] = '0';
                    i += 2;
                }
            }

            return s;
        }

        public bool IsPalindromePermutation(string s)
        {
            var dict = new Dictionary<char, int>();
            var firstStrike = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    if (!dict.ContainsKey(s[i]))
                    {
                        dict.Add(s[i], 1);
                    }
                    else
                    {
                        dict[s[i]] += 1;
                    }
                }
            }
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

        public bool IsOneAway(string s1, string s2)
        {
            if (s1.Length != s2.Length && s1.Length + 1 != s2.Length && s1.Length != s2.Length + 1)
                return false;

            bool firstStrike = false;
            for (int i = 0, j = 0; i < s1.Length || j < s2.Length; i++, j++)
            {
                if (s1[i] != s2[j])
                {
                    if (firstStrike)
                        return false;
                    if (i == s1.Length - 1 ^ j == s2.Length - 1)
                        return false;
                    if (i == s1.Length - 1 && j == s2.Length - 1)
                        return true;

                    if (s1[i] == s2[j + 1])
                    {
                        j++;
                        firstStrike = true;
                    }
                    if (s1[i + 1] == s2[j])
                    {
                        i++;
                        firstStrike = true;
                    }
                    if (s1[i + 1] == s2[j + 1])
                    {
                        i++;
                        j++;
                        firstStrike = true;
                    }
                }
            }
            return true;
        }
    }
}
