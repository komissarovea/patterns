using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Algorithms
{
    internal static class SelectionSort
    {
        internal static void SelectionSortSample(IList<int> list, int method = 1)
        {
            var js = JsonSerializer.SerializeToDocument(list, list.GetType());
            Console.WriteLine($"Source array: {js.RootElement}");
            var newList = method == 1 ? SelectionSort1(list) : SelectionSort2(list);
            js = JsonSerializer.SerializeToDocument(newList, newList.GetType());
            Console.WriteLine($"Target array: {js.RootElement}");
            Console.WriteLine();
        }

        // public static IList<T> Selection<T>(IList<T> list) where T : IComparable<T>
        internal static IList<int> SelectionSort2(IList<int> list)
        {
            for (int i = 0; i < list.Count - 1; ++i)
            {
                int min = i;
                for (int j = i + 1; j < list.Count; ++j)
                {
                    if (list[j].CompareTo(list[min]) < 0)
                    {
                        min = j;
                    }
                }

                var dummy = list[i];
                list[i] = list[min];
                list[min] = dummy;
            }

            return list;
        }

        internal static IList<int> SelectionSort1(IList<int> list)
        {
            var newList = new List<int>();
            var count = list.Count;
            for (int i = 0; i < count; i++)
            {
                var minItem = FindSmallest(list);
                newList.Add(minItem);
                list.Remove(minItem);
            }
            return newList;
        }

        private static int FindSmallest(IList<int> list)
        {
            int retval = int.MaxValue; //list.Min(); 
            foreach (var item in list)
            {
                if (item < retval)
                    retval = item;
            }

            return retval;
        }


    }
}
