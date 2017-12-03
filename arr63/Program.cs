using System;
using System.IO;

namespace arr63
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1,2,5,11,12};    //vmesto vvoda s consoli
            int[] b = {3,5,7,9,13};     //

            int[] c = Soution.MergeArrays(a, b);

            foreach (int i in c)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }

    static class Soution
    {
        public static int[] MergeArrays(int[] first, int[] second)
        {
            int[] res = new int[first.Length + second.Length];

            res[res.Length - 1] = second[second.Length - 1] > first[first.Length - 1] ?
                second[second.Length - 1] : first[first.Length -1];

            int j = 0;
            int k = 0;
            for (int i = 0; i < res.Length; i++)
            {
                if (j < first.Length && k < second.Length)
                {
                    if (first[j] < second[k])
                    {
                        res[i] = first[j];
                        j++;
                    }
                    else
                    {
                        res[i] = second[k];
                        k++;
                    }
                }
               
            }

            return res;
        }
    }
}
