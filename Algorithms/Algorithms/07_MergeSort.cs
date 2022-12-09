using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Algorithms
{
    internal static class MergeSort
    {
        internal static void MergeSortSample(IList<int> list, int method = 1)
        {
            var js = JsonSerializer.SerializeToDocument(list, list.GetType());
            Console.WriteLine($"Source array: {js.RootElement}");
            var newList = MergeSort1(list);
            js = JsonSerializer.SerializeToDocument(newList, newList.GetType());
            Console.WriteLine($"Target array: {js.RootElement}");
            Console.WriteLine();
        }

        internal static IList<int> MergeSort1(IList<int> list)
        {
            if (list.Count <= 1)
                 return list;

            IList<int> left = new List<int>();
            IList<int> right = new List<int>();
            int middle = list.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(list[i]);
            }
            for (int i = middle; i < list.Count; i++)
            {
                right.Add(list[i]);
            }

            left = MergeSort1(left);
            right = MergeSort1(right);
            return Merge(left, right);           
        }

        private static List<int> Merge(IList<int> left, IList<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left[0] <= right[0])  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left[0]);
                        left.Remove(left[0]);      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right[0]);
                        right.Remove(right[0]);
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left[0]);
                    left.Remove(left[0]);
                }
                else if (right.Count > 0)
                {
                    result.Add(right[0]);
                    right.Remove(right[0]);
                }
            }
            return result;
        }
    }
}
