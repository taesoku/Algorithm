using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Sort
{
    public static class AlgorithmSort7RadixSort
    {

        public static void Answer()
        {
            var inputs = new List<int> { 6, 5, 3, 1, 8, 7, 2, 4 };
            var outputs = RadixList(inputs);
        }

        public static List<int> RadixList(List<int> inputs, int digit = 1)
        {
            var isEmpty = true;
            var radix = new Hashtable();
            var temp = new int[inputs.Count];
            for (int i = 0; i < inputs.Count; i++)
            {
                var curr = inputs[i]/digit;
                radix[i] = curr%10;
                if (curr != 0) isEmpty = false;
            }
            if (isEmpty) return inputs;
            var sorted = RadixSort(radix);
            for (int i = 0; i < sorted.Count; i++)
                temp[i] = inputs[(int) sorted[i]];
            return RadixList(temp.ToList(), digit*10);
        } 

        public static Hashtable RadixSort(Hashtable radix)
        {
            var temp = new int[MaxHashtable(radix) + 1];
            var value = new Hashtable();
            for (int i = 0; i < radix.Count; i++) temp[(int) radix[i]]++;
            for (int i = 1; i < temp.Length; i++) temp[i] += temp[i - 1];
            for (int i = radix.Count - 1; i >= 0; i--)
            {
                var curr = (int) radix[i];
                var index = temp[curr];
                temp[curr]--;
                value[index - 1] = i;
            }
            return value;
        }

        public static int MaxHashtable(Hashtable radix)
        {
            var max = (int) radix[0];
            for (int i = 0; i < radix.Count; i++)
                max = max < (int) radix[i] ? (int) radix[i] : max;
            return max;
        }

    }
}
