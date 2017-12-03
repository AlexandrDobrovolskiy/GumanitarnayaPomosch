using System;

namespace arr85
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 2};

            Solution.ChangeArray(ref array);

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }

    static class Solution
    {
        private static void ChangeValues(ref int a, ref int b)
        {
            a += b;
            b -= a;
            b = -b;
            a -= b;
        }

        public static void ChangeArray(ref int[] arr)
        {
            int k = findIndex(arr);
            
            for (int i = k + 1; i < arr.Length; i++)
            {
                ChangeValues(ref arr[k], ref arr[i]);   
            }
        }

        private static int findIndex(int[] arr)
        {
            int last = arr[arr.Length - 1];

            for (int i = 0; i < arr.Length; i++)
            {
                if (last < arr[i])
                {
                    return i;
                }
            }
            return arr.Length - 1;
        }
    }
}
