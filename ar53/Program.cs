using System;
using System.IO;

namespace ar53
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new[] {1, 2, 3, 4, 5};        // vmesto inputa s consoli
            int[] b = new[] {2, 3, 4, 5, 6};        //

            int[] result = Solution.ArrMaxElements(a, b);

            foreach (int num in result)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();
        }
    }

    static class Solution
    {
        public static int[] ArrMaxElements(int[] first, int[] second)
        {
            if(first.Length != second.Length)                                                 // ne obyazatelno
            {                                                                                 //
                throw new InvalidDataException("The length off arrays must be equal");        //
            }                                                                                 //

            int[] res = new int[first.Length];
                
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] > second[i]) res[i] = first[i];
                else res[i] = second[i];
            }

            return res;
        }
    }
}
