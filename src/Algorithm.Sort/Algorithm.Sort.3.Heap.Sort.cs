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

        public static void HeapList(List<int> inputs)
        {
            var size = inputs.Count;
            for (int i = (size - 1)/2; i >= 0; i--)
                HeapSort(inputs, size, i);
            for (int i = size - 1; i > 0; i--)
            {
                var temp = inputs[i];
                inputs[i] = inputs[0];
                inputs[0] = temp;
                size--;
                HeapSort(inputs, size);
            }
        }

        public static void HeapSort(List<int> inputs, int size, int index = 0)
        {
            var right = (index + 1)*2;
            var left = right - 1;
            var max = left < size && inputs[left] > inputs[index] ? left : index;
            max = right < size && inputs[right] > inputs[max] ? right : max;
            if (index != max)
            {
                var temp = inputs[index];
                inputs[index] = inputs[max];
                inputs[max] = temp;
                HeapSort(inputs, size, max);
            }
        }

    }
}
