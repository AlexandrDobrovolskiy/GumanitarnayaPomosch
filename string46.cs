using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace String46
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter a sentence");
            string sentence = ReadLine();

            Solution solution = new Solution();
            WriteLine($"Max length = {solution.FindLength(sentence)}");
            ReadKey();
        }
    }

    class Solution
    {
        public int FindLength(string sentence)
        {
            int MaxLength = 0;
            int NumberOfLetters = 0;
            int IndexString = 0;
            char letter;
            while (IndexString < sentence.Length)
            {
                letter = sentence[IndexString];
                if (char.IsWhiteSpace(letter))
                {
                    NumberOfLetters = 0;
                }
                else if (char.IsLetter(letter))
                {
                    NumberOfLetters++;
                    if (NumberOfLetters > MaxLength)
                    {
                        MaxLength = NumberOfLetters;
                    };
                };
                IndexString++;
            };
            return (MaxLength);
        }
    }
}
