using System.Collections;
using System.Collections.Generic;
using System.Text;

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
                if (i == s1.Length || j == s2.Length)
                {
                    if (firstStrike)
                        return false;
                    else return true;
                }

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

        public string Compression(string s)
        {
            if (s == null || s.Length == 0)
                return s;

            StringBuilder str = new StringBuilder();
            char lastChar = s[0];
            int currentCharCount = 1;
            str.Append(s[0]);
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == lastChar)
                {
                    currentCharCount++;
                }
                else
                {
                    if (currentCharCount > 0)
                    {
                        str.Append(currentCharCount);
                    }
                    currentCharCount = 1;
                    lastChar = s[i];
                    str.Append(lastChar);
                }

            }
            str.Append(currentCharCount);

            return str.Length > 0 && str.Length < s.Length ? str.ToString() : s;
        }

        public int[,] RotateMatrix(int[,] matrix)
        {
            void RotateLayer(int layerNumber)
            {
                var length = matrix.GetLength(1) - (layerNumber * 2);
                if (length == 1)
                    return;

                int[] helperArray = new int[length];
                for (int j = layerNumber; j < length; j++)
                {
                    helperArray[j] = matrix[length - 1 - layerNumber, j];
                    matrix[length - 1 + layerNumber, j] = matrix[j, layerNumber];
                }
                for (int j = layerNumber; j < length; j++)
                {
                    matrix[j, layerNumber] = matrix[layerNumber, length - 1 + layerNumber - j];
                }
                for (int j = layerNumber; j < length; j++)
                {
                    matrix[layerNumber, length + layerNumber - 1 - j] = matrix[length + layerNumber - 1 - j, length - 1];
                }
                for (int j = layerNumber; j < length; j++)
                {
                    matrix[length - 1 + layerNumber - j, length + layerNumber - 1] = helperArray[j];
                }
            }

            if (matrix.GetLength(1) <= 1)
            {
                return matrix;
            }

            for (int i = 0; i < matrix.GetLength(1) / 2; i++)
            {
                RotateLayer(i);
            }
            return matrix;
        }

        public void NullifyMatrix(int[,] matrix)
        {
            Dictionary<int, int> rows = new Dictionary<int, int>();
            Dictionary<int, int> columns = new Dictionary<int, int>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        if (!rows.ContainsKey(i))
                            rows.Add(i, i);
                        if (!columns.ContainsKey(j))
                            columns.Add(j, j);
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (columns.ContainsKey(j))
                    {
                        matrix[i, j] = 0;
                    }
                    if (rows.ContainsKey(i))
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
        }

        public bool IsRotatedString(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            int tracker = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[tracker] == s2[i])
                {
                    tracker++;
                }
                else
                {
                    tracker = 0;
                }
            }
            //if (s1.Contains(s2.Substring()))
            //{

            //}
            return false;
        }
    }
}
