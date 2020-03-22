using System;

namespace print_args
{
    class Program
    {
        static void Main(string[] arguments)
        {
            if (arguments.Length == 0)
            {
                Console.WriteLine("No parameters were specified!");
            }
            else
            {
                Console.WriteLine("Number of arguments: " + arguments.Length);
                Console.Write("Arguments: ");
                foreach (string argument in arguments)
                {
                    Console.Write(argument + " ");
                }
            }
        }
    }
}