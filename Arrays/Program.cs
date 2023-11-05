using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            string input;
            bool closeApp = false;
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            Console.WriteLine("The following application sorts entered integers by odd and even and saves in lists!");

            while (!closeApp)
            {
                do
                {
                    Console.WriteLine("Please, enter an integer!");
                    input = Console.ReadLine();
                }
                while (String.IsNullOrEmpty(input) || !int.TryParse(input, out result));

                if (result % 2 == 0)
                {
                    evenNumbers.Add(result);
                }
                else
                {
                    oddNumbers.Add(result);
                }

                Console.WriteLine("Even numbers' list");
                Console.WriteLine(string.Join(", ", evenNumbers));

                Console.WriteLine("Odd numbers' list");
                Console.WriteLine(string.Join(", ", oddNumbers));

                Console.WriteLine("Hit any key to continue and hit spacebar to quit!");
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    closeApp = true;
                }

            }

        }
    }
}