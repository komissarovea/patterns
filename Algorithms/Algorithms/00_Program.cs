using MathNet.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Algorithms
{
    internal class Program
    {
        static void Main() // string[] args
        {
            try
            {
                var arr1 = new int[] { 1, 2, 3, 4, 5 };
                var arr2 = arr1.Select(x => x * 2).ToArray();
                var sum = arr1.Aggregate("", (acc, x) =>
                {
                    return acc + x;
                });
                Console.WriteLine(sum);

                //DynamicProgramming.Sample();

                //GreedySetCovering.Sample();

                // DijkstrasAlgorithm.DijkstrasAlgorithmSample();

                //BreadthSearch.BreadthSearchSample();

                //BinarySearch.BinarySearchSample();

                //SelectionSort.SelectionSortSample(new List<int> { 7, 3, 5, 1, 9 });
                //SelectionSort.SelectionSortSample(new List<int> { 7, 3, 5, 1, 9 }, 2);

                //Console.WriteLine($"Factorial 0: {SpecialFunctions.Factorial(0)}");
                //Console.WriteLine($"Factorial 4: {Factorial.Factorial1(4)}");
                //Console.WriteLine($"Factorial 5: {Factorial.Factorial2(5)}");
                //Console.WriteLine($"Factorial 5: {Factorial.Factorial3(5)}");

                //QuickSort.QuickSortSample(new List<int> { 7, 3, 5, 1, 9 }, 2);
                //QuickSort.QuickSortSample(new List<int> { 7, 3, 5, 1, 1, 9 }, 1);

                //LinkNode linkNode= new LinkNode(1, new LinkNode(7, new LinkNode(9, new LinkNode(5))));
                //linkNode.Print();
                //Console.WriteLine(linkNode.GetLength());
                //LinkNode linkNode = new LinkNode(1, new LinkNode(2, new LinkNode(3, new LinkNode(4, new LinkNode(7)))));
                //var reversed = linkNode.Reverse();
                //reversed.Print();

                //BubbleSort.BubbleSortSample(new List<int> { 5, 1, 4, 2, 8 });
                //BubbleSort.BubbleSortSample(new List<int> { 8, 5, 4, 2, 1});
                // BubbleSort.BubbleSortSample(new List<int> { 7, 3, 5, 1, 9 }, 2);

                //InsertSort.InsertSortSample(new List<int> { 5, 2, 4, 6, 1, 3 });

                //MergeSort.MergeSortSample(new List<int> { 5, 2, 4, 6, 1, 3 });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


    }
}