using System;
using System.Collections.Generic;
using System.Dynamic;

namespace arr100
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[]{1,1,1,3,3,3,4,5,5,9};
            List<int> res;
            Solution.RemoveDuplicatesElements(arr, out res);

            foreach (int element in res)
            {
                Console.Write(element + " ");
            }

            Console.ReadKey();
        }
    }

    static class Solution
    {


        public static void RemoveDuplicatesElements(int[] array, out List<int> result)
        {
            result = new List<int>(array);

            for (int i = 0; i < result.Count - 1; i++)
            {
                int k = 0;
                int countOfRepeats = 0;

                for (int j = 0; j < result.Count; j++)
                {
                    if (result[i] == result[j])
                    {
                        k = j;
                        countOfRepeats++;
                    }
                }
                if (countOfRepeats == 2)
                {
                    result.RemoveAt(k);
                    result.RemoveAt(i);
                    
                    i = 0;
                }
            }

        }

    }
}
