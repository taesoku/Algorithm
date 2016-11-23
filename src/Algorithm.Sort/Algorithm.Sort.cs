using System;
using System.Diagnostics;

namespace Algorithm.Sort
{

    class AlgorithmSort
    {

        static void Main(string[] args)
        {
            var stopwatch = Stopwatch.StartNew();
            //AlgorithmSort1BubbleSort.Answer();
            //AlgorithmSort2BucketSort.Answer();
            //AlgorithmSort3HeapSort.Answer();
            AlgorithmSort4InsertionSort.Answer();
            //AlgorithmSort5MergeSort.Answer();
            //AlgorithmSort6QuickSort.Answer();
            //AlgorithmSort7RadixSort.Answer();
            //AlgorithmSort8SelectionSort.Answer();
            Console.WriteLine(stopwatch.ElapsedMilliseconds + " milliseconds taken for this operation.");
            Console.Read();
        }

    }

}
