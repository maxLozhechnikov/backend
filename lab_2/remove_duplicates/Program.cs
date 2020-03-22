using System;
using System.Collections.Generic;

namespace remove_duplicates
{
    class Program
    {
        static void Main(string[] arguments)
        {
            if (arguments.Length != 1)
            {
                Console.WriteLine("Incorrect number of arguments!");
                Console.WriteLine("Usage RemoveDuplicates.exe <input string>");
            }
            else
            {
                HashSet<char> symbols_set = new HashSet<char>();
                string input = arguments[0];
                char temp;
                for (int i = 0; i < input.Length; i++)
                {
                    temp = input[i];
                    if (symbols_set.Contains(temp))
                    {
                        input = input.Remove(i, 1);
                        i--;
                    }
                    else
                    {
                        symbols_set.Add(temp);
                    }
                }

                Console.WriteLine(input);
            }
        }
    }
}