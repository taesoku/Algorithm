using System.Collections.Generic;

namespace Algorithm.Search
{

    public class AlgorithmSearchList1BinarySearch
    {

        // monday

        public static void Answer()
        {
            var index = 0;
            var inputs = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var outputLinear = BinarySearchLinear(inputs, 3, ref index);
            var outputRecursive = BinarySearchRecursive(inputs, 3, 0, 8);
        }

        public static bool BinarySearchLinear(List<int> inputs, int n, ref int index)
        {
            var max = inputs.Count - 1;
            var min = 0;
            do
            {
                var mid = (max + min) / 2;
                if (inputs[mid] == n)
                {
                    index = mid;
                    return true;
                }
                if (inputs[mid] < n) min = mid + 1;
                else max = mid - 1;
            } while (max > min);
            return false;
        }

        public static int BinarySearchRecursive(List<int> inputs, int x, int low, int high)
        {
            if (low > high) return -1;
            var mid = (low + high) / 2;
            if (inputs[mid] < x) return BinarySearchRecursive(inputs, x, mid + 1, high);
            if (inputs[mid] > x) return BinarySearchRecursive(inputs, x, low, mid - 1);
            return mid;
        }

    }

}
