using MathNet.Numerics.LinearAlgebra.Factorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Algorithms
{
    internal static class InsertSort
    {
        internal static void InsertSortSample(IList<int> list, int method = 1)
        {
            var js = JsonSerializer.SerializeToDocument(list, list.GetType());
            Console.WriteLine($"Source array: {js.RootElement}");
            var newList = InsertSort1(list);
            js = JsonSerializer.SerializeToDocument(newList, newList.GetType());
            Console.WriteLine($"Target array: {js.RootElement}");
            Console.WriteLine();
        }

        internal static IList<int> InsertSort1(IList<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                int x = list[i];
                int j = i;
                while (j > 0 && list[j - 1] > x)
                {
                    list[j] = list[j - 1];
                    j--;
                }
                list[j] = x;

                var js = JsonSerializer.SerializeToDocument(list, list.GetType());
                Console.WriteLine($" {i} Pass: {js.RootElement}");
            }

            return list;
        }
    }
}
