using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class BinarySearch
    {
        internal static void BinarySearchSample()
        {
            var arr = new int[] { 1, 3, 5, 7, 9 };
            var js = JsonSerializer.SerializeToDocument(arr, arr.GetType());
            Console.WriteLine(js.RootElement.ToString());
            Console.WriteLine();

            int? index = BinarySearch.BinarySearch1(arr, 3);
            Console.WriteLine(index != null ? $"The item 3 is located by index {index}." : "The item 3 is not found in the list.");

            index = BinarySearch.BinarySearch2(arr, 5);
            Console.WriteLine(index != null ? $"The item 5 is located by index {index}." : "The item 5 is not found in the list.");

            index = BinarySearch.BinarySearch2(arr, 4);
            Console.WriteLine(index != null ? $"The item 4  is located by index {index}." : "The item 4 is not found in the list.");
        }

        internal static int? BinarySearch1(IEnumerable<int> list, int item)
        {
            int? retval = null;

            int start = 0;
            int end = list.Count() - 1;

            while (start <= end)
            {
                int index = (start + end) / 2;
                int mid = list.ElementAt(index);
                if (mid == item)
                {
                    retval = index;
                    break;
                }
                else if (mid < item)
                {
                    start = index + 1;
                }
                else
                {
                    end = index - 1;
                }
            }

            return retval;
        }

        internal static int? BinarySearch2(IEnumerable<int> list, int item)
        {
            int? retval = null;
            int end = list.Count() - 1;

            for (int start = 0; start <= end;)
            {
                int index = (start + end) / 2;
                int mid = list.ElementAt(index);
                if (mid == item)
                {
                    retval = index;
                    break;
                }
                else if (mid < item)
                {
                    start = index + 1;
                }
                else
                {
                    end = index - 1;
                }
            }

            return retval;
        }
    }
}
