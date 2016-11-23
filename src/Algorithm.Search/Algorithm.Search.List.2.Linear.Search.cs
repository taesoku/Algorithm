using System.Collections.Generic;

namespace Algorithm.Search
{

    public class AlgorithmSearchList2LinearSearch
    {
        public static void Answer()
        {
            var inputs = new List<int> {3, 6, 7, 1, 8, 12, 9, 5, 2, 96, 65, 43, 23, 56};
            var index = 0;
            var output = LinearSearch(inputs, 3, ref index);
        }

        public static bool LinearSearch(List<int> inputs, int n, ref int index)
        {
            for (int i = 0; i < inputs.Count; i++)
            {
                if (inputs[i] == n)
                {
                    index = i;
                    return true;
                }
                if (inputs[i] > n) return false;
            }
            return false;
        }

    }

}
