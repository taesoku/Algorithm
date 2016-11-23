using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Sort
{
    public static class AlgorithmSort2BucketSort
    {

        public static void Answer()
        {
            var inputs = new List<int> { 29, 25, 3, 49, 9, 37, 21, 43 };
            BucketSort(inputs);
        }

        public static void BucketSort(List<int> inputs)
        {
            var max = inputs.Max();
            var min = inputs.Min();
            var buckets = new List<int>[max - min + 1];
            foreach (var input in inputs)
            {
                var temp = input - min;
                if (buckets[temp] == null) buckets[temp] = new List<int>();
                buckets[temp].Add(input);
            }
            var k = 0;
            for (int i = 0; i < buckets.Length; i++)
            {
                if (buckets[i] == null) continue;
                for (int j = 0; j < buckets[i].Count; j++)
                    inputs[k++] = buckets[i][j];
            }
        }

    }
}