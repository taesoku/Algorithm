using System.Collections.Generic;

namespace Algorithm.Search
{

    public class AlgorithmSearchList1BinarySearch
    {

        public static void Answer()
        {
            var inputs = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
            var index = 0;
            var output = BinarySearch(inputs, 3, ref index);
        }

        public static bool BinarySearch(List<int> inputs, int n, ref int index)
        {
            var max = inputs.Count - 1;
            var min = 0;
            do
            {
                var mid = (max + min)/2;
                if (inputs[mid] == n)
                {
                    index = mid;
                    return true;
                }
                if (inputs[mid] < n) min = mid + 1;
                else max = mid - 1;
            } while (min < max);
            return false;
        }

    }

}
