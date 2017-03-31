using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Sort
{
    public static class AlgorithmSort5MergeSort
    {

        public static void Answer()
        {
            var inputs = new List<int> { 6, 5, 3, 1, 8, 7, 2, 4 };
            var outputs = MergeList(inputs);
        }

        // worst case space complexity: O(n)
        // best case time complexity: O(n log n) typical | O(n) natural variant
        // average case time complexity: O(n log n)
        // worst case time complexity: O(n log n)

        public static List<int> MergeList(List<int> inputs)
        {
            if (inputs.Count <= 1) return inputs;
            var left = new List<int>();
            var right = new List<int>();
            var middle = inputs.Count / 2;
            for (int i = 0; i < middle; i++) left.Add(inputs[i]);
            for (int i = middle; i < inputs.Count; i++) right.Add(inputs[i]);
            left = MergeList(left);
            right = MergeList(right);
            if (left.Last() <= right.First())
            {
                left.AddRange(right);
                return left;
            }
            return MergeSort(left, right);
        }

        public static List<int> MergeSort(List<int> left, List<int> right)
        {
            var temp = new List<int>();
            while (left.Count != 0 && right.Count != 0)
            {
                if (left.First() < right.First())
                {
                    temp.Add(left.First());
                    left.RemoveAt(0);
                }
                else
                {
                    temp.Add(right.First());
                    right.RemoveAt(0);
                }
            }
            temp.AddRange(left);
            temp.AddRange(right);
            return temp;
        }

    }
}