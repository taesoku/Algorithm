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

        public static void SelectionSort(List<int> inputs)
        {
            for (var i = 0; i < inputs.Count; i++)
            {
                var min = i;
                for (var j = i + 1; j < inputs.Count; j++)
                    if (inputs[j] < inputs[min]) min = j;
                if (i == min) continue;
                var curr = inputs[i];
                inputs[i] = inputs[min];
                inputs[min] = curr;
            }
        }

    }
}
