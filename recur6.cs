using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Recur6
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter N>0");
            int n = Convert.ToInt32(ReadLine());
            for (int IndexOperation = 1; IndexOperation <= 5; IndexOperation++)
            {
                int operation = 0;
                WriteLine($"{IndexOperation}. Enter k =>0 and <=n");
                int k = Convert.ToInt32(ReadLine());

                Solution solution = new Solution();
                int result = solution.Combination(n, k, ref operation);

                WriteLine($"result is {result}");
                WriteLine($"number of operations is {operation}");
            }
            ReadKey();
        }
    }

    class Solution
    {
        public int Combination(int n, int k, ref int operation)
        {
            operation++;
            int result;
            if (k == 0 || k == n)
                return 1;
            result = Combination(n - 1, k, ref operation) + Combination(n - 1, k - 1, ref operation);
            return result;
        }
    }
}
