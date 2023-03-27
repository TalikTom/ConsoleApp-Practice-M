using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class Parity
    {
        public static void CheckParity()
        {
            while (true)
            {
                Console.WriteLine("Enter a number to check if it's even or odd:");
                int input;

                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input! Please enter a valid whole number.");
                }

                if (input % 2 == 0)
                {
                    Console.WriteLine("The number you entered is even!");
                }
                else
                {
                    Console.WriteLine("The number you entered is odd!");
                }

                Console.WriteLine("Do you want to check another number? (Y/N)");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "n")
                {
                    break;
                }

                while (answer.ToLower() != "y" && answer.ToLower() != "n")
                {
                    Console.WriteLine("Invalid input! Please enter Y or N\n");
                    answer = Console.ReadLine();
                }

            }

        }
    }
}
