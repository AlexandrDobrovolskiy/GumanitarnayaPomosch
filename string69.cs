using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace String69
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter a line");
            string line = ReadLine();

            Solution solution = new Solution();
            solution.ExploreLine(line, out string DescriptionResult, out int result);

            WriteLine(DescriptionResult + " " + result);
            ReadKey();
        }
    }

    class Solution
    {
        public void ExploreLine(string line, out string DescriptionResult, out int result)
        {
            int NumberOfOpeningBkt = 0;
            int NumberOfClosingBkt = 0;
            int IndexOfLastClsBkt = 0;
            int IndexLine = 0;
            while (IndexLine < line.Length)
            {
                if (line[IndexLine] == '(')
                {
                    NumberOfOpeningBkt++;
                }
                else if (line[IndexLine] == ')')
                {
                    NumberOfClosingBkt++;
                    IndexOfLastClsBkt = IndexLine;
                };
                IndexLine++;
            };
            if (NumberOfOpeningBkt > NumberOfClosingBkt)
            {
                DescriptionResult = "'(' is more than ')', result is";
                result = -1;
            }
            else if (NumberOfOpeningBkt == NumberOfClosingBkt)
            {
                DescriptionResult = "number of '(' = number of ')', result is";
                result = 0;
            }
            else
            {
                DescriptionResult = "'(' is less than ')', position of last ')' is";
                result = IndexOfLastClsBkt;
            }
        }
    }
}
