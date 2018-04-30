using System;
using System.Diagnostics;

namespace Algorithm.Search
{

    class AlgorithmSearch
    {

        static void Main()
        {
            var stopwatch = Stopwatch.StartNew();
            AlgorithmSearchGraph1BreadthFirstSearch.Answer();
            //AlgorithmSearchList1BinarySearch.Answer();
            //AlgorithmSearchList2LinearSearch.Answer();
            Console.WriteLine(stopwatch.ElapsedMilliseconds + " milliseconds taken for this operation.");
            Console.Read();
        }

    }

}
