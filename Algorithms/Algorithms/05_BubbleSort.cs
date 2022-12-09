using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Algorithms
{
    internal static class BubbleSort
    {
        internal static void BubbleSortSample(IList<int> list, int method = 1)
        {
            var js = JsonSerializer.SerializeToDocument(list, list.GetType());
            Console.WriteLine($"Source array: {js.RootElement}");
            var newList = method == 1 ? BubbleSort1(list) : BubbleSort2(list);
            js = JsonSerializer.SerializeToDocument(newList, newList.GetType());
            Console.WriteLine($"Target array: {js.RootElement}");
            Console.WriteLine();
        }

        internal static IList<int> BubbleSort1(IList<int> list)
        {
            int pass = 1;
            bool swaped = false;
            do
            {
                swaped = false;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i + 1] < list[i])
                    {
                        int temp = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = temp;
                        swaped = true;
                    }
                    var js = JsonSerializer.SerializeToDocument(list, list.GetType());
                    Console.WriteLine($" {pass} Pass: {js.RootElement}");
                }
                pass++;
            }
            while (swaped) ;

            return list;
        }

        internal static IList<int> BubbleSort2(IList<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < list[i])
                    {
                        int temp = list[j];
                        list[j] = list[i];
                        list[i] = temp;
                    }
                }
            }
            return list;
        }
    }
}
