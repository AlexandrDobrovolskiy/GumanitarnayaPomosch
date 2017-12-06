using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Matrix5
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Array with size MxN will be created. Enter values for it");
            WriteLine("Enter M>0 for number of rows");
            int NumberOfRows = Convert.ToInt32(ReadLine());
            WriteLine("Enter N>0 for number of columns");
            int NumberOfColumns = Convert.ToInt32(ReadLine());
            WriteLine("Enter D");
            int D = Convert.ToInt32(ReadLine());
            WriteLine($"Enter {NumberOfRows} values for first column");
            int[] FirstColumn = new int[NumberOfRows];
            for (int IndexArray = 0; IndexArray < NumberOfRows; IndexArray++)
            {
                FirstColumn[IndexArray] = Convert.ToInt32(ReadLine());
            };

            Solution solution = new Solution();
            solution.BuildArray(NumberOfRows, NumberOfColumns, D, FirstColumn, out int[,] matrix);

            WriteLine("Created matrix:");
            for (int IndexRow = 0; IndexRow < NumberOfRows; IndexRow++)
            {
                for (int IndexColumn = 0; IndexColumn < NumberOfColumns; IndexColumn++)
                {
                    Write($"{matrix[IndexRow, IndexColumn]} ");
                };
                WriteLine();
            };
            ReadKey();
        }
    }

    class Solution
    {
        public void BuildArray(int NumberOfRows, int NumberOfColumns, int D, int[] FirstColumn, out int[,] matrix)
        {
            matrix = new int[NumberOfRows, NumberOfColumns];
            for (int IndexRow = 0; IndexRow< NumberOfRows; IndexRow++)
            {
                for (int IndexColumn = 0; IndexColumn<NumberOfColumns; IndexColumn++)
                {
                    matrix[IndexRow, IndexColumn] = FirstColumn[IndexRow] + IndexColumn * D;
                }
            }
        }
    }
}
