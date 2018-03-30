using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace Algorithm.Sort
{
    public static class AlgorithmSort6QuickSort
    {

        public static void Answer()
        {
            var inputs = new List<int> { 6, 5, 3, 1, 8, 7, 2, 4 };
            var outputs = QuickList(inputs);
        }

        public static List<int> QuickList(List<int> inputs)
        {
            if (inputs.Count <= 1) return inputs;
            var average = inputs.Average();
            var pivot = inputs.Where(i => i >= average).Min();
            if (inputs.First() == pivot) return inputs;
            QuickSort(inputs, pivot);
            var index = inputs.IndexOf(pivot);
            var left = new List<int>();
            var right = new List<int>();
            for (var i = 0; i < index; i++) left.Add(inputs[i]);
            for (var i = index; i < inputs.Count; i++) right.Add(inputs[i]);
            left = QuickList(left);
            right = QuickList(right);
            left.AddRange(right);
            return left;
        }

        public static void QuickSort(List<int> inputs, int pivot)
        {
            var left = 0;
            var right = inputs.Count - 1;
            while (left < right)
            {
                while (inputs[left] < pivot) left++;
                while (inputs[right] > pivot) right--;
                if (inputs[left] == inputs[right])
                {
                    right--;
                    continue;
                }
                if (left >= right) continue;
                var curr = inputs[left];
                inputs[left] = inputs[right];
                inputs[right] = curr;
            }
        }

    }
}
