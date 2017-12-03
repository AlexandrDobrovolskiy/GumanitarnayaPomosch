using System;

namespace arr85
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {0, 1, 2, 3, 4, 5, 6, 7, 8};

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
        private static void ChangeValues(ref int a , ref int b)
        {
            a += b;
            b -= a;
            b = -b;
            a -= b;
        }

        public static void ChangeArray(ref int[] arr)
        {
            for (int i = 1; i < arr.Length ; i++)
            {
                ChangeValues(ref arr[0],ref arr[i]);
            }
        }
    }
}
