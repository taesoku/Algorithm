using System.Collections.Generic;

namespace Algorithm.Sort
{
    public static class AlgorithmSort3HeapSort
    {

        public static void Answer()
        {
            var inputs = new List<int> { 6, 5, 3, 1, 8, 7, 2, 4 };
            HeapList(inputs);
        }

        private static void HeapList(List<int> inputs)
        {
            var count = inputs.Count;
            for (var i = (count - 1) / 2; i >= 0; i--)
                HeapSort(inputs, count, i);
            for (var i = count - 1; i > 0; i--)
            {
                var curr = inputs[i];
                inputs[i] = inputs[0];
                inputs[0] = curr;
                count--;
                HeapSort(inputs, count);
            }
        }


        private static void HeapSort(List<int> inputs, int size, int index = 0)
        {
            var right = (index + 1) * 2;
            var left = right - 1;
            var max = left < size && inputs[left] > inputs[index] ? left : index;
            max = right < size && inputs[right] > inputs[max] ? right : max;
            if (index == max) return;
            var curr = inputs[index];
            inputs[index] = inputs[max];
            inputs[max] = curr;
            HeapSort(inputs, size, max);
        }

    }
}
