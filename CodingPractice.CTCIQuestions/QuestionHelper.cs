using System;

namespace CodingPractice.CTCIQuestions
{
    public static class QuestionHelper
    {
        public static void PrintMatrix(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", mat[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.Write(Environment.NewLine + Environment.NewLine);
        }
    }
}
