using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class Quadratic
    {
        public static void CalculateQuadratic()
        {
            while (true)
            {

                Console.WriteLine("Enter 3 integers to calculate quadratic equation: ");

                int a, b, c;

                a = Helper.GetIntFromConsole("Enter the first integer: ");
                b = Helper.GetIntFromConsole("Enter the second integer: ");
                c = Helper.GetIntFromConsole("Enter the third integer: ");


                double discriminant = Math.Pow(b, 2) - 4 * a * c;

                // Check if discriminant is negative (no real solutions)
                if (discriminant < 0)
                {
                    Console.WriteLine("This quadratic equation has no real solutions.");

                }

                // Calculate solutions using quadratic formula
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                Console.WriteLine("The solutions to the quadratic equation are:");
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);

                Console.WriteLine("Do you want to solve another equation? (Y/N)");
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
