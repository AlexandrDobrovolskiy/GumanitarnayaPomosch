using System;
using System.Collections.Generic;

namespace arr116
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 1, 1, 2, 2, 1, 1, 3, 3, 3, 4};
            List<int> nOS;
            List<int> eOS;

            Solution.GetElementsOfSeries(array, out nOS, out eOS);

            foreach (int element in eOS)
               Console.Write(element + " ");

            Console.WriteLine();

            foreach (int num in nOS)
                Console.Write(num + " ");

            Console.ReadKey();
        }
    }

    static class Solution
    {
        public static void GetElementsOfSeries(int[] array, out List<int> numOfSeries, out List<int> elementsOfSeries)
        {
            numOfSeries = new List<int>();
            elementsOfSeries = new List<int>();                     // po zhelaniyu mozhno sdelat' s etih spiskov massivi kak v uslovii no ya dumayu v etom net neobhodimosti

            for (int i = 0; i < array.Length; i++)
            {
                elementsOfSeries.Add(array[i]);
                int k = i + 1;
                int m = i;
                while (k < array.Length && array[i] == array[k])
                {
                    k++;
                    i++;
                }
                numOfSeries.Add(k - m);
            }

            
        }
    }
}
