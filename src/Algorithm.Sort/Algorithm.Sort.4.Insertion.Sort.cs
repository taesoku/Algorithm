using System.Collections.Generic;

namespace Algorithm.Sort
{
    public static class AlgorithmSort4InsertionSort
    {

        // monday

        public static void Answer()
        {
            var inputs = new List<int> { 6, 5, 3, 1, 8, 7, 2, 4 };
            InsertionSort(inputs);
        }

        private static void InsertionSort(List<int> inputs)
        {
            for (var i = 1; i < inputs.Count; i++)
            {
                for (var j = i - 1; j >= 0; j--)
                {
                    if (inputs[j - 1] <= inputs[j]) continue;
                    var curr = inputs[j - 1];
                    inputs[j - 1] = inputs[j];
                    inputs[j] = curr;
                }
            }
        }

    }
}
