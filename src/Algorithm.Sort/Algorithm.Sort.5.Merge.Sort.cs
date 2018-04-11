using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Sort
{
    public static class AlgorithmSort5MergeSort
    {

        // tuesday

        public static void Answer()
        {

            var inputs1 = new List<int> { 6, 5, 3, 1, 8, 7, 2, 4 };
            var outputs1 = MergeList(inputs1);

            var inputs2 = new [] {6, 5, 3, 1, 8, 7, 2, 4};
            var outputs2 = MergeArray(inputs2);

        }

        // worst case space complexity: O(n)
        // best case time complexity: O(n log n) typical | O(n) natural variant
        // average case time complexity: O(n log n)
        // worst case time complexity: O(n log n)

        public static int[] MergeArray(int[] inputs)
        {
            var n = inputs.Length;
            if (n <= 1) return inputs;
            var middle = n / 2;
            var left = new int[middle];
            var right = new int[n - middle];
            for (int i = 0; i < middle; i++) left[i] = inputs[i];
            for (int i = 0; i < n - middle; i++) right[i] = inputs[middle + i];
            left = MergeArray(left);
            right = MergeArray(right);
            return MergeSort(left, right);
        }

        public static int[] MergeSort(int[] left, int[] right)
        {
            var m = left.Length;
            var n = right.Length;
            var temp = new int[m + n];
            var i = 0;
            var j = 0;
            var k = 0;
            while (i < m && j < n)
            {
                if (left[i] < right[j])
                    temp[k++] = left[i++];
                else
                    temp[k++] = right[j++];
            }
            while (i < m) temp[k++] = left[i++];
            while (j < n) temp[k++] = right[j++];
            return temp;
        }

        private static List<int> MergeList(List<int> inputs)
        {
            if (inputs.Count <= 1) return inputs;
            var left = new List<int>();
            var right = new List<int>();
            var middle = inputs.Count / 2;
            for (var i = 0; i < middle; i++) left.Add(inputs[i]);
            for (var i = middle; i < inputs.Count; i++) right.Add(inputs[i]);
            left = MergeList(left);
            right = MergeList(right);
            if (left.Last() > right.First()) return MergeSort(left, right);
            left.AddRange(right);
            return left;
        }

        private static List<int> MergeSort(List<int> left, List<int> right)
        {
            var curr = new List<int>();
            while (left.Count != 0 && right.Count != 0)
            {
                if (left.First() < right.First())
                {
                    curr.Add(left.First());
                    left.RemoveAt(0);
                }
                else
                {
                    curr.Add(right.First());
                    right.RemoveAt(0);
                }
            }
            curr.AddRange(left);
            curr.AddRange(right);
            return curr;
        }

    }
}