using System.Collections;

namespace Algorithms
{
    internal class Program
    {
        static void Main() // string[] args
        {
            int? index = BinarySearch(new int[] { 1, 3, 5, 7, 9 }, 3);
            Console.WriteLine(index != null ? $"The item is located by index {index}." : "The item is not found in the list.");
        }

        static int? BinarySearch(IEnumerable<int> list, int item)
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
    }
}