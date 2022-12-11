using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal static class DynamicProgramming
    {
        internal static void Sample()
        {
            //if (word_a[i] == word_b[1])
            //{
            //    cell[i][j] = cell[i - 1][j - 1] + 1;
            //}
            //else
            //{
            //    cell[i][j] = Math.Max(cell[i - 1][j], cell[i][j - 1]);
            //}

            string wordA = "gish";
            String wordB = "fish";

            int[,] cell = new int[wordA.Length, wordB.Length];

            for (int i = 0; i < wordA.Length; i++)
            {
                for (int j = 0; j < wordB.Length; j++)
                {
                    // The letters match
                    if (wordA[i] == wordB[j])
                    {
                        if (i > 0 && j > 0)
                        {
                            cell[i, j] = cell[i - 1, j - 1] + 1;
                        }
                        else
                        {
                            cell[i, j] = 1;
                        }
                    }
                    else
                    {
                        // The letters don't match.
                        cell[i, j] = 0;

                        //if (i == 0 && j > 0)
                        //{
                        //    cell[i, j] = cell[i, j - 1];
                        //}
                        //else if (i > 0 && j == 0)
                        //{
                        //    cell[i, j] = cell[i - 1, j];
                        //}
                        //else if (i > 0 && j > 0)
                        //{
                        //    cell[i, j] = Math.Max(cell[i - 1, j], cell[i, j - 1]);
                        //}
                        //else
                        //{
                        //    cell[i, j] = 0;
                        //}
                    }
                }
            }

            Console.WriteLine(wordA);
            Console.WriteLine(wordB);

            PrintArr(cell);
        }

        private static void PrintArr(int[,] arr)
        {
            int rowCount = arr.GetLength(0);
            int columnCount = arr.GetLength(1);

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    Console.Write($"{arr[j,i]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
