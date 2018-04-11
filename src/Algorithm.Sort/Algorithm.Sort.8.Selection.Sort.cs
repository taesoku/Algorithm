using System.Collections.Generic;

namespace Algorithm.Sort
{
    public static class AlgorithmSort8SelectionSort
    {

        public static void Answer()
        {
            var inputs = new List<int> {2, 5, 1, 3, 4};
            SelectionSort(inputs);
        }

        public static int SelectionSort(List<int> inputs)
        {
            for (var i = 0; i < inputs.Count - 1; i++)
            {
                var min = i;
                for (var j = i + 1; i < inputs.Count; j++)
                    if (inputs[j] < inputs[min]) min = j;
                if (i == min) continue;
                var curr = inputs[i];
                inputs[i] = inputs[min];
                inputs[min] = curr;
            }
        }

    }
}
