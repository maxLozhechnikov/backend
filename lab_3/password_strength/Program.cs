using System;
using System.Collections.Generic;

namespace PasswordStrength
{
    public class Program
    {
        public const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
        public static bool IsPasswordValid(string Password)
        {
            foreach (char letter in Password)
            {
                if (!Alphabet.Contains(letter))
                {
                    return false;
                }
            }
            return true;
        }
        
        public static int Main(string[] args)
        {
            if (!CountArguments(args))
            {
                System.Console.WriteLine("Invalid count of arguments");
                return 1;
            }
            string Password = args[0];
            if (!IsPasswordNotEmpty(Password))
            {
                System.Console.WriteLine("Empty password cannot exist");
                return 1;
            }

            if (!IsPasswordValid(Password))
            {
                Console.WriteLine("Password can only contains english symbols and numbers");
                return 1;
            }
            Console.WriteLine(CalculatePasswordStrength(Password));
            return 0;
        }

        public static bool CountArguments(string[] args)
        {
            if(args.Length != 1)
            {
                return false;
            }
            return true;
        }

        public static bool IsPasswordNotEmpty(string Password)
        {
            if(Password.Length == 0)
            {
                return false;
            }
            return true;
        }

        public static int SecondStep(string Password)
        {
            return (Password.Length * 4);
        }

        public static int ThirdStep(string Password)
        {
            int CountOfDigits = 0;
            for(int i = 0; i<Password.Length; i++)
            {
                if (Char.IsDigit(Password[i]))
                {
                    CountOfDigits++;
                }
            }
            return (CountOfDigits * 4);
        }
        
        public static int ForthStep(string Password)
        {
            int CountOfUpperCase = 0;
            for (int i = 0; i < Password.Length; i++)
            {
                if (Char.IsLetter(Password[i]) && Char.IsUpper(Password[i]))
                {
                    CountOfUpperCase++;
                }
            }
            return ((Password.Length-CountOfUpperCase)*2);
        }

        public static int FifthStep(string Password)
        {
            int CountOfLowerCase = 0;
            for(int i = 0; i < Password.Length; i++)
            {
                if(Char.IsLetter(Password[i]) && Char.IsLower(Password[i]))
                {
                    CountOfLowerCase++;
                }
            }
            return ((Password.Length - CountOfLowerCase) * 2);
        }

        public static bool IsOnlyLetters(string Password)
        {
            for (int i = 0; i < Password.Length; i++)
            {
                if (Char.IsDigit(Password[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsOnlyDigits(string Password)
        {
            for (int i = 0; i < Password.Length; i++)
            {
                if (Char.IsLetter(Password[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static int SixthAndSeventhStep(string Password)
        {
            if (IsOnlyDigits(Password) || IsOnlyLetters(Password))
            {
                return Password.Length;
            }
            return 0;
        }

        public static int EighthStep(string Password)
        {
            int Count = 0;
            string Repetitions = "";
            for (int i = 0; i < Password.Length; i++)
            {
                int SubCount = 0;
                if (!Repetitions.Contains(Password[i]))
                {
                    Repetitions += Password[i];
                    for (int j = i; j < Password.Length; j++)
                    {
                        if (Password[j] == Password[i])
                        {
                            SubCount++;
                        }
                    }
                    if (SubCount > 1)
                    {
                        Count += SubCount;
                    }
                }
            }
            return Count;
        }

        public static int CalculatePasswordStrength(string Password)
        {
            int strength = 0;
            strength = strength + SecondStep(Password) + ThirdStep(Password) + ForthStep(Password) + FifthStep(Password) - SixthAndSeventhStep(Password) - EighthStep(Password);
            return strength;
        }
    }
}