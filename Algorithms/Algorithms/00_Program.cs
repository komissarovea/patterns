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

                LinkNode linkNode = new LinkNode(1, new LinkNode(2, new LinkNode(3, new LinkNode(4, new LinkNode(7)))));
                var reversed = linkNode.Reverse();
                reversed.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


    }
}