using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class Numerals
    {
        public static void SumLastDigits()
        {

            while (true)
            {
                int limiter = Helper.GetIntFromConsole("How many numbers do you want to enter? ");
                int sum = 0;

                for (int i = 0; i < limiter; i++)
                {
                    int input = Helper.GetIntFromConsole($"Enter number {i + 1}: ");
                    int lastDigit = input % 10;
                    sum += lastDigit;
                }

                Console.WriteLine($"The sum of the last digits of the {limiter} numbers is: {sum}");


                Console.WriteLine("Do you want to do it again? (Y/N)");



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
