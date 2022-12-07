using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Algorithms
{
    internal static class QuickSort
    {
        internal static void QuickSortSample(IList<int> list, int method = 1)
        {
            var js = JsonSerializer.SerializeToDocument(list, list.GetType());
            Console.WriteLine($"Source array: {js.RootElement}");
            var newList = method == 1 ? QuickSort1(list) : QuickSort2(list);
            js = JsonSerializer.SerializeToDocument(newList, newList.GetType());
            Console.WriteLine($"Target array: {js.RootElement}");
            Console.WriteLine();
        }

        internal static IList<int> QuickSort1(IList<int> list)
        {
            if (list.Count < 2)
                return list;
            else
            {
                var pivot = list[list.Count / 2];
                var less = new List<int>();
                var greater = new List<int>();
                var equal = new List<int>();

                foreach (var x in list)
                {
                    if (x < pivot)
                        less.Add(x);
                    else if (x > pivot)
                        greater.Add(x);
                    else
                        equal.Add(x);
                }

                return QuickSort1(less).Concat(equal).Concat(QuickSort1(greater)).ToList();
            }
        }

        internal static IList<int> QuickSort2(IList<int> list)
        {
            var newList = new List<int>();

            return newList;
        }

    }
}
