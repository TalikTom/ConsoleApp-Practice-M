using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class Helper
    {
        public static int GetIntFromConsole(string prompt)
        {
            int result;
            bool validInput = false;

            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }

            } while (!validInput);

            return result;
        }


        public static string GetStringFromConsole(string message)
        {
            string output = "";

            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }
        


    }
}
