using System;

namespace check_identifier
{
    public class Program
    {
        static bool is_letter(char ch)
        {
            return (ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z');
        }
        static bool is_digit(char ch)
        {
            return (ch >= '0' && ch <= '9');
        }

        public static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Wrong parameters count");
                return 1;
            }
            else
            {
                string input = args[0];
                if (input.Length > 0)
                {
                    if (is_digit(input[0]))
                    {
                        Console.WriteLine("no");
                        Console.WriteLine("identifier must be started with letter");
                        return 1;
                    }
                    for (int i = 1; i < input.Length; i++)
                    {
                        if (!is_letter(input[i]) && !is_digit(input[i]))
                        {
                            Console.WriteLine("no");
                            Console.WriteLine("identifier must contain only letters or numbers");
                            return 1;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("no");
                    Console.WriteLine("Empty string is not identifier");
                    return 1;
                }
            }
            Console.WriteLine("yes");
            return 0;
        }
    }
}