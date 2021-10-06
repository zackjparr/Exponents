using System;

namespace Exponents
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            while (goOn == true)
            {
                int intNum = int.Parse(GetInput("Please enter an integer"));
                int intSquared = 0;
                int intCubed = 0;
                bool posiInt = NumCheck(intNum);
                if (posiInt == true)
                {
                    Console.WriteLine($"    Number   Squared          Cubed ");
                    Console.WriteLine("===================================");
                    for (int i = 1; i <= intNum; i++)
                    {
                        intSquared = i * i;
                        intCubed = i * i * i;
                        Console.WriteLine($"{i,10}{intSquared,10}{intCubed,15}");
                    }
                    goOn = Continue();
                }
                else
                {
                    Console.WriteLine();
                }
            }

        }

        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();
            return output;
        }


        public static bool Continue()
        {
            string answer = GetInput("Would you like to continue? y/n");
            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("I'm sorry, I didn't understand.");
                Console.WriteLine("Let's try again!");
                return Continue();
                //this is recursion, calling a method inside itself
            }
        }

        public static bool NumCheck(int num)
        {
            if (num <= 0)
            {
                Console.WriteLine("Please select a positive integer.");
                return false;
            }
            else if (num > 1290)
            {
                Console.WriteLine("Integer exceeds max value allowed.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
