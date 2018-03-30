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

        public static void InsertionSort(List<int> inputs)
        {
            for (int i = 1; i < inputs.Count; i++)
                for (int j = i; j > 0; j--)
                {
                    if (inputs[j - 1] > inputs[j])
                    {
                        var temp = inputs[j - 1];
                        inputs[j - 1] = inputs[j];
                        inputs[j] = temp;
                    }
                    else break;
                }
        }

    }
}
