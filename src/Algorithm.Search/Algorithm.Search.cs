using System;
using System.Diagnostics;

namespace Algorithm.Search
{

    class AlgorithmSearch
    {

        static void Main(string[] args)
        {
            var stopwatch = Stopwatch.StartNew();
            //AlgorithmSearch2D1BreadthFirstSearch.Answer();
            //AlgorithmSearchList1BinarySearch.Answer();
            //AlgorithmSearchList2LinearSearch.Answer();

            Console.WriteLine(stopwatch.ElapsedMilliseconds + " milliseconds taken for this operation.");
            Console.Read();
        }

    }

}
