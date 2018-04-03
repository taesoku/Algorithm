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

        public static void BucketSort(List<int> inputs )
        {
            var max = inputs.Max();
            var min = inputs.Min();
            var outputs = new List<int>[max - min + 1];
            foreach (var input in inputs)
            {
                var curr = input - min;
                if (outputs[curr] == null) outputs[curr] = new List<int>();
                outputs[curr].Add(input);
            }
            var k = 0;
            foreach (var output in outputs)
            {
                if (output == null) continue;
                foreach (var o in output) inputs[k++] = o;
            }
        }

    }
}