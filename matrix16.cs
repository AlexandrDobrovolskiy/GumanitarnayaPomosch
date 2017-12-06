using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Matrix16
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter matrix order");
            int MatrixOrder = Convert.ToInt32(ReadLine());

            int[,] matrix = new int[MatrixOrder, MatrixOrder];
            WriteLine("Enter elements of matrix");
            for (int IndexRow = 0; IndexRow < MatrixOrder; IndexRow++)
            {
                for (int IndexColumn = 0; IndexColumn < MatrixOrder; IndexColumn++)
                {
                    matrix[IndexRow, IndexColumn] = Convert.ToInt32(ReadLine());
                }
            };
            Solution solution = new Solution();
            string rezult = solution.WriteWay(MatrixOrder, matrix);

            WriteLine($"Way is: {rezult}");
            ReadKey();
        }
    }

    class Solution
    {
        public string WriteWay(int MatrixOrder, int[,] matrix)
        {
            string way = "";
            int IndexBorderTop = 0;
            int IndexBorderLeft = 1;
            int IndexRow = 0;
            int IndexColumn = 0;
            for (int MaxStep = MatrixOrder - 1; MaxStep > 0; MaxStep--)
            {
                while (IndexRow < MaxStep)
                {
                    way = way + matrix[IndexRow, IndexColumn] + " ";
                    IndexRow++;
                };
                while (IndexColumn < MaxStep)
                {
                    way = way + matrix[IndexRow, IndexColumn] + " ";
                    IndexColumn++;
                }
                while (IndexRow > IndexBorderTop)
                {
                    way = way + matrix[IndexRow, IndexColumn] + " ";
                    IndexRow--;
                }
                while (IndexColumn > IndexBorderLeft)
                {
                    way = way + matrix[IndexRow, IndexColumn] + " ";
                    IndexColumn--;
                };
                IndexBorderTop += 1;
                IndexBorderLeft += 1;
            }
            int IndexCenter = MatrixOrder / 2;
            way += matrix[IndexCenter, IndexCenter];
            return (way);
        }
    }
}
