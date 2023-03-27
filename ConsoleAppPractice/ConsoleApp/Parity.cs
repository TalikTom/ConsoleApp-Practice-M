using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp
{
    public static class Parity
    {
        public static void CheckParity()
        {
            while (true)
            {
                int input = Helper.GetIntFromConsole("Enter a number to check if it's even or odd:");

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
